using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Hosting;
using System.Data;

public partial class Valg : System.Web.UI.Page
{
    string Database = HostingEnvironment.ApplicationPhysicalPath + "\\Log\\Kunder.xml";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Login"] != "Test")
        {
            if (Session["Login"] != "Test2")
            {
                Response.Redirect("~/Database/Login.aspx");
            }
        }
        if (!IsPostBack)
        {
            //call to the function to populate dropdownlist from xml  
            Kunderne();
        }
    }
    public void Kunderne()
    {
        DataSet ds = new DataSet();
        ds.ReadXml(Database);
        DataTable test = ds.Tables["Kunde"].Clone();
        test.ImportRow(ds.Tables["Kunde"].Rows[0]);
        for (int i = ds.Tables["Kunde"].Rows.Count - 1; i-1 >= 0; i--)
        {
            test.ImportRow(ds.Tables["Kunde"].Rows[i]);
        }
        Kunder.DataSource = test;
        Kunder.DataTextField = "Navn";
        Kunder.DataValueField = "ID";
        Kunder.DataBind();
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Kunder.Text != "")
        {
            Session["KundeNr"] = Kunder.Text;
            Response.Redirect("~/Database/Kunder.aspx");
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Database/Default.aspx");
    }
}