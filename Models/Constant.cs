﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BGMOrderAutomation.Models
{
    class Constant
    {
        public static SqlConnection connect = new SqlConnection("Data Source=DESKTOP-71BP9LD\\SQLEXPRESS;Initial Catalog=OrderAutomation;Integrated Security=True");
    }
}