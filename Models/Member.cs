using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGMOrderAutomation.Models
{
    public class Member
    {
       public int memberId { get; set; }
       public String username { get; set; }
       public String password { get; set; }

        public Member(int memberId, String username,String password)
        {
            this.memberId = memberId;
            this.username = username;
            this.password = password;
        }
    }
}
