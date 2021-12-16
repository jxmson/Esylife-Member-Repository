using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsyLife
{
    public class Product
    {
        public Product(string name, decimal bPrice, decimal regbPrice, int quantity)
        {
            Name = name;
            bulkPrice = bPrice;
            regbulkPrice = regbPrice;
            Quantity = quantity;     
        }
        public Product()
        {

        }
        public string Name { get; set; }
        public decimal regbulkPrice { get; set; }
        public decimal bulkPrice { get; set; }
        public int Quantity { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public DataTable SelectData()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from Product";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public bool Insert(Product product)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "Insert into Product (ProductName, ProductPrice, MemberProductPrice, ProductQuantity) " + "values (@Name, @Price, @MemberPrice, @Quantity)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Price", product.bulkPrice);
                cmd.Parameters.AddWithValue("@MemberPrice", product.regbulkPrice);
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    isSuccess = true;
                else
                    isSuccess = false;
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public bool Update(Product product)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "Update Product set ProductName = @Name, ProductPrice = @Price, MemberProductPrice = @MemberPrice, ProcutQuantity= @Quantity";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Price", product.bulkPrice);
                cmd.Parameters.AddWithValue("@MemberPrice", product.regbulkPrice);
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    isSuccess = true;
                else
                    isSuccess = false;
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public bool Delete(Product product)
        {
            bool isSuccess = false;

            //1. Database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //2.SQL query
                string sql = "DELETE FROM Product WHERE ProductName=@Name";
                SqlCommand cmd = new SqlCommand(sql, conn); //Creating SQL command
                //3.Create parameter to add data
                cmd.Parameters.AddWithValue("@Name", product.Name);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully, the no. of rows will be greater than zero else its value will be zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public DataTable Search(string keyword)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "select * from Product where ProductName like '%'+@keyword+'%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@keyword", keyword);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable GetBulkQuantity(string name)
        {

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "select Quantity from Product where ProductName = @name";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public decimal GetMemberPrice(string name)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            decimal price = 0;

            try
            {
                string sql = "select MemberProductPrice from Product where ProductName = @name";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                    price = decimal.Parse(dt.Rows[0].ToString());
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return price;
        }
        public decimal GetPrice(string name)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            decimal price = 0;

            try
            {
                string sql = "select ProductPrice from Product where ProductName = @name";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                    price = decimal.Parse(dt.Rows[0].ToString());
            }        
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return price;
        }
      
    }
}
