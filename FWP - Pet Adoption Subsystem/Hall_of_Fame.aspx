<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Hall_of_Fame.aspx.cs" Inherits="FWP___Pet_Adoption_Subsystem.Hall_of_Fame" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style3
        {
            width: 369px;
        }
        .style4
        {
            width: 316px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server" BackColor="Black" Font-Bold="True" 
        Font-Names="Arial" Font-Overline="False" Font-Size="Large" 
        Font-Underline="True" ForeColor="White" Height="50px" HorizontalAlign="Center">
        Hall Of fame<br />
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" Font-Underline="False" 
            Text="Most Generous Deposits Below"></asp:Label>
        <br />
        <br />
        <br />
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" BackColor="#FFCC00" Height="344px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <div align="center" style="height: 60px">
            <table style="width:100%;">
                <tr>
                    <td align="left" class="style4" rowspan="3">
                        <asp:Image ID="Image1" runat="server" Height="152px" 
                            ImageUrl="~/Images/gold-star.png" Width="159px" />
                    </td>
                    <td align="center" class="style3">
                        <asp:Table ID="Table1" runat="server">
                        </asp:Table>
                    </td>
                    <td align="right" rowspan="3">
                        <asp:Image ID="Image2" runat="server" Height="152px" 
                            ImageUrl="~/Images/gold-star.png" Width="159px" />
                    </td>
                </tr>
                <tr>
                    <td align="center" class="style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="center" class="style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style4" rowspan="3">
                        &nbsp;</td>
                    <td align="center" class="style3">
                        &nbsp;</td>
                    <td rowspan="3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="center" class="style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="center" class="style3">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </asp:Panel>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
