using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrphanageManagementSystem
{
    public class Register

    {
        public int ID { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String Email { get; set; }
        public String Number { get; set; }
        public String Role { get; set; }
        public String Age { get; set; }
        public String userName { get; set; }
        public String Password { get; set; }
        public String prefarableTime { get; set; }

        MyConnection mcr = new MyConnection();

        //DataTable
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            string query = "Select * from Register";          
            SqlDataAdapter sda = new SqlDataAdapter(query, mcr.con);
            sda.Fill(dt);
            return dt;
        }

        //Inserting Data
        public bool Insert(Register r)
        {

            bool isSuccess = false;
            try
            {
                string query = "insert into Register(ID, firstName, lastName, Email, Number, Role, Age, userName, Password, prefarableTime) values (@ID, @firstName, @lastName, @Email, @Number, @Role, @Age, @userName, @Password, @prefarableTime)";
                SqlCommand cmd = new SqlCommand(query, mcr.con);

                cmd.Parameters.AddWithValue("@ID", r.ID);
                cmd.Parameters.AddWithValue("@firstName", r.firstName);
                cmd.Parameters.AddWithValue("@lastName", r.lastName);
                cmd.Parameters.AddWithValue("@Email", r.Email);
                cmd.Parameters.AddWithValue("@Number", r.Number);
                cmd.Parameters.AddWithValue("@Role", r.Role);
                cmd.Parameters.AddWithValue("@Age", r.Age);
                cmd.Parameters.AddWithValue("@userName", r.userName);
                cmd.Parameters.AddWithValue("@Password", r.Password);
                cmd.Parameters.AddWithValue("@prefarableTime", r.prefarableTime);
                
                mcr.con.Open();

                if (mcr.con.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
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
                mcr.con.Close();
            }
            return isSuccess;
        }

    }
}
