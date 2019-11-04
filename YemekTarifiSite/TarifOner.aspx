<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="TarifOner.aspx.cs" Inherits="YemekTarifiSite.TarifOner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
            width: 100%;
        }
        .auto-style8 {
            height: 23px;
        }
        .auto-style9 {
            height: 23px;
            margin-left: 40px;
        }
        .auto-style10 {
            height: 23px;
            text-align: right;
        }
        .auto-style11 {
            text-align: right;
        }
        .auto-style12 {
            font-style: italic;
            font-weight: bold;
            margin-left: 50px;
        }
        .auto-style13 {
            height: 23px;
            text-align: left;
            margin-left: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style7">
        <tr>
            <td><strong></strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11"><strong>Tarif Ad : </strong></td>
            <td>
                <asp:TextBox ID="txtTarifAd" runat="server" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10"><strong>Malzemeler : </strong></td>
            <td class="auto-style9">
                <asp:TextBox ID="txtTarifMalzemeler" runat="server" Height="80px" TextMode="MultiLine" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10"><strong>Yapılış : </strong></td>
            <td class="auto-style9">
                <asp:TextBox ID="txtTarifYapilis" runat="server" Height="150px" TextMode="MultiLine" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10"><strong>Resim : </strong></td>
            <td class="auto-style9">
                <asp:FileUpload ID="fuTarihResim" runat="server" Width="250px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style10"><strong>Tarif Öneren : </strong></td>
            <td class="auto-style9">
                <asp:TextBox ID="txtTarifOneren" runat="server" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10"><strong>Mail Adres :</strong></td>
            <td class="auto-style9">
                <asp:TextBox ID="txtMailAdres" runat="server" TextMode="Email" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style13"><strong><em>
                <asp:Button ID="btnTarifOner" runat="server" BackColor="#9999FF" CssClass="auto-style12" Height="40px" Text="Tarif Öner" Width="150px" OnClick="btnTarifOner_Click" />
                </em></strong></td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
