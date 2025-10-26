using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrphanageManagementSystem
{
    class Expense
    {
        public string product { get; set; }
        public string Description { get; set; }
        public int amount { get; set; }
        public int rate { get; set; }
        public int Total { get; set; }

        MyConnection mc = new MyConnection();

        //DataTable
        public DataTable Select()
        {
            DataTable dt4 = new DataTable();
            string query = "select * from Expense; ";
            SqlDataAdapter da = new SqlDataAdapter(query, mc.con);
            da.Fill(dt4);
            return dt4;
        }

        //Data Inserting 
        public bool Insert(Expense e)
        {
            bool isSuccess = false;
            try
            {
                string query = "insert into Expense(product, Description, amount, rate, Total) values (@product, @Description, @amount, @rate, @Total)";
                SqlCommand cmd = new SqlCommand(query, mc.con);

                cmd.Parameters.AddWithValue("@product", e.product);
                cmd.Parameters.AddWithValue("@Description", e.Description);
                cmd.Parameters.AddWithValue("@amount", e.amount);
                cmd.Parameters.AddWithValue("@rate", e.rate);
                cmd.Parameters.AddWithValue("@Total", e.Total);
                
               

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
        public bool Delete(Expense e)
        {
            bool isSuccess = false;
            try
            {
                string query = "delete from Expense Where product=@product; ";
                SqlCommand cmd = new SqlCommand(query, mc.con);

                cmd.Parameters.AddWithValue("@product", e.product);
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

        //Calculation
        public bool Calculation(Expense e)
        {
            bool isSuccess = false;
            try
            {
                string query = "select product=@product, Description=@Description, amount=@amount, rate=@rate, (amount*rate) as Total=@Total from Expense;";
                SqlCommand cmd = new SqlCommand(query, mc.con);

                cmd.Parameters.AddWithValue("@product", e.product);
                cmd.Parameters.AddWithValue("@Description", e.Description);
                cmd.Parameters.AddWithValue("@amount", e.amount);
                cmd.Parameters.AddWithValue("@rate", e.rate);
                cmd.Parameters.AddWithValue("@Total", e.Total);

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

    }
}
