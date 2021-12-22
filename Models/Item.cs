using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BGMOrderAutomation.Models
{

    public class Item
    {
        public int id { get; set; }
        public String name { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }
        public int companyId { get; set; }
        public float weight { get; set; }
        public int tax { get; set; }

        public Item(int id, String name, int quantity, float price, int companyId, float weight, int tax)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.companyId = companyId;
            this.weight = weight;
            this.tax = tax;
        }

        public float getWeight()
        {
            return this.weight;
        }

        public float getPriceForQuantity(int quantity)
        {
            return this.price * quantity;
        }

        public void addItem()
        {
            Constant.connect.Open();
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@item_name", name),
                new SqlParameter("@item_quantity", quantity),
                new SqlParameter("@item_price", price),
                new SqlParameter("@company_id", companyId),
                new SqlParameter("@tax", tax),
                new SqlParameter("@weight", weight)
           };

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Constant.connect;
            cmd.CommandText = "INSERT INTO Items values(@item_name,@item_quantity,@item_price,@company_id,@tax,@weight)";
            foreach (SqlParameter parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }
            cmd.ExecuteNonQuery();
            Constant.connect.Close();
        }
    }
}
