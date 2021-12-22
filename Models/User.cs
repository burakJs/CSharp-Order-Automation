using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
       
    }
}
