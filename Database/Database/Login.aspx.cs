using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        if (TextBox1.Text == "Test" && TextBox2.Text == "Test")
        {
            Session["Login"] = "Test";
            Response.Redirect("~/Database/Default.aspx");
        }
        else if (TextBox1.Text == "Test2" && TextBox2.Text == "Test2")
        {
            Session["Login"] = "Test2";
            Response.Redirect("~/Database/Default.aspx");
        }
    }
}