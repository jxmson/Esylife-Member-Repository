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
    class NewMembers
    {
        public NewMembers()
        {

        }
        public NewMembers(string ID, string name, string surname, int contact, string sponsor)
        {
            ID_Number = ID;
            Name = name;
            Surname = surname;
            ContactNum = contact;
            Sponsor = sponsor;
        }
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
                string sql = "SELECT * FROM Unregistered_Members";
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
        public bool InsertData(NewMembers m)
        {
            //Creating default return type and setting its value to false
            bool isSuccess = false;

            //1. Database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //2.SQL query
                string sql = "INSERT INTO Unregistered_Members (IDNumber, Name, Surname, Contact, Sponsor) " +
                    "VALUES (@IDNumber, @Name, @Surname, @Contact, @Sponsor)";
                SqlCommand cmd = new SqlCommand(sql, conn); //Creating SQL command
                //3.Create parameter to add data
                cmd.Parameters.AddWithValue("@IDNumber", m.ID_Number);
                cmd.Parameters.AddWithValue("@Name", m.Name);
                cmd.Parameters.AddWithValue("@Surname", m.Surname);
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
        public bool UpdateData(NewMembers m)
        {//Creating default return type and setting its value to false
            bool isSuccess = false;

            //1. Database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //2.SQL query
                string sql = "UPDATE Unregistered_Members SET IDNumber=@IDNumber, Name=@Name, Surname=@Surname, Contact=@Contact " +
                    "WHERE IDNumber=@IDNumber";
                SqlCommand cmd = new SqlCommand(sql, conn); //Creating SQL command
                //3.Create parameter to add data
                cmd.Parameters.AddWithValue("@IDNumber", m.ID_Number);
                cmd.Parameters.AddWithValue("@Name", m.Name);
                cmd.Parameters.AddWithValue("@Surname", m.Surname);
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

        //public bool SelectMember()
        //Delete data in database
        public bool DeleteData(NewMembers m)
        {
            bool isSuccess = false;

            //1. Database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //2.SQL query
                string sql = "DELETE FROM Unregistered_Members WHERE IDNumber=@IDNumber";
                SqlCommand cmd = new SqlCommand(sql, conn); //Creating SQL command
                //3.Create parameter to add data
                cmd.Parameters.AddWithValue("@IDNumber", m.ID_Number);

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
                string sql = "select * from Unregistered_Members where Name like '%'+@keyword+'%' or Surname like '%'+@keyword+'%' or IDNumber like '%'+@keyword+'%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@keyword", keyword);
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

    }
}
