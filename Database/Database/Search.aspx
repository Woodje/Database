<%@ Page Title="" Language="C#" MasterPageFile="~/Database/MasterPage.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">

    function clickButton(e, buttonid) {

        var evt = e ? e : window.event;

        var bt = document.getElementById(buttonid);

        if (bt) {

            if (evt.keyCode == 13) {

                bt.click();

                return false;
            }

        }

    }
    </script>
    <style type="text/css">

    .style3
    {
        width: 300px;
    }
        .style5
        {
        }
        .style6
        {
            font-size: small;
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
                <asp:Image ID="Image2" runat="server" ImageUrl="~/Database/Search.jpg" Width="300px" />
                <br />
                <br />
                <center>
                <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
                
                
                <table>
                    <tr>
                        <td class="style5" align="left">
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="122px" 
                                CellPadding="0" CellSpacing="0">
                                <asp:ListItem Value="1">Navn</asp:ListItem>
                                <asp:ListItem Value="2">Adresse</asp:ListItem>
                                <asp:ListItem Value="3">Post&amp;By</asp:ListItem>
                                <asp:ListItem Value="4">Telefon</asp:ListItem>
                                <asp:ListItem Value="5">Emne</asp:ListItem>
                                <asp:ListItem Value="6">Email</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    </table>
                
                <asp:ImageButton ID="ImageButton2" runat="server" Height="50px" 
                        ImageUrl="~/Database/Hjem_rund_grey.jpg" onclick="ImageButton2_Click" 
                        ToolTip="HJEM" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" 
                        ImageUrl="~/Database/OK_green.jpg" onclick="ImageButton1_Click" 
                        ToolTip="SØG" />
                <br />
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td align="left">
                <br />
                <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
                    CssClass="style6"></asp:LinkButton>
                <asp:Label ID="Label1" runat="server" CssClass="style6"></asp:Label>
                <br class="style6" />
                <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click" 
                    CssClass="style6"></asp:LinkButton>
                <asp:Label ID="Label2" runat="server" CssClass="style6"></asp:Label>
                <br class="style6" />
                <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click" 
                    CssClass="style6"></asp:LinkButton>
                <asp:Label ID="Label3" runat="server" CssClass="style6"></asp:Label>
                <br class="style6" />
                <asp:LinkButton ID="LinkButton4" runat="server" onclick="LinkButton4_Click" 
                    CssClass="style6"></asp:LinkButton>
                <asp:Label ID="Label4" runat="server" CssClass="style6"></asp:Label>
                <br class="style6" />
                <asp:LinkButton ID="LinkButton5" runat="server" onclick="LinkButton5_Click" 
                    CssClass="style6"></asp:LinkButton>
                <asp:Label ID="Label5" runat="server" CssClass="style6"></asp:Label>
                <br class="style6" />
                <asp:LinkButton ID="LinkButton6" runat="server" onclick="LinkButton6_Click" 
                    CssClass="style6"></asp:LinkButton>
                <asp:Label ID="Label6" runat="server" CssClass="style6"></asp:Label>
                <br class="style6" />
                <asp:LinkButton ID="LinkButton7" runat="server" onclick="LinkButton7_Click" 
                    CssClass="style6"></asp:LinkButton>
                <asp:Label ID="Label7" runat="server" CssClass="style6"></asp:Label>
                <br class="style6" />
                <asp:LinkButton ID="LinkButton8" runat="server" onclick="LinkButton8_Click" 
                    CssClass="style6"></asp:LinkButton>
                <asp:Label ID="Label8" runat="server" CssClass="style6"></asp:Label>
                <br class="style6" />
                <asp:LinkButton ID="LinkButton9" runat="server" onclick="LinkButton9_Click" 
                    CssClass="style6"></asp:LinkButton>
                <asp:Label ID="Label9" runat="server" CssClass="style6"></asp:Label>
                <br class="style6" />
                <asp:LinkButton ID="LinkButton10" runat="server" onclick="LinkButton10_Click" 
                    CssClass="style6"></asp:LinkButton>
                <asp:Label ID="Label10" runat="server" CssClass="style6"></asp:Label>
            </td>
        </tr>
    </table></center>
</asp:Content>


<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder3">
    <p>
        <asp:Label ID="Label11" runat="server" Font-Bold="true" Font-Italic="true" Font-Size="X-Large" ForeColor="CornflowerBlue"></asp:Label>
    </p>
</asp:Content>



