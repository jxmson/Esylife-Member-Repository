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
        public Members(string bm, string ID, string name, string surname, int contact, string sponsor)
        {
            BM_Number = bm;
            Name = name;
            Surname = surname;
            ContactNum = contact;
            ID_Number = ID;
            Sponsor = sponsor;
        }
        public Members()
        {

        }

        public string BM_Number { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ContactNum { get; set; }
        public string Sponsor { get; set; }
        public string ID_Number { get; set; }

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
                string sql = "SELECT * FROM Members";
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
                string sql = "INSERT INTO Members (BM_Number, Name, Surname, ID_Number, Contact_Number, Sponsor) " +
                    "VALUES (@BM_Number, @Name, @Surname,@ID, @Contact, @Sponsor)";
                SqlCommand cmd = new SqlCommand(sql, conn); //Creating SQL command
                //3.Create parameter to add data
                cmd.Parameters.AddWithValue("@BM_Number", m.BM_Number);
                cmd.Parameters.AddWithValue("@Name", m.Name);
                cmd.Parameters.AddWithValue("@Surname", m.Surname);
                cmd.Parameters.AddWithValue("@ID", m.ID_Number);
                cmd.Parameters.AddWithValue("@Contact", m.ContactNum);
                cmd.Parameters.AddWithValue("@Sponsor", m.Sponsor);

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
                string sql = "UPDATE Members SET BM_Number=@BM_Number, Name=@Name, Surname=@Surname, ID_Number=@ID_Number, Contact=@Contact, Sponsor=@Sponsor "+
                    "WHERE BM_Number=@BM_Number";
                SqlCommand cmd = new SqlCommand(sql, conn); //Creating SQL command
                //3.Create parameter to add data
                cmd.Parameters.AddWithValue("@BM_Number", m.BM_Number);
                cmd.Parameters.AddWithValue("@Name", m.Name);
                cmd.Parameters.AddWithValue("@Surname", m.Surname);
                cmd.Parameters.AddWithValue("@ID_Number", m.ID_Number);
                cmd.Parameters.AddWithValue("@Contact", m.ContactNum);
                cmd.Parameters.AddWithValue("@Sponsor", m.Sponsor);

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
                string sql = "DELETE FROM Members WHERE BM_Number=@BM_Number";
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
        public DataTable Search(string keyword)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "select * from Members where Name like '%'+@keyword+'%' or Surname like '%'+@keyword+'%' or BM_Number like '%'+@keyword+'%'";
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
    }
}
