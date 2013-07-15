using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Hosting;
using System.Data;
using System.Xml;
using System.Text;

public partial class Delete : System.Web.UI.Page
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

        //get the dataview of table "Country", which is default table name  
        DataView dv = ds.Tables["Kunde"].DefaultView;
        //or we can use:  
        //DataView dv = ds.Tables[0].DefaultView;  
        Kunder.DataSource = dv;
        //Now sort the DataView vy column name "Name"  


        //now define datatext field and datavalue field of dropdownlist  

        Kunder.DataTextField = "Navn";
        Kunder.DataValueField = "ID";
        //now bind the dropdownlist to the dataview  

        Kunder.DataBind();
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Kunder.Text != "")
        {
            ImageButton1.Visible = false;
            ImageButton2.Visible = false;
            Kunder.Enabled = false;
            Label1.Visible = true;
            ImageButton3.Visible = true;
            ImageButton4.Visible = true;
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Database/Default.aspx");
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        if (Kunder.Text != "")
        {
            ImageButton1.Visible = true;
            ImageButton2.Visible = true;
            Kunder.Enabled = true;
            Label1.Visible = false;
            ImageButton3.Visible = false;
            ImageButton4.Visible = false;
        }
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        SletKunde();
        Response.Redirect("~/Database/Delete.aspx");
    }
    protected void SletKunde()
    {
        XmlDocument doc = new XmlDocument();
        //Load XML from the file into XmlDocument object
        doc.Load(Database);

        XmlNode root = doc.DocumentElement;
        StringBuilder sb = new StringBuilder();
        //Select all nodes with the tag Book
        XmlNodeList nodeList = root.SelectNodes("Kunde");
        //Loop through each node under the node “Book”
            foreach (XmlNode node in nodeList)
            {
                if (node.SelectSingleNode("ID").InnerText == Kunder.Text)
                    node.ParentNode.RemoveChild(node);
            }
            doc.Save(Database);
    }
}