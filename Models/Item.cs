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

        public Item() { }
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

        public List<Item> getAll()
        {
            List<Item> itemList = new List<Item>();
            SqlCommand cmd = new SqlCommand 
            {
                Connection = Constant.connect,
                CommandText = "SELECT * FROM Items"
            };
           
            Constant.connect.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Item item = new Item(
                        Convert.ToInt32(reader["id"]),
                        reader["item_name"].ToString(),
                        Convert.ToInt32(reader["item_quantity"]),
                        float.Parse(reader["item_price"].ToString()),
                        Convert.ToInt32(reader["company_id"]),
                        float.Parse(reader["weight"].ToString()),
                        Convert.ToInt32(reader["tax"])
                        );
                    itemList.Add(item);
                }

                Constant.connect.Close();
            }
            return itemList;
        }

        public Item getItemByID(int id)
        {
            Item item = new Item();
            SqlCommand cmd = new SqlCommand
            {
                Connection = Constant.connect,
                CommandText = "SELECT * FROM Items WHERE id=@id"
            };
            cmd.Parameters.AddWithValue("@id", id);
            Constant.connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                item = new Item(
                    Convert.ToInt32(reader["id"]),
                    reader["item_name"].ToString(),
                    Convert.ToInt32(reader["item_quantity"]),
                    float.Parse(reader["item_price"].ToString()),
                    Convert.ToInt32(reader["company_id"]),
                    float.Parse(reader["weight"].ToString()),
                    Convert.ToInt32(reader["tax"])
                    );
            }

            Constant.connect.Close();
        
            return item;
        }

        static public List<Item> getAllItemsByCompanyId(int companyId)
        {
            List<Item> itemList = new List<Item>();
            SqlCommand cmd = new SqlCommand
            {
                Connection = Constant.connect,
                CommandText = "SELECT * FROM Items WHERE company_id = " + companyId.ToString()
            };

            Constant.connect.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Item item = new Item(
                        Convert.ToInt32(reader["id"]),
                        reader["item_name"].ToString(),
                        Convert.ToInt32(reader["item_quantity"]),
                        float.Parse(reader["item_price"].ToString()),
                        Convert.ToInt32(reader["company_id"]),
                        float.Parse(reader["weight"].ToString()),
                        Convert.ToInt32(reader["tax"])
                        );
                    itemList.Add(item);
                }

                Constant.connect.Close();
            }
            return itemList;
        }
    
        public void updateItem()
        {
            string commandText = "UPDATE Items SET " +
                "item_name = @item_name , " +
                "item_quantity = @item_quantity , " +
                "item_price = @item_price , " +
                "tax = @tax , " +
                "weight = @weight WHERE id = @id";

            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@item_name",name),
                new SqlParameter("@item_quantity",quantity),
                new SqlParameter("@item_price",price),
                new SqlParameter("@tax",tax),
                new SqlParameter("@weight",weight),
                new SqlParameter("@id", id)
            };

            SQLManager.runQuery(parameters, commandText);
        }
    }
}
