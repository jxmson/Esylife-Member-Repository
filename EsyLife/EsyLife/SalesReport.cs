using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                foreach (Product p in report.ProductsSold)
                {
                    string sqlComposite = "Insert into Sales_Products(PurchaseNumber, ProductID)" + "values (@purchase, @product)";
                    SqlCommand cmd2 = new SqlCommand(sqlComposite, conn);
                    cmd.Parameters.AddWithValue("@purchase", report);
                }
                
                

            }
            catch
            {

            }
            finally
            {

            }
        }
        public bool InsertProductList(Sale report)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "";
            }
            return 
        }

    }
}
