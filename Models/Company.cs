using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BGMOrderAutomation.Models
{
   public class Company
    {
        public int companyId { get; set; }
        public string companyName { get; set; }
        public Customer customer { get; set; }
        public List<Item> itemList { get; set; }
        public List<User> userList { get; set; }

        public Company(int companyId, string companyName, Customer customer, List<Item> itemList, List<User> userList)
        {
            this.companyId = companyId;
            this.companyName = companyName;
            this.customer = customer;
            this.itemList = itemList;
            this.userList = userList;
        }

        public Company()
        {

        }
        public void addCompany()
        {
            string commandText = "INSERT INTO Company(company_name,owner_id) VALUES(@companyName,@ownerId)";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@companyName",companyName),
                new SqlParameter("@ownerId", customer.memberId)
            };
            SQLManager.runQuery(parameters, commandText);
        }

        static public Company getCompanyById(int companyId)
        {
            Company company;
            Constant.connect.Open();
            SqlCommand cmd = new SqlCommand
            {
                Connection = Constant.connect,
                CommandText = "SELECT * FROM Company where id="+companyId.ToString()
            };
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                company = new Company((int)reader["id"], reader["company_name"].ToString(), new Customer(), new List<Item>(), new List<User>());
                Constant.connect.Close();
                return company;
            }
            else
            {
                Constant.connect.Close();
                return new Company();
            }

        }
    }
}
