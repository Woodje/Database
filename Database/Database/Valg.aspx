<%@ Page Title="" Language="C#" MasterPageFile="~/Database/MasterPage.master" AutoEventWireup="true" CodeFile="Valg.aspx.cs" Inherits="Valg" %>

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
    <center>
        <br />
        <table style="border: thin solid #000000; background-color: #E5E5E5;">
            <tr>
                <td class="style3">
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/Database/Kunder.jpg" Width="300px" />
                    <center>
                    <br />
                    <br />
    <asp:DropDownList ID="Kunder" runat="server" style="font-weight: 700" 
        Width="280px">
    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="50px" 
                        ImageUrl="~/Database/Hjem_rund_grey.jpg" onclick="ImageButton2_Click" 
                            ToolTip="HJEM" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" 
                        ImageUrl="~/Database/OK_green.jpg" onclick="ImageButton1_Click" 
                            ToolTip="HENT INFO" />
                    <br />
                    </center>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
    </center>
</asp:Content>

