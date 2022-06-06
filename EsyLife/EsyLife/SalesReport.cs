using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace EsyLife
{
    class Sale
    {
        public string PurchaseNumber { get; set; }
        public DateTime Date { get; set; }
        public string BMNumber { get; set; }
        public string NameSurname { get; set; }
        public List<Product> ProductsSold { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Saletotal { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public void SaveToTextFile()
        {

        }
        public bool Insert(Sale report)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                conn.Open();
                string sql = "Insert into Sales (Date, BM_Number, Name_Surname, Payment_Method, Sale_Total)" + "values(@date, @bm, @name, @method, @total)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@date", report.Date);
                cmd.Parameters.AddWithValue("@bm", report.BMNumber);
                cmd.Parameters.AddWithValue("@name", report.NameSurname);
                cmd.Parameters.AddWithValue("@method", report.PaymentMethod);
                cmd.Parameters.AddWithValue("@total", report.Saletotal);

                int cont = cmd.ExecuteNonQuery();

                if (cont == 0)
                    return false;

                foreach (Product p in report.ProductsSold)
                {
                    string sqlComposite = "Insert into Sales_Products(PurchaseNumber, ProductID)" + "values (@purchase, @product)";
                    SqlCommand cmd2 = new SqlCommand(sqlComposite, conn);
                    cmd2.Parameters.AddWithValue("@purchase", report.PurchaseNumber);
                    cmd2.Parameters.AddWithValue("@product", "(select isnull(max(ProductID),0) + 1 from Sales_Products) ");
                    cmd2.ExecuteNonQuery();
                }



            }
            catch
            {
                isSuccess = false;
            }
            finally
            {

            }

            return isSuccess;
        }
        public bool InsertProductList(Sale report)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                SqlCommand cmd2;
                string sql = "";
                if (report.ProductsSold != null)
                {
                    foreach (Product p in report.ProductsSold)
                    {
                        sql = "Insert into Sales_Products(PurchaseNumber, ProductID)" + "values (@purchase, @product)";
                        cmd2 = new SqlCommand(sql, conn);
                        cmd2.Parameters.AddWithValue("@purchase", report.PurchaseNumber);
                        cmd2.Parameters.AddWithValue("@product", "(select isnull(max(ProductID),0) + 1 from Sales_Products) ");
                        cmd2.ExecuteNonQuery();
                    }
                }
            }
            catch {
                isSuccess = false;
            }
            return isSuccess;
        }

    }
}
