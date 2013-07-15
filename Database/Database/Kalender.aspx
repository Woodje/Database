<%@ Page Title="" Language="C#" MasterPageFile="~/Database/MasterPage.master" AutoEventWireup="true" CodeFile="Kalender.aspx.cs" Inherits="Kalender" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">
    <center>
    <asp:Calendar ID="Calendar1" runat="server" BorderColor="#4681C3" 
            BorderStyle="Solid" BorderWidth="1px" Height="389px" 
            ondayrender="Calendar1_DayRender" 
            onselectionchanged="Calendar1_SelectionChanged" Width="495px">
        <DayHeaderStyle BackColor="#8BBBD9" Height="25px" />
        <DayStyle BorderStyle="Ridge" BackColor="#F6F6F6" />
        <TitleStyle BackColor="#417EBF" Font-Bold="True" Font-Size="XX-Large" 
            ForeColor="Black" Height="45px" />
        </asp:Calendar>
        <br />
        <table style="text-align:left;" runat="server" id="table1">
            <tr>
                <td>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" 
                        BackColor="#F6F6F6"></asp:Label>
                    </td>
            </tr>
        </table>
                    <br />
            <asp:ImageButton ID="ImageButton3" runat="server" Height="50px" 
                ImageUrl="~/Database/Hjem_rund.jpg" onclick="ImageButton3_Click" 
                ToolTip="HJEM" />
    </center>
</asp:Content>


<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder3">
    <center>
    <p>
        <asp:Label ID="Label2" runat="server" Font-Bold="true" Font-Italic="true" Font-Size="X-Large" ForeColor="CornflowerBlue"></asp:Label>
    </p>
    </center>
</asp:Content>



