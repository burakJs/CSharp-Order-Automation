using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGMOrderAutomation.Models
{
    public class Customer:Member
    {
        public Company company { get; set; }

        public Customer(Company company,int memberId, String username, String password) : base(memberId,username,password)
        {
            this.company =company;
        }


    }
}
