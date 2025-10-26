using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrphanageManagementSystem
{
    public class OrphanManage
    {
        public int orphanID { get; set; }

        public string Name { get; set;  }
        public int Age { get; set;  }
        public string orphanGender { get; set; }
        public string BloodGroup { get; set; }
        public string orphanCustodianName { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }


        //Database Connection
        MyConnection mco = new MyConnection();


        //Datatable
        public DataTable select()
        {
            DataTable dt1 = new DataTable();
            string query = "select * from Orphan";
            SqlDataAdapter sa = new SqlDataAdapter(query, mco.con);
            sa.Fill(dt1);
            return dt1; 
        }


        //Data Inserting: 
        public bool Insert(OrphanManage o)
        {
            bool isSuccess = false;
            try
            {
                string query = "insert into Orphan(orphanID, Name, Age, orphanGender, BloodGroup, orphanCustodianName, Number, Address, Email) values (@orphanID, @Name, @Age, @orphanGender, @BloodGroup, @orphanCustodianName, @Number, @Address, @Email)";
                SqlCommand cmd = new SqlCommand(query, mco.con);

                cmd.Parameters.AddWithValue("@orphanID", o.orphanID);
                cmd.Parameters.AddWithValue("@Name", o.Name);
                cmd.Parameters.AddWithValue("@Age", o.Age);
                cmd.Parameters.AddWithValue("@orphanGender", o.orphanGender);
                cmd.Parameters.AddWithValue("@BloodGroup", o.BloodGroup);
                cmd.Parameters.AddWithValue("@orphanCustodianName", o.orphanCustodianName);
                cmd.Parameters.AddWithValue("@Number", o.Number);
                cmd.Parameters.AddWithValue("@Address", o.Address);
                cmd.Parameters.AddWithValue("@Email", o.Email);
                mco.con.Open(); 

                if(mco.con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery(); 
                    if(rows > 0)
                    {
                        isSuccess = true; 
                    }
                }
            }
            catch (Exception ex )
            {

                
            }
            finally
            {
                mco.con.Close(); 
            }

            return isSuccess; 
        }

        //Data Deleting
        public bool Delete(OrphanManage o)
        {
            bool isSuccess = false;
            try
            {
                string query = "delete from Orphan Where orphanID = @orphanID";
                SqlCommand cmd = new SqlCommand(query, mco.con);

                cmd.Parameters.AddWithValue("@orphanID", o.orphanID);
                mco.con.Open();

                if (mco.con.State == ConnectionState.Open)
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
                mco.con.Close();
            }
            return isSuccess; 

        }


        

        
    }
}
