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
        public void addCustomer()
        {
            Constant.connect.Open();
            SqlParameter[] parameters = new SqlParameter[]
           {
               new SqlParameter("@username", username),
               new SqlParameter("@password", password),
               new SqlParameter("@company_id", companyId),
               new SqlParameter("@address", address),
           };

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Constant.connect;
            cmd.CommandText = "INSERT INTO Customers values(@username,@password,@company_id,@address)";
            foreach (SqlParameter parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }
            cmd.ExecuteNonQuery();
            Constant.connect.Close();
        }
    }
}



    

