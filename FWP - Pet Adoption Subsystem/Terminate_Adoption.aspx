<%@ Page Title="" Language="C#" MasterPageFile="~/StaffMast.Master" AutoEventWireup="true" CodeBehind="Terminate_Adoption.aspx.cs" Inherits="FWP___Pet_Adoption_Subsystem.Terminate_Adoption" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style3
        {
            width: 345px;
        }
        .style4
        {
        }
        .style5
        {
            width: 480px;
        }
        .style6
        {
            width: 269px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="style6">
                <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" 
                    ImageUrl="~/Images/agt_back.png" onclick="ImageButton1_Click" Width="80px" />
                Back to View Adoptions</td>
            <td align="center" class="style5" 
                style="font-family: Arial; font-weight: bold; color: #000000; text-decoration: underline; font-size: large;">
        Terminate Adoption</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <p align="center">
        Select which Adoption you wish to be terminated</p>
    <div align="center">
        <asp:Table ID="TableActiveAdoptions" runat="server">
        </asp:Table>
        <br />
    </div>
    <asp:Panel ID="Panel1" runat="server" BackColor="Black" Height="208px">
        <br />
        <table align="center" style="width: 100%; color: #FFFFFF;">
            <tr>
                <td align="center" class="style4">
                    &nbsp;</td>
                <td align="center" class="style3">
                    <asp:Label ID="LblWhichAdoption" runat="server"></asp:Label>
                    &nbsp;</td>
                <td align="center">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="center" class="style4">
                    <asp:Label ID="LblCustomer" runat="server"></asp:Label>
                </td>
                <td align="center" class="style3">
                    <asp:Label ID="LblPet" runat="server"></asp:Label>
                </td>
                <td align="center">
                    <asp:Label ID="LblDeposit" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" class="style4">
                    <asp:Label ID="LblAdDate" runat="server"></asp:Label>
                </td>
                <td align="center" class="style3">
                    <asp:Label ID="LblPetSpecie" runat="server"></asp:Label>
                </td>
                <td align="center">
                    <asp:Label ID="LblPSanc" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" class="style4">
                    &nbsp;</td>
                <td align="center" class="style3">
                    &nbsp;</td>
                <td align="center">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="center" class="style4" colspan="3">
                    <asp:Label ID="LblConMsg" runat="server"></asp:Label>
                    &nbsp;<asp:Button ID="BtnCnfmTerm" runat="server" BackColor="Red" ForeColor="White" 
                        Text="Confirm Termination" Visible="False" onclick="BtnCnfmTerm_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <p>
    </p>
    <p align="center" 
        style="font-family: Arial; font-size: large; font-weight: bold; text-decoration: underline; color: #000000">
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
