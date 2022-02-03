using OnlineFootWareApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineFootwareApp
{
    public partial class OrderStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FootdbConn con = new FootdbConn();
            DataTable dt = new DataTable();
            dt = con.Status();
            GStatus.DataSource = dt;
            GStatus.DataBind();
        }
    }
}