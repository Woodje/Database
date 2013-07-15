<%@ Page Title="" Language="C#" MasterPageFile="~/Database/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>


<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">
    <center>
    <p>
            &nbsp;</p>
        <p>
            <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Database/Kalender.jpg" 
                onclick="ImageButton5_Click" />
    </p>
        <p>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Database/Kunder.jpg" 
            onclick="ImageButton1_Click1" />
    &nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Database/Search.jpg" 
            onclick="ImageButton2_Click" />
    </p>
        <p>
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Database/Add.jpg" 
            onclick="ImageButton3_Click" />
    &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Database/Fjern.jpg" 
                onclick="ImageButton4_Click" />
    </p>
        <p>
            &nbsp;</p>
    </center>
</asp:Content>




<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder3">
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="true" Font-Italic="true" Font-Size="X-Large" ForeColor="CornflowerBlue"></asp:Label>
    </p>
</asp:Content>





