using OnlineFootwareApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineFootWareApp.Model
{
    public class FootdbConn
    {
        string ConnectionStr = "Data Source=100.72.130.5;Initial Catalog=Training;Persist Security Info=True;User ID=TrainingUsr;Password=Tr@ininGU$r@#321";

        public DataTable ViewDb(FootProp foot)
        {
            SqlConnection con = new SqlConnection(ConnectionStr);
            SqlDataAdapter da = new SqlDataAdapter($"select ProdCode ,ProdName,ProdCost  from FootMates where ProdCat = '{foot.ProdCat}'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        

        public StatusProperty Fetch(FootProp foot)
        {
            StatusProperty status = new StatusProperty();
            SqlConnection con = new SqlConnection(ConnectionStr);
            SqlDataAdapter da = new SqlDataAdapter($"select * from FootMates where ProdCode = {foot.ProdCode} ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            status.ProductCode= Convert.ToInt32(dt.Rows[0][0]);
            status.ProductName = dt.Rows[0][1].ToString();
            status.Price= Convert.ToInt32(dt.Rows[0][2]);
            return status;
        }
        public string Payment(StatusProperty status)
        {
            SqlConnection con = new SqlConnection(ConnectionStr);
            con.Open();
            SqlCommand cmd = new SqlCommand($"insert into BillingCart values('{status.ProductName}',{status.Price},{status.Quantity},{status.TotalAmount},{status.ProductCode})", con); ;
            cmd.ExecuteNonQuery();
            con.Close();
            return "Payment Successfull";
        }
        public DataTable Status()
        {
            SqlConnection con = new SqlConnection(ConnectionStr);
            SqlDataAdapter da = new SqlDataAdapter($"select * from MyFootWareOrder", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}