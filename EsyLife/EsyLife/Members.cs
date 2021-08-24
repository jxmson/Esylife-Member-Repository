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
    class Members
    {
        public Members(string bm, string name, string surname, int contact)
        {
            BM_Number = bm;
            Name = name;
            Surname = surname;
            ContactNum = contact;
        }
        public Members()
        {

        }

        public string BM_Number { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ContactNum { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //selecting All Data from Database
        public DataTable SelectData()
        {
            //1.Database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //2.SQL query
                string sql = "SELECT * FROM Member";
                SqlCommand cmd = new SqlCommand(sql, conn); //Creating SQL command
                //3.Creating Adapter
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
        //selecting 1 record from the database
        public DataTable SelectBM(string BM)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //2.SQL query
                string sql = "SELECT * FROM Member WHERE BM_Number=@BM_Number";
                SqlCommand cmd = new SqlCommand(sql, conn); //Creating SQL command
                cmd.Parameters.AddWithValue("@BM_Number", BM);
                //3.Creating Adapter
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
        public DataTable SelectName(string name)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //2.SQL query
                string sql = "SELECT * FROM Member WHERE Name=@Name";
                SqlCommand cmd = new SqlCommand(sql, conn); //Creating SQL command
                cmd.Parameters.AddWithValue("@Name", name);
                //3.Creating Adapter
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
        public DataTable SelectSurname(string sname)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //2.SQL query
                string sql = "SELECT * FROM Member WHERE Surname=@Surname";
                SqlCommand cmd = new SqlCommand(sql, conn); //Creating SQL command
                cmd.Parameters.AddWithValue("@Surname", sname);
                //3.Creating Adapter
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

        //inserting Data into Database
        public bool InsertData(Members m)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;

            //1. Database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //2.SQL query
                string sql = "INSERT INTO Member (BM_Number, Name, Surname, Contact) " +
                    "VALUES (@BM_Number, @Name, @Surname, @Contact)";
                SqlCommand cmd = new SqlCommand(sql, conn); //Creating SQL command
                //3.Create parameter to add data
                cmd.Parameters.AddWithValue("@BM_Number", m.BM_Number);
                cmd.Parameters.AddWithValue("@Name", m.Name);
                cmd.Parameters.AddWithValue("@Surname", m.Surname);
                cmd.Parameters.AddWithValue("@Contact", m.ContactNum);

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
        //Update data in database
        public bool UpdateData(Members m)
        {//Creating default return type and setting its value to false
            bool isSuccess = false;

            //1. Database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //2.SQL query
                string sql = "UPDATE Member SET BM_Number=@BM_Number, Name=@Name, Surname=@Surname, Contact=@Contact "+
                    "WHERE BM_Number=@BM_Number";
                SqlCommand cmd = new SqlCommand(sql, conn); //Creating SQL command
                //3.Create parameter to add data
                cmd.Parameters.AddWithValue("@BM_Number", m.BM_Number);
                cmd.Parameters.AddWithValue("@Name", m.Name);
                cmd.Parameters.AddWithValue("@Surname", m.Surname);
                cmd.Parameters.AddWithValue("@Contact", m.ContactNum);

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
        //Delete data in database
        public bool DeleteData(Members m)
        {
            bool isSuccess = false;

            //1. Database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //2.SQL query
                string sql = "DELETE FROM Member WHERE BM_Number=@BM_Number";
                SqlCommand cmd = new SqlCommand(sql, conn); //Creating SQL command
                //3.Create parameter to add data
                cmd.Parameters.AddWithValue("@BM_Number", m.BM_Number);

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
    }
}
