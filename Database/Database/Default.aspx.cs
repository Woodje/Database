using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["Login"] == "Test")
            {
                Label1.Text = "_Test_";
            }
            if (Session["Login"] == "Test2")
            {
                Label1.Text = "_Test2_";
            }
        }
        catch
        {
        }
        finally
        {
        }
        if (Label1.Text == "_Test_" || Label1.Text == "_Test2_")
        {
            if (Label1.Text == "_Test_")
            {
                Session["Login"] = "Test";
            }
            if (Label1.Text == "_Test2_")
            {
                Session["Login"] = "Test2";
            }
        }
        else
        {
            Response.Redirect("~/Database/Login.aspx");
        }
    }
    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Database/Valg.aspx");
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Database/Search.aspx");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Session["Ny"] = "Ny";
        Response.Redirect("~/Database/Kunder.aspx");
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Database/Delete.aspx");
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Database/Kalender.aspx");
    }
}