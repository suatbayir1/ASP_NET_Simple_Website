<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="YemekTarifiSite.Iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            width: 100%;
        }
        .auto-style9 {
            margin-left: 40px;
        }
        .auto-style10 {
            font-size: large;
            font-weight: bold;
        }
        .auto-style11 {
            text-align: right;
        }
        .auto-style12 {
            height: 23px;
        }
        .auto-style13 {
            font-size: large;
            color: #000000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style8">
        <tr>
            <td class="auto-style13" colspan="2"><strong>MESAJ GÖNDERME PANELİ</strong></td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td class="auto-style11"><strong>Ad Soyad : </strong></td>
            <td>
                <asp:TextBox ID="txtAdSoyad" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11"><strong>E-mail : </strong></td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11"><strong>Konu : </strong></td>
            <td class="auto-style9">
                <asp:TextBox ID="txtKonu" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11"><strong>Mesaj : </strong></td>
            <td class="auto-style9">
                <asp:TextBox ID="txtMesaj" runat="server" CssClass="textbox" Height="100px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9"><strong>
                <asp:Button ID="btnGonder" runat="server" CssClass="buton" Height="33px" OnClick="btnGonder_Click" Text="Gönder" Width="230px" />
                </strong></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
