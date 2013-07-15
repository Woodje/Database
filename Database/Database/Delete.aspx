<%@ Page Title="" Language="C#" MasterPageFile="~/Database/MasterPage.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

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
    <table style="border: thin solid #000000; text-align:center; background-color: #E5E5E5;">
        <tr>
            <td class="style3">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/Database/Fjern.jpg" Width="300px" />
                <br />
                <br />
                <br />
                <asp:DropDownList ID="Kunder" runat="server" style="font-weight: 700" 
        Width="280px">
                </asp:DropDownList>
                <br />
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" 
                    ForeColor="Red" Text="SIKKER?" Visible="False"></asp:Label>
                <br />
                <br />
                <asp:ImageButton ID="ImageButton2" runat="server" Height="50px" 
                        ImageUrl="~/Database/Hjem_rund_grey.jpg" onclick="ImageButton2_Click" 
                    ToolTip="HJEM" />
&nbsp;<asp:ImageButton ID="ImageButton3" runat="server" Height="50px" ImageUrl="~/Database/OK_green.jpg" 
                    onclick="ImageButton3_Click" Visible="False" ToolTip="JA" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" 
                        ImageUrl="~/Database/Fjern-knap.jpg" onclick="ImageButton1_Click" 
                    ToolTip="FJERN" />
                <asp:ImageButton ID="ImageButton4" runat="server" Height="50px" 
                    ImageUrl="~/Database/NO_grey.jpg" onclick="ImageButton4_Click" 
                    Visible="False" ToolTip="NEJ" />
                <br />
            </td>
        </tr>
    </table>
    </center>
</asp:Content>


