using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Web;
using System.Web.UI.WebControls;
using System.Collections;
using Google.GData.AccessControl;
using Google.GData.Calendar;
using Google.GData.Client;
using Google.GData.Extensions;

public partial class Kalender : System.Web.UI.Page
{
    private ArrayList entryList;

    public Kalender()
    {
        this.entryList = new ArrayList();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["Login"] == "Test")
            {
                Label2.Text = "_Test_";
            }
            if (Session["Login"] == "Test2")
            {
                Label2.Text = "_Test2_";
            }
        }
        catch
        {
        }
        finally
        {
        }
        if (Label2.Text == "_Test_" || Label2.Text == "_Test2_")
        {
            if (Label2.Text == "_Test_")
            {
                Session["Login"] = "Test";
            }
            if (Label2.Text == "_Test2_")
            {
                Session["Login"] = "Test2";
            }
        }
        else
        {
            Response.Redirect("~/Database/Login.aspx");
        }
        RefreshFeed();
        Calendar1.SelectedDates.Clear();
        Label1.Text = "";
        table1.Visible = false;
    }
    private void RefreshFeed()
    {
        string calendarURI = "https://www.google.com/calendar/feeds/default/private/full";
        string userName = "Test";
        string passWord = "Test";

        this.entryList = new ArrayList();
        EventQuery query = new EventQuery();
        CalendarService service = new CalendarService("CalendarSampleApp");


        service.setUserCredentials(userName, passWord);

        
        // only get event's for today - 48 months until today + ½ year

        query.Uri = new Uri(calendarURI);

        query.StartTime = DateTime.Now.AddMonths(-48);
        query.EndTime = DateTime.Now.AddMonths(6);

        EventFeed calFeed = service.Query(query) as EventFeed;

        // now populate the calendar
        while (calFeed != null && calFeed.Entries.Count > 0)
        {
            // look for the one with dinner time...
            foreach (EventEntry entry in calFeed.Entries)
            {
                this.entryList.Add(entry);
            }
            // just query the same query again.
            if (calFeed.NextChunk != null)
            {
                query.Uri = new Uri(calFeed.NextChunk);
                calFeed = service.Query(query) as EventFeed;
            }
            else
                calFeed = null;
        }
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = "";
        table1.Visible = false;
        foreach (EventEntry entry in this.entryList)
        {
            // let's find the entries for that date

            if (entry.Times.Count > 0)
            {
                foreach (When w in entry.Times)
                {
                    if (Calendar1.SelectedDate.Date == w.StartTime.Date || Calendar1.SelectedDate.Date == w.EndTime.Date)
                    {
                        table1.Border = 1;
                        table1.BorderColor = "#0166FF";
                        table1.Visible = true;
                        Label1.Text = Label1.Text + entry.Title.Text + "  (";
                        Label1.Text = Label1.Text + entry.Times[0].StartTime.ToShortTimeString().ToString();
                        Label1.Text = Label1.Text + "-" + entry.Times[0].EndTime.ToShortTimeString().ToString() + ")";
                        Label1.Text = Label1.Text + " - " + entry.Content.Content.ToString() + "<br>";
                        break;
                    }
                }
            }
        }
    }
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        foreach (EventEntry entry in this.entryList)
        {
            // let's find the entries for that date

            if (entry.Times.Count > 0)
            {
                foreach (When w in entry.Times)
                {
                    if (e.Day.Date == w.StartTime.Date || e.Day.Date == w.EndTime.Date)
                    {
                        e.Cell.ToolTip = e.Cell.ToolTip + entry.Title.Text + "  (";
                        e.Cell.ToolTip = e.Cell.ToolTip + entry.Times[0].StartTime.ToShortTimeString().ToString();
                        e.Cell.ToolTip = e.Cell.ToolTip + "-" + entry.Times[0].EndTime.ToShortTimeString().ToString() + ")";
                        e.Cell.ToolTip = e.Cell.ToolTip + " - " + entry.Content.Content.ToString() + "\n";
                        e.Cell.BackColor = Color.CornflowerBlue;
                        break;
                    }
                }
            }
        }
    }
    protected void ImageButton3_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        Response.Redirect("~/Database/Default.aspx");
    }
}