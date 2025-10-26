using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrphanageManagementSystem
{
    class Employee
    {
        public String Name { get; set; }
        public int ID { get; set; }
        public String Email { get; set; }
        public String Role { get; set; }
        public String PreferableTIme { get; set; }
        public String MobileNumber { get; set; }

        //Database Connection
        MyConnection mc = new MyConnection(); 

        //DataTable
         public DataTable Select()
        {
            DataTable dt2 = new DataTable();
            string query = "select * from Employee";
            SqlDataAdapter da = new SqlDataAdapter(query, mc.con);
            da.Fill(dt2);
            return dt2; 
            
        }

        //Data Inserting 
        public bool Insert(Employee em)
        {
            bool isSuccess = false;
            try
            {
                string query = "insert into Employee(Name, ID, Email, Role, PreferableTIme, MobileNumber)values(@Name, @ID, @Email, @Role, @PreferableTIme, @MobileNumber)";
                SqlCommand cmd = new SqlCommand(query, mc.con);

                cmd.Parameters.AddWithValue("@Name", em.Name);
                cmd.Parameters.AddWithValue("@ID", em.ID);
                cmd.Parameters.AddWithValue("@Email", em.Email);
                cmd.Parameters.AddWithValue("@Role", em.Role);
                cmd.Parameters.AddWithValue("@PreferableTIme", em.PreferableTIme);
                cmd.Parameters.AddWithValue("@MobileNumber", em.MobileNumber);

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
        public bool Delete(Employee em)
        {
            bool isSuccess = false;
            try
            {
                string query = "delete from Employee where ID = @ID";
                SqlCommand cmd = new SqlCommand(query, mc.con);

                cmd.Parameters.AddWithValue("@ID", em.ID);
                mc.con.Open();

                if(mc.con.State == ConnectionState.Open)
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

        //UpdateRole
        public bool UpdateRole(Employee em)
        {
            bool isSuccess = false;
            try
            {
                string query = "update Employee set Role =@Role where ID = @ID;";
                SqlCommand cmd = new SqlCommand(query, mc.con);

                cmd.Parameters.AddWithValue("@Role", em.Role);
                cmd.Parameters.AddWithValue("@ID", em.ID);
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
            catch (Exception e)
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
