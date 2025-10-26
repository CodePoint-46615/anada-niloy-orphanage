using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrphanageManagementSystem
{
    class Donor
    {
        public int donorID { get; set; }
        public string donorName { get; set; }
        public string donorAddress { get; set; }
        public string donorEmail { get; set; }
        public string donationAmount { get; set; }

        MyConnection mc = new MyConnection();

        //DataTable
        public DataTable Select()
        {
            DataTable dt3 = new DataTable();
            string query = "select * from Donor";
            SqlDataAdapter da = new SqlDataAdapter(query, mc.con);
            da.Fill(dt3);
            return dt3;
        }

        //Data Inserting 
        public bool Insert(Donor d)
        {
            bool isSuccess = false;
            try
            {
                string query = "insert into Donor(donorID, donorName, donorAddress, donorEmail, donationAmount) values (@donorID, @donorName, @donorAddress, @donorEmail, @donationAmount)";
                SqlCommand cmd = new SqlCommand(query, mc.con);

                cmd.Parameters.AddWithValue("@donorID", d.donorID);
                cmd.Parameters.AddWithValue("@donorName", d.donorName);
                cmd.Parameters.AddWithValue("@donorAddress", d.donorAddress);
                cmd.Parameters.AddWithValue("@donorEmail", d.donorEmail);
                cmd.Parameters.AddWithValue("@donationAmount", d.donationAmount);
                
                mc.con.Open();

                if (mc.con.State == ConnectionState.Open)
                {
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        isSuccess = true;
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                mc.con.Close();
            }
            return isSuccess;
        }

        //Data Deleting
        public bool Delete(Donor d)
        {
            bool isSuccess = false;
            try
            {
                string query = "delete from Donor where donorID = @donorID";
                SqlCommand cmd = new SqlCommand(query, mc.con);

                cmd.Parameters.AddWithValue("@donorID", d.donorID);
                mc.con.Open();

                if (mc.con.State == ConnectionState.Open)
                {
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        isSuccess = true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                mc.con.Close();
            }
            return isSuccess;

        }

        //Updating data into database table
        public bool Update(Donor d)
        {
            
            bool isSuccess = false;
            try
            {
                string query = "update Donor set donorID=@donorID, donorName=@donorName, donorAddress=@donorAddress, donorEmail=@donorEmail, donationAmount=@donationAmount where donorID=@donorID" ;

                //Creating cmd using sql and connection string
                SqlCommand cmd = new SqlCommand(query, mc.con);

                cmd.Parameters.AddWithValue("@donorID", d.donorID);
                cmd.Parameters.AddWithValue("@donorName", d.donorName);
                cmd.Parameters.AddWithValue("@donorAddress", d.donorAddress);
                cmd.Parameters.AddWithValue("@donorEmail", d.donorEmail);
                cmd.Parameters.AddWithValue("@donationAmount", d.donationAmount);

                mc.con.Open();

                if (mc.con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                mc.con.Close();
            }
            return isSuccess;
        }
    }
}
