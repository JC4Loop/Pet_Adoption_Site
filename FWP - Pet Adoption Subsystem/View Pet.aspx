<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="View Pet.aspx.cs" Inherits="FWP___Pet_Adoption_Subsystem.View_Pet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p align="center" 
        
        style="font-family: Arial; font-size: medium; font-weight: bold; color: #000000">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Pet details are 
        below, Select which pet you wish to adopt<br />
    </p>
    <p style="font-family: Arial; font-size: small; font-weight: bolder; font-style: italic; color: #000066">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;You may view the pets in an optional order by selecting a detail from 
        the dropdownlist<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
            style="margin-left: 384px">
            <asp:ListItem Value="RescueDate" Selected="True">Sort by Rescue Date</asp:ListItem>
            <asp:ListItem Value="Name">Sort by Name</asp:ListItem>
            <asp:ListItem Value="RescueAge">Sort by Age at Rescue</asp:ListItem>
            <asp:ListItem Value="Specie">Sort by Specie</asp:ListItem>
            <asp:ListItem Value="Breed">Sort by Breed</asp:ListItem>
            <asp:ListItem Value="Sanctuary">Sort by Sanctuary</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p style="font-family: Arial; font-size: small; font-weight: bolder; font-style: italic; color: #000066">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p style="font-family: Arial; font-size: small; font-weight: bolder; font-style: italic; color: #000066">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Note :"></asp:Label>
&nbsp;you may only adopt a pet from the same country as your resident. Pets already 
        adopted (highlight in black) cannot be adopted again.</p>
    <div align="center">
        <asp:Table ID="Table1" runat="server" style="margin-left: 14px">
        </asp:Table>
    </div>
    <p style="font-family: Arial; font-size: small; font-weight: bolder; font-style: italic; color: #000066">
        &nbsp;</p>
    <p align="center">
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
