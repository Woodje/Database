using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Text;
using System.Web.Hosting;

public partial class Search : System.Web.UI.Page
{
    string Database = HostingEnvironment.ApplicationPhysicalPath + "\\Log\\Kunder.xml";

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["Login"] == "Test")
            {
                Label11.Text = "_Test_";
            }
            if (Session["Login"] == "Test2")
            {
                Label11.Text = "_Test2_";
            }
        }
        catch
        {
        }
        finally
        {
        }
        if (Label11.Text == "_Test_" || Label11.Text == "_Test2_")
        {
            if (Label11.Text == "_Test_")
            {
                Session["Login"] = "Test";
            }
            if (Label11.Text == "_Test2_")
            {
                Session["Login"] = "Test2";
            }
        }
        else
        {
            Response.Redirect("~/Database/Login.aspx");
        }
        if (!IsPostBack)
        {
            //add attribute on the search textbox
            //so that when enter key is pressed in the textbox,
            //the search button will be fired
            TextBox1.Attributes.Add("onkeypress", "return clickButton(event,'" + ImageButton1.ClientID + "')");                                               
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        LoadKunde();
        TextBox1.Focus();
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Database/Default.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["KundeNr"] = Session["KundeNr1"];
        Response.Redirect("~/Database/Kunder.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Session["KundeNr"] = Session["KundeNr2"];
        Response.Redirect("~/Database/Kunder.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Session["KundeNr"] = Session["KundeNr3"];
        Response.Redirect("~/Database/Kunder.aspx");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Session["KundeNr"] = Session["KundeNr4"];
        Response.Redirect("~/Database/Kunder.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Session["KundeNr"] = Session["KundeNr5"];
        Response.Redirect("~/Database/Kunder.aspx");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Session["KundeNr"] = Session["KundeNr6"];
        Response.Redirect("~/Database/Kunder.aspx");
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Session["KundeNr"] = Session["KundeNr7"];
        Response.Redirect("~/Database/Kunder.aspx");
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Session["KundeNr"] = Session["KundeNr8"];
        Response.Redirect("~/Database/Kunder.aspx");
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Session["KundeNr"] = Session["KundeNr9"];
        Response.Redirect("~/Database/Kunder.aspx");
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Session["KundeNr"] = Session["KundeNr10"];
        Response.Redirect("~/Database/Kunder.aspx");
    }
    protected void LoadKunde()
    {
        LinkButton1.Text = "";
        Label1.Text = "";
        LinkButton2.Text = "";
        Label2.Text = "";
        LinkButton3.Text = "";
        Label3.Text = "";
        LinkButton4.Text = "";
        Label4.Text = "";
        LinkButton5.Text = "";
        Label5.Text = "";
        LinkButton6.Text = "";
        Label6.Text = "";
        LinkButton7.Text = "";
        Label7.Text = "";
        LinkButton8.Text = "";
        Label8.Text = "";
        LinkButton9.Text = "";
        Label9.Text = "";
        LinkButton10.Text = "";
        Label10.Text = "";
        string selectedValue = RadioButtonList1.SelectedValue, value = "";
        if (selectedValue == "" || TextBox1.Text == "")
        {
        }   
        else
        {
            if (selectedValue == "1")
                value = "Navn";
            else if (selectedValue == "2")
                value = "Adresse";
            else if (selectedValue == "3")
                value = "PostBy";
            else if (selectedValue == "4")
                value = "Tlf";
            else if (selectedValue == "5")
                value = "Computer";
            else if (selectedValue == "6")
                value = "Email";

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
                if (node.SelectSingleNode(value).InnerText.ToUpper().Contains(TextBox1.Text.ToUpper()))
                {
                    if (LinkButton1.Text == "")
                    {
                        //Select the text from a single node, “Title” in this case
                        LinkButton1.Text = node.SelectSingleNode("Navn").InnerText;
                        Session["KundeNr1"] = node.SelectSingleNode("ID").InnerText;
                        Label1.Text = " | " + node.SelectSingleNode("Adresse").InnerText + " | " + node.SelectSingleNode("PostBy").InnerText + " | " + node.SelectSingleNode("Tlf").InnerText + " | " + node.SelectSingleNode("Email").InnerText + " |";
                    }
                    else if (LinkButton2.Text == "")
                    {
                        //Select the text from a single node, “Title” in this case
                        LinkButton2.Text = node.SelectSingleNode("Navn").InnerText;
                        Session["KundeNr2"] = node.SelectSingleNode("ID").InnerText;
                        Label2.Text = " | " + node.SelectSingleNode("Adresse").InnerText + " | " + node.SelectSingleNode("PostBy").InnerText + " | " + node.SelectSingleNode("Tlf").InnerText + " | " + node.SelectSingleNode("Email").InnerText + " |";
                    }
                    else if (LinkButton3.Text == "")
                    {
                        //Select the text from a single node, “Title” in this case
                        LinkButton3.Text = node.SelectSingleNode("Navn").InnerText;
                        Session["KundeNr3"] = node.SelectSingleNode("ID").InnerText;
                        Label3.Text = " | " + node.SelectSingleNode("Adresse").InnerText + " | " + node.SelectSingleNode("PostBy").InnerText + " | " + node.SelectSingleNode("Tlf").InnerText + " | " + node.SelectSingleNode("Email").InnerText + " |";
                    }
                    else if (LinkButton4.Text == "")
                    {
                        //Select the text from a single node, “Title” in this case
                        LinkButton4.Text = node.SelectSingleNode("Navn").InnerText;
                        Session["KundeNr4"] = node.SelectSingleNode("ID").InnerText;
                        Label4.Text = " | " + node.SelectSingleNode("Adresse").InnerText + " | " + node.SelectSingleNode("PostBy").InnerText + " | " + node.SelectSingleNode("Tlf").InnerText + " | " + node.SelectSingleNode("Email").InnerText + "|";
                    }
                    else if (LinkButton5.Text == "")
                    {
                        //Select the text from a single node, “Title” in this case
                        LinkButton5.Text = node.SelectSingleNode("Navn").InnerText;
                        Session["KundeNr5"] = node.SelectSingleNode("ID").InnerText;
                        Label5.Text = " | " + node.SelectSingleNode("Adresse").InnerText + " | " + node.SelectSingleNode("PostBy").InnerText + " | " + node.SelectSingleNode("Tlf").InnerText + " | " + node.SelectSingleNode("Email").InnerText + " |";
                    }
                    else if (LinkButton6.Text == "")
                    {
                        //Select the text from a single node, “Title” in this case
                        LinkButton6.Text = node.SelectSingleNode("Navn").InnerText;
                        Session["KundeNr6"] = node.SelectSingleNode("ID").InnerText;
                        Label6.Text = " | " + node.SelectSingleNode("Adresse").InnerText + " | " + node.SelectSingleNode("PostBy").InnerText + " | " + node.SelectSingleNode("Tlf").InnerText + " | " + node.SelectSingleNode("Email").InnerText + " |";
                    }
                    else if (LinkButton7.Text == "")
                    {
                        //Select the text from a single node, “Title” in this case
                        LinkButton7.Text = node.SelectSingleNode("Navn").InnerText;
                        Session["KundeNr7"] = node.SelectSingleNode("ID").InnerText;
                        Label7.Text = " | " + node.SelectSingleNode("Adresse").InnerText + " | " + node.SelectSingleNode("PostBy").InnerText + " | " + node.SelectSingleNode("Tlf").InnerText + " | " + node.SelectSingleNode("Email").InnerText + " |";
                    }
                    else if (LinkButton8.Text == "")
                    {
                        //Select the text from a single node, “Title” in this case
                        LinkButton8.Text = node.SelectSingleNode("Navn").InnerText;
                        Session["KundeNr8"] = node.SelectSingleNode("ID").InnerText;
                        Label8.Text = " | " + node.SelectSingleNode("Adresse").InnerText + " | " + node.SelectSingleNode("PostBy").InnerText + " | " + node.SelectSingleNode("Tlf").InnerText + " | " + node.SelectSingleNode("Email").InnerText + " |";
                    }
                    else if (LinkButton9.Text == "")
                    {
                        //Select the text from a single node, “Title” in this case
                        LinkButton9.Text = node.SelectSingleNode("Navn").InnerText;
                        Session["KundeNr9"] = node.SelectSingleNode("ID").InnerText;
                        Label9.Text = " | " + node.SelectSingleNode("Adresse").InnerText + " | " + node.SelectSingleNode("PostBy").InnerText + " | " + node.SelectSingleNode("Tlf").InnerText + " | " + node.SelectSingleNode("Email").InnerText + " |";
                    }
                    else if (LinkButton10.Text == "")
                    {
                        //Select the text from a single node, “Title” in this case
                        LinkButton10.Text = node.SelectSingleNode("Navn").InnerText;
                        Session["KundeNr10"] = node.SelectSingleNode("ID").InnerText;
                        Label10.Text = " | " + node.SelectSingleNode("Adresse").InnerText + " | " + node.SelectSingleNode("PostBy").InnerText + " | " + node.SelectSingleNode("Tlf").InnerText + " | " + node.SelectSingleNode("Email").InnerText + " |";
                    }
                }
                doc.Save(Database);
            }
        }
    }
}