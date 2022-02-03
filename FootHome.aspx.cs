using OnlineFootwareApp.Model;
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
    public partial class FootHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            div1.Visible = false;
        }

        protected void Vbtn_Click(object sender, EventArgs e)
        {
            FootProp foot = new FootProp();
            FootdbConn db = new FootdbConn();
            foot.ProdCat = categories.SelectedValue;
            DataTable dt = new DataTable();
            dt = db.ViewDb(foot);
            GVD.DataSource = dt;
            GVD.DataBind();
            div1.Visible = true;
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            Session["value"] = txtCode.Text;
            Response.Redirect("Order.aspx");
        }

        protected void btnStatus_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderStatus.aspx");
        }
    }
}