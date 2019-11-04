<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KategoriAdminDetay.aspx.cs" Inherits="YemekTarifiSite.KategoriAdminDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            text-align: right;
        }
        .auto-style4 {
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style2">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"><strong>KATEGORİ AD : </strong></td>
            <td>
                <asp:TextBox ID="txtKategoriAd" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3"><strong>KATEGORİ ADET : </strong></td>
            <td>
                <asp:TextBox ID="txtKategoriAdet" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3"><strong>KATEGORİ RESİM :</strong></td>
            <td>
                <asp:FileUpload ID="fuKategoriResim" runat="server" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><strong>
                <asp:Button ID="btnKategoriGüncelle" runat="server" CssClass="auto-style4" OnClick="btnKategoriGüncelle_Click" Text="GÜNCELLE" />
                </strong></td>
        </tr>
    </table>
</asp:Content>
