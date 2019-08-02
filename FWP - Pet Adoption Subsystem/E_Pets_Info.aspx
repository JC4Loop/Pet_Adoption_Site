<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="E_Pets_Info.aspx.cs" Inherits="FWP___Pet_Adoption_Subsystem.E_Pets_Info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center" 
        style="font-family: Arial; font-size: large; font-weight: bolder; text-decoration: underline; color: #000000; background-color: #009933">
        Information on &#39;FWPs`&#39; Endangered Pets</div>
    <asp:Panel ID="Panel1" runat="server" BackColor="#009933" Font-Size="Small" 
        ForeColor="#000066" Height="81px">
        <br />
        &nbsp;The &#39;Friends With Paws&#39; Sanctuary within the United Kingdom, includes a number 
        of Endangered Species.<br /> &nbsp;These endangered species, or endangered breeds, 
        are available for adoption along with other pet species,
        <br />
        &nbsp;however at a highter price, depending on the endangered category of the pet.<br />
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" BackColor="#009933" Height="1200px">
        <table style="width:100%;">
            <tr>
                <td class="style1" colspan="3" 
                    style="font-family: Arial; font-weight: bolder; color: #000066">
                    Below is a table displaying the details of Endangered Pets available</td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td align="center">
                    <asp:Table ID="Table1" runat="server">
                    </asp:Table>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td style="font-family: Arial; font-weight: bolder; color: #000066">
                    The list box below shows all pet Species / Breeds and whether they are 
                    endangered or not.<br />
                    <br />
                    <asp:ListBox ID="ListBox1" runat="server" Height="250px" Width="594px">
                    </asp:ListBox>
                    <asp:ListView ID="ListView1" runat="server">
                    </asp:ListView>
                </td>
                <td>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <p>
        <br />
    </p>
</asp:Content>
