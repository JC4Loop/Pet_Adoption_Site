<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Adoption_Deposit.aspx.cs" Inherits="FWP___Pet_Adoption_Subsystem.Adoption_Deposit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            width: 208px;
        }
        .style3
        {
            width: 172px;
        }
        .style7
        {
        }
        .style5
        {
        }
        .style9
        {
            width: 213px;
        }
        .style10
        {
            width: 282px;
        }
        .style11
        {
            width: 490px;
        }
        .style12
        {
            width: 282px;
            height: 23px;
        }
        .style13
        {
            width: 490px;
            height: 23px;
        }
        .style14
        {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="285px" style="margin-top: 0px">
        <table style="width:100%;">
            <tr>
                <td align="left" class="style10" style="color: #000066">
                    <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" 
                        Height="50px" ImageUrl="~/Images/agt_back.png" onclick="ImageButton1_Click" 
                        Width="80px" />
                    <asp:Label ID="Label2" runat="server" Font-Size="Small" Font-Underline="False" 
                        Text="Back"></asp:Label>
                </td>
                <td align="center" class="style11" 
                    style="color: #000066; font-family: Arial; font-size: large; font-weight: bold; text-decoration: underline;">
                    Confirm Adoption &amp; Deposit</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="left" class="style12" style="color: #000066">
                </td>
                <td align="center" class="style13" 
                    style="color: #000066; font-family: Arial; font-size: medium; font-weight: bold;">
                    Review Customer/Pet details &amp; confirm</td>
                <td class="style14">
                </td>
            </tr>
        </table>
        <br />
        <table align="center" style="width: 61%; height: 166px;">
            <tr>
                <td align="center" class="style1" colspan="3" 
                    style="font-family: Arial; font-size: medium; font-weight: bold; text-transform: uppercase; color: #000000; text-decoration: underline;">
                    Pet</td>
            </tr>
            <tr>
                <td align="center" class="style3" 
                    style="font-family: Arial; font-size: medium; font-weight: bold; text-transform: uppercase; color: #000000">
                    Name</td>
                <td align="center" class="style2" 
                    style="font-family: Arial; font-size: medium; font-weight: bold; text-transform: uppercase; color: #000000">
                    Gender</td>
                <td align="center" 
                    style="font-family: Arial; font-size: medium; font-weight: bold; text-transform: uppercase; color: #000000">
                    specie</td>
            </tr>
            <tr>
                <td align="center" class="style3">
                    <asp:Label ID="LabelName" runat="server"></asp:Label>
                </td>
                <td align="center" class="style2">
                    <asp:Label ID="LabelGender" runat="server"></asp:Label>
                </td>
                <td align="center">
                    <asp:Label ID="LabelSpecie" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" class="style3" 
                    style="font-family: Arial; font-size: medium; font-weight: bold; text-transform: uppercase; color: #000000">
                    Breed</td>
                <td align="center" class="style2" 
                    style="font-family: Arial; font-size: medium; font-weight: bold; text-transform: uppercase; color: #000000">
                    Age at Rescue</td>
                <td align="center" 
                    style="font-family: Arial; font-size: medium; font-weight: bold; text-transform: uppercase; color: #000000">
                    Rescue Date</td>
            </tr>
            <tr>
                <td align="center" class="style3">
                    <asp:Label ID="LabelBreed" runat="server"></asp:Label>
                </td>
                <td align="center" class="style2">
                    <asp:Label ID="LabelRescueA" runat="server"></asp:Label>
                </td>
                <td align="center">
                    <asp:Label ID="LabelRescueD" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" Height="165px">
        <br />
        <table align="center" style="width: 75%;">
            <tr>
                <td align="center" class="style5" colspan="3" 
                    style="font-family: Arial; font-size: 15px; font-weight: bolder; color: #003366; text-decoration: underline;">
                    Customer</td>
            </tr>
            <tr>
                <td align="center" class="style9" 
                    style="font-family: Arial; font-size: 15px; font-weight: bolder; color: #003366">
                    Name</td>
                <td align="center" class="style9" 
                    style="font-family: Arial; font-size: 15px; font-weight: bolder; color: #003366">
                    Email</td>
                <td align="center" class="style4" 
                    style="font-family: Arial; font-size: 15px; font-weight: bolder; color: #003366">
                    Telephone Number</td>
            </tr>
            <tr>
                <td align="center" class="style9" 
                    style="font-style: normal; font-weight: normal; color: #000000">
                    <asp:Label ID="LabelCName" runat="server"></asp:Label>
                </td>
                <td align="center" class="style9" 
                    style="font-style: normal; font-weight: normal; color: #000000">
                    <asp:Label ID="LabelCEmail" runat="server"></asp:Label>
                </td>
                <td align="center" 
                    style="font-style: normal; font-weight: normal; color: #000000">
                    <asp:Label ID="LabelCTelNum" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" class="style9" 
                    style="font-family: Arial; font-size: 15px; font-weight: bolder; color: #003366;">
                    Street &amp; Town</td>
                <td align="center" class="style9" 
                    style="font-family: Arial; font-size: 15px; font-weight: bolder; color: #003366;">
                    County</td>
                <td align="center" class="style3" 
                    style="font-family: Arial; font-size: 15px; font-weight: bolder; color: #003366;">
                    Country of Residence</td>
            </tr>
            <tr>
                <td align="center" class="style9" 
                    style="font-weight: normal; font-style: normal; font-variant: normal; color: #000000">
                    <asp:Label ID="LabelCAdd1" runat="server"></asp:Label>
                </td>
                <td align="center" class="style9" 
                    style="font-weight: normal; font-style: normal; font-variant: normal; color: #000000">
                    <asp:Label ID="LabelCAdd2" runat="server"></asp:Label>
                </td>
                <td align="center" 
                    style="font-weight: normal; font-style: normal; font-variant: normal; color: #000000">
                    <asp:Label ID="LabelCCoR" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" Height="237px" style="margin-top: 0px">
        <br />
        <table align="center" style="width: 55%; margin-left: 0px;">
            <tr>
                <td align="center" class="style7" colspan="2" 
                    style="font-family: Arial; font-size: small; font-weight: bolder; color: #003366">
                    Adoption Payment</td>
            </tr>
            <tr>
                <td align="center" class="style7" colspan="2" 
                    style="font-family: Arial; font-size: small; font-weight: bolder; color: #003366">
                    <asp:Label ID="LblErMsg" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style7" 
                    style="font-family: Arial; font-size: small; font-weight: bolder; color: #003366">
                    Minumum Deposit for Pet:
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    &nbsp;(£ equivalent)</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7" align="center" bgcolor="#000066">
                    <asp:Label ID="LbldisplayMinD" runat="server" Text="Label" Font-Size="12pt" 
                        ForeColor="White"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7" 
                    style="font-family: Arial; font-size: small; font-weight: bolder; color: #003366">
                    Choose Currency</td>
                <td style="font-family: Arial; font-size: small; font-weight: bolder; color: #003366">
                    Deposit Amount</td>
            </tr>
            <tr>
                <td class="style7">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="GDP">(GBP) £</asp:ListItem>
                        <asp:ListItem Value="EUR">(EUR) €</asp:ListItem>
                        <asp:ListItem Value="RON">(RON)</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:TextBox ID="TBxDeposit" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TBxDeposit" ErrorMessage="Amount Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    <asp:Button ID="BtnSubmit" runat="server" onclick="BtnSubmit_Click" 
                        Text="Check Deposit" />
                </td>
                <td>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ControlToValidate="TBxDeposit" ErrorMessage="Deposit must be numeric" 
                        ForeColor="Red" MaximumValue="999999" MinimumValue="0" Type="Double"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="style7" align="center" bgcolor="#000066">
                    <asp:Label ID="LblDepAmount" runat="server" Text="Select Check Deposit" 
                        Font-Size="15pt" ForeColor="White"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="BtnConfirmOrd" runat="server" Enabled="False" 
                        onclick="BtnConfirmOrd_Click" Text="Deposit must be selected" 
                        Width="228px" CausesValidation="False" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <p>
    </p>
    <p align="center" 
        
        style="font-family: Arial; font-size: small; font-weight: bolder; color: #003366; height: 148px;">
        &nbsp;</p>
</asp:Content>
