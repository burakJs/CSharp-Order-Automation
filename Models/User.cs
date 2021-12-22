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
        public int totalShopping { get; set; }

        public User(int Id, String username, String password,String address, int totalShopping) : base(Id,username,password)
        {
            this.address = address;
            this.totalShopping = totalShopping;
        }
        public void addUser()
        {
            Constant.connect.Open();
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@total_shopping", totalShopping),
           };

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Constant.connect;
            cmd.CommandText = "INSERT INTO Users values(@username,@password,@total_shopping)";
            foreach (SqlParameter parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }
            cmd.ExecuteNonQuery();
            Constant.connect.Close();
        }

    }
}
