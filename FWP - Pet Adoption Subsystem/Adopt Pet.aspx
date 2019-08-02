<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Adopt Pet.aspx.cs" Inherits="FWP___Pet_Adoption_Subsystem.Adopt_Pet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 272px;
        }
        .style2
        {
            width: 194px;
        }
        .style3
        {
        }
        .style4
        {
            width: 249px;
        }
        .style5
        {
            width: 341px;
        }
        .style7
        {
            width: 341px;
            height: 25px;
        }
        .style8
        {
            width: 249px;
            height: 25px;
        }
        .style9
        {
            height: 25px;
        }
        .style10
        {
            width: 289px;
        }
        .style11
        {
            width: 467px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel3" runat="server" Height="90px">
        <table style="width:100%;">
            <tr>
                <td align="left" class="style10">
                    <asp:ImageButton ID="ImageButton1" runat="server" 
                        ImageUrl="~/Images/agt_back.png" onclick="ImageButton1_Click" 
                        CausesValidation="False" />
                    <asp:Label ID="Label1" runat="server" 
                Font-Size="Small" Text="Back to View Pets"></asp:Label>
                </td>
                <td class="style11" align="center" 
                    style="font-family: Arial; font-size: large; font-weight: bold; text-decoration: underline; color: #003366">
                    Adopt Pet</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel1" runat="server" Height="167px">
        <br />
        <table ID="sldPetTable" align="center" style="width: 73%; margin-left: 87px;">
            <tr>
                <td class="style1" 
                    style="font-family: Arial; font-size: medium; font-weight: bold; text-transform: uppercase; color: #000000">
                    Name</td>
                <td class="style2" 
                    style="font-family: Arial; font-size: medium; font-weight: bold; text-transform: uppercase; color: #000000">
                    Gender</td>
                <td style="font-family: Arial; font-size: medium; font-weight: bold; text-transform: uppercase; color: #000000">
                    specie</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="LblPetNameA" runat="server"></asp:Label>
                </td>
                <td class="style2">
                    <asp:Label ID="LblPetGender" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LblPetSpecie" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style1" 
                    style="font-family: Arial; font-size: medium; font-weight: bold; text-transform: uppercase; color: #000000">
                    Breed</td>
                <td class="style2" 
                    style="font-family: Arial; font-size: medium; font-weight: bold; text-transform: uppercase; color: #000000">
                    Age at Rescue</td>
                <td style="font-family: Arial; font-size: medium; font-weight: bold; text-transform: uppercase; color: #000000">
                    Rescue Date</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="LblPetBreed" runat="server"></asp:Label>
                </td>
                <td class="style2">
                    <asp:Label ID="LblPetRAge" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LblPetRescueD" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style1" 
                    style="font-family: Arial; font-size: medium; font-weight: bold; color: #000000">
                    Sanctuary</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="LblPetSanc" runat="server"></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
    <p align="center" 
        style="font-family: Arial; font-size: medium; font-weight: bolder; color: #003366">
        Enter your details to adopt
        <asp:Label ID="LblPetNameB" runat="server" Text="Label"></asp:Label>
    </p>
    <asp:Panel ID="Panel2" runat="server" Height="286px">
        <br />
        <table align="center" style="width: 90%; margin-left: 41px;">
            <tr>
                <td class="style5" 
                    style="font-family: Arial; font-size: 15px; font-weight: bolder; color: #003366">
                    Name</td>
                <td class="style4" colspan="2" 
                    style="font-family: Arial; font-size: 15px; font-weight: bolder; color: #003366">
                    Email</td>
                <td style="font-family: Arial; font-size: 15px; font-weight: bolder; color: #003366">
                    Confirm Email</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:TextBox ID="TBxAName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TBxAName" ErrorMessage="Name required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="style4" colspan="2">
                    <asp:TextBox ID="TBxAEmail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="TBxAEmail" ErrorMessage="Email Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="TBxAEmailC" runat="server" style="margin-left: 0px"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="TBxAEmail" ControlToValidate="TBxAEmailC" 
                        ErrorMessage="Email mismatch" ForeColor="Red"></asp:CompareValidator>
                    &nbsp;<br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="TBxAEmailC" ErrorMessage="Confirm Email Required" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="center" class="style3" colspan="4" 
                    style="font-family: Arial; font-size: 15px; font-weight: bolder; color: #003366">
                    Address</td>
            </tr>
            <tr>
                <td align="left" class="style5" 
                    style="font-family: Arial; font-size: 15px; font-weight: bolder; color: #003366;">
                    Street &amp; Town</td>
                <td align="left" class="style4" 
                    style="font-family: Arial; font-size: 15px; font-weight: bolder; color: #003366;">
                    County</td>
                <td align="left" class="style3" colspan="2" 
                    style="font-family: Arial; font-size: 15px; font-weight: bolder; color: #003366;">
                    Country of Residence</td>
            </tr>
            <tr>
                <td align="left" class="style5">
                    <asp:TextBox ID="TBxAadd1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="TBxAadd1" ErrorMessage="Street / town Required" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td align="left" class="style4">
                    <asp:TextBox ID="TBxAadd2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="TBxAadd2" ErrorMessage="County Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td align="left" class="style3" colspan="2">
                    <asp:DropDownList ID="DdListCountry" runat="server">
                        <asp:ListItem>United Kingdom</asp:ListItem>
                        <asp:ListItem>Denmark</asp:ListItem>
                        <asp:ListItem>France</asp:ListItem>
                        <asp:ListItem>Germany</asp:ListItem>
                        <asp:ListItem>Norway</asp:ListItem>
                        <asp:ListItem>Spain</asp:ListItem>
                        <asp:ListItem>Sweden</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="left" class="style7" 
                    style="font-family: Arial; font-size: 15px; font-weight: bolder; color: #003366">
                    Telephone Number</td>
                <td align="left" class="style8">
                </td>
                <td align="left" class="style9" colspan="2">
                </td>
            </tr>
            <tr>
                <td align="left" class="style5">
                    <asp:TextBox ID="TBATelenum" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="TBATelenum" ErrorMessage="Tel Number Required" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td align="left" class="style4">
                    <asp:Button ID="BtnSubmit" runat="server" Font-Bold="True" ForeColor="Black" 
                        onclick="BtnSubmit_Click" Text="Continue to purchase" Width="155px" />
                </td>
                <td align="left" class="style3" colspan="2">
                    <asp:Label ID="LblcConfirm" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <p>
        &nbsp;</p>
    <p>
    </p>
</asp:Content>
