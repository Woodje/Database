<%@ Page Title="" Language="C#" MasterPageFile="~/Database/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


    .style3
    {
        width: 300px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">
    <br />
    <center>
    <table style="border: thin solid #000000; background-color: #E5E5E5;">
        <tr>
            <td class="style3">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/Database/Login.jpg" Width="300px" />
                <br />
                <center>
                <table>
                    <tr>
                        <td align="left">
                            <br />
                            <asp:Label ID="Label1" runat="server" Text="Login ID :" Width="90px" 
                                Font-Bold="True" Font-Size="Large"></asp:Label>
                            <asp:TextBox ID="TextBox1" runat="server" Height="14px" Width="150px"></asp:TextBox>
                            <br />
                            <asp:Label ID="Label2" runat="server" Text="Kodeord :" Width="90px" 
                                Font-Bold="True" Font-Size="Large"></asp:Label>
                            <asp:TextBox ID="TextBox2" runat="server" Height="14px" Width="150px" 
                                TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                </center>
                <center>
                <br />&nbsp;<asp:ImageButton ID="ImageButton3" runat="server" Height="50px" 
                    ImageUrl="~/Database/Login_knap.jpg" onclick="ImageButton3_Click" 
                        ToolTip="LOGIN" />
                <br />
            </center>
            </td>
        </tr>
    </table>
    </center>
</asp:Content>


