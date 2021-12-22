using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGMOrderAutomation.Models
{
   public class Company
    {
        public int companyId { get; set; }
        public Customer customer { get; set; }
        public List<String> itemList { get; set; }
        public List<User> userList { get; set; }

        public Company(int companyId, Customer customer, List<String> itemList, List<User> userList)
        {
            this.companyId = companyId;
            this.customer = customer;
            this.itemList = itemList;
            this.userList = userList;
            

        }


    }
}
