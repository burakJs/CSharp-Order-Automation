using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BGMOrderAutomation.Models
{
    public class Customer : Member
    {
        public String address { get; set; }
        public int companyId { get; set; }


        public Customer( int memberId, String username, String password, String address) : base(memberId, username, password)
        {
            this.address = address;
        }

        public Customer()
        {

        }
        public void addCustomer()
        {
          SqlParameter[] parameters = new SqlParameter[]
           {
               new SqlParameter("@username", username),
               new SqlParameter("@password", password),
               new SqlParameter("@company_id", companyId),
               new SqlParameter("@address", address),
           };

            string commandText = "INSERT INTO Customers values(@username,@password,@company_id,@address)";

            SQLManager.runQuery(parameters, commandText);
        }

        public bool loginCustomer()
        {
            Constant.connect.Open();
            SqlCommand cmd = new SqlCommand
            {
                Connection = Constant.connect,
                CommandText = "SELECT * FROM Customers WHERE username=@user AND password=@pass"
            };
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);
            SqlDataReader reader = cmd.ExecuteReader();
            bool result;
            
            if (reader.Read())
            {
                result = true;
            }
            else
            {
                result = false;
            }
            Constant.connect.Close();
            if (result)
            {
                Constant.connect.Open();
                cmd = new SqlCommand
                {
                    Connection = Constant.connect,
                    CommandText = "SELECT TOP 1 * FROM LoginCustomer"
                };
                reader = cmd.ExecuteReader();
                
                bool state = reader.Read();
                string id = state ? reader["id"].ToString() : "1111"; 
                Constant.connect.Close();
                if (!state)
                {
                    string commandText = "INSERT INTO LoginCustomer VALUES(@username,@company_id,@address,@customer_id)";
                    SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@username",username),
                    new SqlParameter("@company_id",companyId),
                    new SqlParameter("@address",this.address),
                    new SqlParameter("@customer_id",memberId)
                };
                    SQLManager.runQuery(parameters, commandText);
                }
                else
                {
                    string commandText = "UPDATE LoginCustomer SET username = @username , company_id = @company_id , address = @address , customer_id = @customer_id WHERE id =" + id;
                    SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@username",username),
                    new SqlParameter("@company_id",companyId),
                    new SqlParameter("@address",this.address),
                    new SqlParameter("@customer_id",memberId)
                };
                    SQLManager.runQuery(parameters, commandText);
                }

                
            }
            return result;
        }

        static public Customer getLoginedCustomer()
        {
            Customer customer;
            Constant.connect.Open();
            SqlCommand cmd = new SqlCommand
            {
                Connection = Constant.connect,
                CommandText = "SELECT * FROM LoginCustomer" 
            };
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                customer = new Customer((int)reader["customer_id"], reader["username"].ToString(), "", reader["address"].ToString());
                customer.companyId = (int)reader["company_id"];
                Constant.connect.Close();
                return customer;
            }
            else
            {
                Constant.connect.Close();
                return new Customer();
            }

        }
    }
}



    

