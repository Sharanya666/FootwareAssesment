using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineFootwareApp.Model;
using OnlineFootWareApp.Model;

namespace OnlineFootwareApp
{
    public partial class Order : System.Web.UI.Page
    {
        FootProp foot = new FootProp();
        FootdbConn con = new FootdbConn();

        protected void Page_Load(object sender, EventArgs e)
        {

            FootdbConn con = new FootdbConn();

            if (!IsPostBack)
            {
                lblProductCode.Text = "" + Session["value"];
                foot.ProdCode = Convert.ToInt32(Session["value"]);
                StatusProperty status = con.Fetch(foot);

                lblProductName.Text = status.ProductName;
                lblPrice.Text = status.Price.ToString();
            }
        }


        protected void btnPayment_Click(object sender, EventArgs e)
        {

            StatusProperty op = new StatusProperty();
            op.ProductCode = Convert.ToInt32(lblProductCode.Text);
            op.ProductName = lblProductName.Text;
            op.Price = Convert.ToInt32(lblPrice.Text);
            op.Quantity = Convert.ToInt32(txtQuantity.Text);
            op.TotalAmount = Convert.ToInt32(lblTotalAmount.Text);
            string msg = con.Payment(op);
            Response.Write($"<script>alert('{msg}')</script>");

        }

        protected void btnBill_Click(object sender, EventArgs e)
        {
            foot.ProdCode = Convert.ToInt32(Session["value"]);
            StatusProperty op = con.Fetch(foot);
            int Quantity = Convert.ToInt32(txtQuantity.Text);
            lblTotalAmount.Text = Convert.ToString(op.Price * Quantity);
        }
    }
}