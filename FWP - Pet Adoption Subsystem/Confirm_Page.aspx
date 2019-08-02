<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Confirm_Page.aspx.cs" Inherits="FWP___Pet_Adoption_Subsystem.Confirm_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 520px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p align="center" 
        style="font-family: 'Arial Black'; font-size: x-large; text-transform: uppercase; color: #000000">
        Confirmation Page<br />
    </p>
    <asp:Panel ID="Panel1" runat="server" Height="135px">
        <br />
        <table style="width:100%;">
            <tr>
                <td>
                    &nbsp;</td>
                <td align="center" class="style1">
                    <asp:Label ID="LblConfirm" runat="server" Font-Size="Medium" 
                        ForeColor="#003366"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
    <p>
    </p>
</asp:Content>
