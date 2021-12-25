using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BGMOrderAutomation.Models
{
    public class User:Member
    {
        public String address { get; set; }
        public float totalShopping { get; set; }

        public User(int Id, String username, String password,String address, float totalShopping) : base(Id,username,password)
        {
            this.address = address;
            this.totalShopping = totalShopping;
        }
        public User()
        {

        }
        public void createUser()
        {
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@total_shopping", totalShopping),
           };
            string commandText = "INSERT INTO Users values(@username,@password,@total_shopping)";
            SQLManager.runQuery(parameters, commandText);
        }

        public bool loginUser()
        {
            
            
            Constant.connect.Open();
            SqlCommand cmd = new SqlCommand
            {
                Connection = Constant.connect,
                CommandText = "SELECT * FROM Users where username=@user AND password=@pass"
            };
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);
            SqlDataReader reader = cmd.ExecuteReader();
            bool result = reader.Read();
            Constant.connect.Close();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username",username),
                new SqlParameter("@total_shopping",totalShopping),
                new SqlParameter("@id",1),
                new SqlParameter("@userId",this.memberId)
            };
            string commandText = @"IF EXISTS(SELECT * FROM LoginUser WHERE id = 1)
                            UPDATE LoginUser 
                            SET username = @username,total_shopping=@total_shopping, user_id=@userId
                            WHERE id = 1
                        ELSE
                            INSERT INTO LoginUser(username, total_shopping, user_id) VALUES(@username, @total_shopping, @userId);";
            SQLManager.runQuery(parameters, commandText);
            return result;
        }

        static public User getLoginedUser()
        {
            User user;
            Constant.connect.Open();
            SqlCommand cmd = new SqlCommand
            {
                Connection = Constant.connect,
                CommandText = "SELECT * FROM LoginUser where id=1"
            };
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                user = new User((int)reader["id"], reader["username"].ToString(), "", "", float.Parse(reader["total_shopping"].ToString()));
                Constant.connect.Close();
                return user;
            }
            else
            {
                Constant.connect.Close();
                return new User();
            }
            
            
        }
    
        public void updateUserTotalShopping(float amount)
        {
            string commandText = "UPDATE Users SET total_shopping = @total_shopping WHERE id = @id";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@total_shopping",totalShopping + amount),
                new SqlParameter("@id", memberId)
            };
            SQLManager.runQuery(parameters, commandText);
        }
    
        static public List<User> getAllUsers()
        {
            List<User> userList = new List<User>();
            SqlCommand cmd = new SqlCommand
            {
                Connection = Constant.connect,
                CommandText = "SELECT * FROM Users"
            };

            Constant.connect.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    User user = new User(
                        (int)reader["id"],
                        reader["username"].ToString(),
                        reader["password"].ToString(),
                        "",
                        float.Parse(reader["total_shopping"].ToString())
                        );
                    userList.Add(user);
                }

                Constant.connect.Close();
            }
            return userList;
        }
    }
}
