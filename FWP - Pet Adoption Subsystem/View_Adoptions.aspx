<%@ Page Title="" Language="C#" MasterPageFile="~/StaffMast.Master" AutoEventWireup="true" CodeBehind="View_Adoptions.aspx.cs" Inherits="FWP___Pet_Adoption_Subsystem.View_Adoptions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style3
        {
            width: 539px;
        }
        .style4
        {
            width: 240px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p align="center" 
        style="font-family: Arial; font-size: medium; font-weight: bold; text-decoration: underline; color: #000000; background-color: #006699;">
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
</p>
    <div align="center">
        <table style="width:100%;">
            <tr>
                <td class="style4">
                    View Adoptions of:</td>
                <td class="style3">
                    <asp:Label ID="LblDepositTotal" runat="server"></asp:Label>
                </td>
                <td>
                    To terminate adoption Select button below</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:LinkButton ID="LnkBtnActive" runat="server" onclick="LnkBtnActive_Click">Active Adoptions</asp:LinkButton>
                </td>
                <td align="center" class="style3" rowspan="6">
        <asp:Table ID="TableAllAdoptions" runat="server" Width="171px" Height="187px">
        </asp:Table>
                </td>
                <td>
                    <asp:Button ID="BtnTerminatePage" runat="server" 
                        onclick="BtnTerminatePage_Click" Text="Terminate Adoption Page" />
                </td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:LinkButton ID="LnkBtnAll" runat="server" onclick="LnkBtnAll_Click">(All) Past &amp; Present Adoptions</asp:LinkButton>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <br />
</div>
    <p>
        &nbsp;</p>
</asp:Content>
