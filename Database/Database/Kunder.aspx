<%@ Page Title="" Language="C#" MasterPageFile="~/Database/MasterPage.master" AutoEventWireup="true" CodeFile="Kunder.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
    {
        }
        .style6
        {
            width: 6px;
        }
        .style7
    {
        width: 48px;
    }
    </style>
    </asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">
    <center>
        <br />
    </center>
<table align="center" 
        style="border: medium solid #0166FF; border-collapse: collapse;" 
        cellpadding="0" cellspacing="0" width="465" bgcolor="#E5E5E5">
    <tr>
        <td colspan="4">
    <asp:Image ID="Image2" runat="server" Height="43px" ImageUrl="~/Database/Kunde.jpg" />
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td class="style6">
            &nbsp;</td>
        <td class="style4">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Height="26px" 
    Text="KundeNr:" Width="90px"></asp:Label>
            <br />
<asp:Label ID="Label2" runat="server" Font-Bold="True" Height="26px" 
    Text="Navn:" Width="90px"></asp:Label>
            <br />
<asp:Label ID="Label3" runat="server" Font-Bold="True" Height="26px" 
    Text="Adresse:" Width="90px"></asp:Label>
            <br />
<asp:Label ID="Label4" runat="server" Font-Bold="True" Height="26px" 
    Text="Post &amp; By:" Width="90px"></asp:Label>
            <br />
<asp:Label ID="Label5" runat="server" Font-Bold="True" Height="26px" 
    Text="Telefon:" Width="90px"></asp:Label>
            <br />
<asp:Label ID="Label9" runat="server" Font-Bold="True" Height="26px" 
    Text="Email:" Width="90px"></asp:Label>
            <br />
<asp:Label ID="Label6" runat="server" Font-Bold="True" Height="26px" 
    Text="Emne:" Width="90px"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label8" runat="server" Font-Bold="True" Height="24px"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" 
                Width="200px" ReadOnly="True" Height="20px" BackColor="#F3F3F3"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Font-Bold="True" 
                Width="200px" ReadOnly="True" Height="20px" BackColor="#F3F3F3"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" Font-Bold="True" 
                Width="200px" ReadOnly="True" Height="20px" BackColor="#F3F3F3"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox4" runat="server" Font-Bold="True" 
                Width="200px" ReadOnly="True" Height="20px" BackColor="#F3F3F3"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox6" runat="server" Font-Bold="True" 
                Width="200px" ReadOnly="True" Height="20px" BackColor="#F3F3F3"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox5" runat="server" Font-Bold="True" 
                Width="200px" ReadOnly="True" Height="20px" BackColor="#F3F3F3"></asp:TextBox>
        </td>
        <td class="style7">
            <asp:ImageButton ID="ImageButton3" runat="server" Height="50px" 
                ImageUrl="~/Database/Hjem_rund_grey.jpg" onclick="ImageButton3_Click" 
                ToolTip="HJEM" />
            <asp:ImageButton ID="ImageButton4" runat="server" Height="50px" 
                ImageUrl="~/Database/Gem.jpg" onclick="ImageButton4_Click" Visible="False" 
                ToolTip="GEM" />
            <br />
            <br />
            <asp:ImageButton ID="ImageButton2" runat="server" Height="50px" 
                ImageUrl="~/Database/Rediger.jpg" onclick="ImageButton2_Click" 
                ToolTip="REDIGER" />
            <asp:ImageButton ID="ImageButton5" runat="server" Height="50px" 
                ImageUrl="~/Database/NO_grey.jpg" onclick="ImageButton5_Click" Visible="False" 
                ToolTip="FORTRYD" />
            <br />
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td class="style6">
            &nbsp;</td>
        <td class="style4">
            <br />
            <br />
            <br />
            <br />
<asp:Label ID="Label7" runat="server" Font-Bold="True" Height="23px" 
    Text="Noter:" Width="90px"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </td>
        <td colspan="2">
            <textarea id="TextArea1" runat="server" cols="20" name="S1" readonly="readonly" rows="1" 
                
                style="width: 300px; height: 250px; font-weight: bold; background-color: #F3F3F3;"></textarea></td>
    </tr>
</table>
<br />
</asp:Content>



