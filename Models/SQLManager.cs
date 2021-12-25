using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BGMOrderAutomation.Models
{
    public class SQLManager
    {
        static public void runQuery(SqlParameter[] parameters, String commandText)
        {
            Constant.connect.Open();

            SqlCommand cmd = new SqlCommand
            {
                Connection = Constant.connect,
                CommandText = commandText
            };
            foreach (SqlParameter parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }
            cmd.ExecuteNonQuery();
            Constant.connect.Close();
        }

    }
}
