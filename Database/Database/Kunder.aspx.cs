using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Text;
using System.Web.Hosting;

public partial class Default2 : System.Web.UI.Page
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
        if (TextBox1.ReadOnly == true)
        {
            if (Session["Ny"] == "Ny")
            {
                TextBox1.ReadOnly = false;
                TextBox2.ReadOnly = false;
                TextBox3.ReadOnly = false;
                TextBox4.ReadOnly = false;
                TextBox5.ReadOnly = false;
                TextBox6.ReadOnly = false;
                TextArea1.Attributes.Remove("readonly");
                ImageButton3.Visible = false;
                ImageButton2.Visible = false;
                ImageButton4.Visible = true;
                ImageButton5.Visible = true;
                AntalKunder();
            }
            else
            {
                LoadKunde();
            }
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        TextBox1.ReadOnly = false;
        TextBox2.ReadOnly = false;
        TextBox3.ReadOnly = false;
        TextBox4.ReadOnly = false;
        TextBox5.ReadOnly = false;
        TextBox6.ReadOnly = false;
        TextArea1.Attributes.Remove("readonly");
        ImageButton3.Visible = false;
        ImageButton2.Visible = false;
        ImageButton4.Visible = true;
        ImageButton5.Visible = true;
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Database/Default.aspx");
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["Ny"] == "Ny")
        {
            Session["Ny"] = "";
            Response.Redirect("~/Database/Default.aspx");
        }
        else
        {
            Response.Redirect("~/Database/Kunder.aspx");
        }
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["Ny"] == "Ny")
        {
            OpretKunde();
            Session["Ny"] = "";
            TextBox1.ReadOnly = true;
            TextBox2.ReadOnly = true;
            TextBox3.ReadOnly = true;
            TextBox4.ReadOnly = true;
            TextBox5.ReadOnly = true;
            TextBox6.ReadOnly = true;
            TextArea1.Attributes["readonly"] = ("readonly");
            ImageButton3.Visible = true;
            ImageButton2.Visible = true;
            ImageButton4.Visible = false;
            ImageButton5.Visible = false;
        }
        else
        {
            GemInfo();
            TextBox1.ReadOnly = true;
            TextBox2.ReadOnly = true;
            TextBox3.ReadOnly = true;
            TextBox4.ReadOnly = true;
            TextBox5.ReadOnly = true;
            TextBox6.ReadOnly = true;
            TextArea1.Attributes["readonly"] = ("readonly");
            ImageButton3.Visible = true;
            ImageButton2.Visible = true;
            ImageButton4.Visible = false;
            ImageButton5.Visible = false;
        }
    }
    protected void AntalKunder()
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
            Label8.Text = node.SelectSingleNode("ID").InnerText;
            Session["Antal"] = node.SelectSingleNode("ID").InnerText;
        }
        Label8.Text = Convert.ToString(Convert.ToInt16(Label8.Text) + 1) + " - Ny kundeoprettelse"; 
    }
    protected void LoadKunde()
    {
        string nr;
        if (Label8.Text != "")
        {
            nr = Label8.Text;
        }
        else
        {
            nr = Session["KundeNr"].ToString();
        }
        XmlDocument doc = new XmlDocument();
        //Load XML from the file into XmlDocument object
        doc.Load(Database);
        
        XmlNode root = doc.DocumentElement;
        StringBuilder sb = new StringBuilder();
        StringBuilder navn = new StringBuilder();
        //Select all nodes with the tag Book
        XmlNodeList nodeList = root.SelectNodes("Kunde");
        //Loop through each node under the node “Book”
        foreach (XmlNode node in nodeList)
        {
            if (node.SelectSingleNode("ID").InnerText == nr)
            {
                //Select the text from a single node, “Title” in this case
                Label8.Text = node.SelectSingleNode("ID").InnerText;

                navn.Append(node.SelectSingleNode("Navn").InnerText);
                if (Convert.ToInt16(nr) < 10)
                {
                    navn.Remove(0, 7);
                }
                else
                {
                    navn.Remove(0, 8);
                }
                TextBox1.Text = Convert.ToString(navn);

                TextBox2.Text = node.SelectSingleNode("Adresse").InnerText;

                TextBox3.Text = node.SelectSingleNode("PostBy").InnerText;

                TextBox4.Text = node.SelectSingleNode("Tlf").InnerText;
                TextBox5.Text = node.SelectSingleNode("Computer").InnerText;
                TextBox6.Text = node.SelectSingleNode("Email").InnerText;
                TextArea1.InnerText = node.SelectSingleNode("Tekst").InnerText;
            }
        }     
    }
    protected void GemInfo()
    {
        XmlDocument xmldoc = new XmlDocument();
        xmldoc.Load(Database);
        XmlNodeList nodeList = xmldoc.DocumentElement.SelectNodes("Kunde");
        foreach (XmlNode node in nodeList)
        {
            if (node.SelectSingleNode("ID").InnerText == Label8.Text)
            {
                node["Navn"].InnerText = "Nr " + Label8.Text + " - " + TextBox1.Text;
                node["Adresse"].InnerText = TextBox2.Text;
                node["PostBy"].InnerText = TextBox3.Text;
                node["Tlf"].InnerText = TextBox4.Text;
                node["Computer"].InnerText = TextBox5.Text;
                node["Email"].InnerText = TextBox6.Text;
                node["Tekst"].InnerText = TextArea1.InnerText;
            }
        }
        xmldoc.Save(Database);
    }
    protected void OpretKunde()
    {
        //file name
        int n = Convert.ToInt16(Session["Antal"]) + 1;
        //create new instance of XmlDocument
        XmlDocument doc = new XmlDocument();

        //load from file
        doc.Load(Database);

        //create node and add value
        XmlNode node = doc.CreateNode(XmlNodeType.Element, "Kunde", null);
        //node.InnerText = "this is new node";

        //create title node
        XmlNode nodeTitle = doc.CreateElement("ID");
        //add value for it
        nodeTitle.InnerText = Convert.ToString(n);

        //create Url node
        XmlNode nodeUrl = doc.CreateElement("Navn");
        nodeUrl.InnerText = "Nr " + n + " - " + TextBox1.Text;
        XmlNode nodeAdr = doc.CreateElement("Adresse");
        nodeAdr.InnerText = TextBox2.Text;
        XmlNode nodePostBy = doc.CreateElement("PostBy");
        nodePostBy.InnerText = TextBox3.Text;
        XmlNode nodeTLF = doc.CreateElement("Tlf");
        nodeTLF.InnerText = TextBox4.Text;
        XmlNode nodeComputer = doc.CreateElement("Computer");
        nodeComputer.InnerText = TextBox5.Text;
        XmlNode nodeEmail = doc.CreateElement("Email");
        nodeEmail.InnerText = TextBox6.Text;
        XmlNode nodeTekst = doc.CreateElement("Tekst");
        nodeTekst.InnerText = TextArea1.InnerText;
        //add to parent node
        node.AppendChild(nodeTitle);
        node.AppendChild(nodeUrl);
        node.AppendChild(nodeAdr);
        node.AppendChild(nodePostBy);
        node.AppendChild(nodeTLF);
        node.AppendChild(nodeComputer);
        node.AppendChild(nodeEmail);
        node.AppendChild(nodeTekst);

        //add to elements collection
        doc.DocumentElement.AppendChild(node);

        //save back
        doc.Save(Database);
        Label8.Text = Convert.ToString(n);
    }
}