<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Staff_Log_In.aspx.cs" Inherits="FWP___Pet_Adoption_Subsystem.Staff_Log_In" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 202px;
        }
        .style2
        {
            width: 202px;
            height: 26px;
        }
        .style3
        {
            height: 26px;
            width: 143px;
        }
        .style4
        {
            width: 143px;
        }
        .style5
        {
            width: 56px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p align="center" 
        style="font-family: 'Arial Black'; font-size: 20px; font-weight: bold; color: #000000; text-decoration: underline;">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" 
        Text="Log In as Staff Member"></asp:Label>
</p>
    <div align="center" style="height: 127px">
        <table align="center" style="width: 100%; height: 115px;">
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td rowspan="3">
    <div align="center">
        <table style="background-color: #000000; color: #FFFFFF;" align="center">
            <tr>
                <td class="style2" align="right">
                    Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td align="left" class="style3">
                    <asp:TextBox ID="TBxUName" runat="server"></asp:TextBox>
                </td>
                <td align="left" class="style3" style="background-color: #FFFFFF">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TBxUName" ErrorMessage="Username Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style1" align="right">
                    Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td align="left" class="style4">
                    <asp:TextBox ID="TBxUPasswrd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td align="left" class="style4" style="background-color: #FFFFFF">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="TBxUPasswrd" ErrorMessage="Password Required" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
    </div>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>
    <p align="center">
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="BtnLogIn" />
</p>
    <p align="center">
        <asp:Label ID="lblMessageDisplay" runat="server"></asp:Label>
    </p>
    <p align="center">
        &nbsp;</p>
    <p align="center">
        &nbsp;</p>
    <p align="center">
        &nbsp;</p>
    <p align="center">
        &nbsp;</p>
    <p align="center">
        &nbsp;</p>
    <p align="center">
    <br />
</p>
</asp:Content>
