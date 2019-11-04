<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHakkimizda.aspx.cs" Inherits="YemekTarifiSite.AdminHakkimizda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style3 {
            background-color: #CCCCCC;
        }       
        .auto-style7 {
            width: 31px;
        }
        .auto-style8 {
            width: 34px;
        }
        .auto-style9 {
        text-align: center;
    }
    .auto-style10 {
        font-weight: bold;
    }
    .auto-style11 {
        font-size: medium;
    }
    .auto-style12 {
        margin-left: 40px;
    }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style3">
        <table class="auto-style2">
            <tr>
                <td class="auto-style7"><strong>
                    <asp:Button ID="btnAc" runat="server" Height="30px"  Text="+" Width="30px" OnClick="btnAc_Click"     />
                    </strong></td>
                <td class="auto-style8"><strong>
                    <asp:Button ID="btnKapat" runat="server" Height="30px"  Text="-" Width="30px" OnClick="btnKapat_Click"  />
                    </strong></td>
                <td>ONAYSIZ TARİF LİSTESİ&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>

    <asp:Panel ID="Panel2" runat="server">
        <table class="auto-style2">
            <tr>
                <td class="auto-style12"><em>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style11" Height="200px" TextMode="MultiLine" Width="435px"></asp:TextBox>
                    </em></td>
            </tr>
            <tr>
                <td class="auto-style9"><strong>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style10" Height="30px" OnClick="Button1_Click" Text="Değiştir" Width="200px" />
                    </strong></td>
            </tr>
        </table>
</asp:Panel>
</asp:Content>
