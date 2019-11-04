<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Kategoriler.aspx.cs" Inherits="YemekTarifiSite.Kategoriler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            background-color: #CCCCCC;
            margin-top:25px;
        }
        .auto-style4 {
            text-align: left;
            width: 302px;
        }
        .auto-style5 {
            text-align: right;
        }
        .auto-style6 {
            font-size: large;
        }
        .auto-style7 {
            width: 31px;
        }
        .auto-style8 {
            width: 34px;
        }
        .auto-style9 {
            font-size: medium;
        }
        .auto-style10 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style3">
        <table class="auto-style2">
            <tr>
                <td class="auto-style7"><strong>
                    <asp:Button ID="btnAc" runat="server" Height="30px" OnClick="btnAc_Click" Text="+" Width="30px" />
                    </strong></td>
                <td class="auto-style8"><strong>
                    <asp:Button ID="btnKapat" runat="server" Height="30px" OnClick="btnKapat_Click" Text="-" Width="30px" />
                    </strong></td>
                <td>KATEGORİ LİSTESİ</td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <asp:DataList ID="DataList1" runat="server" Width="446px">
            <ItemTemplate>
                <table class="auto-style2">
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style6" Text='<%# Eval("KategoriAd") %>'></asp:Label>
                        </td>
                        <td class="auto-style5">
                           <a href="Kategoriler.aspx?Kategoriid=<%# Eval("Kategoriid") %>&islem=sil"> <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/resimler/delete.jpg" Width="30px" /></a>
                        </td>
                        <td class="auto-style5">
                           <a href="KategoriAdminDetay.aspx?Kategoriid=<%# Eval("Kategoriid") %>"><asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/resimler/update.png" Width="30px" /></a> 
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>

        <asp:Panel ID="Panel4" runat="server" CssClass="auto-style3">
            <table class="auto-style2">
                <tr>
                    <td class="auto-style7"><strong>
                        <asp:Button ID="btnKategoriEkleAc" runat="server" Height="30px" Text="+" Width="30px" OnClick="btnKategoriEkleAc_Click" />
                        </strong></td>
                    <td class="auto-style8"><strong>
                        <asp:Button ID="btnKategoriEkleKapat" runat="server" Height="30px" Text="-" Width="30px" OnClick="btnKategoriEkleKapat_Click" />
                        </strong></td>
                    <td>KATEGORİ EKLEME</td>
                </tr>
            </table>
        </asp:Panel>

    <asp:Panel ID="Panel3" runat="server">
        <table class="auto-style2">
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td>KATEGORİ AD :</td>
                <td>
                    <asp:TextBox ID="txtKategoriAd" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>KATEGORİ İCON : </td>
                <td>
                    <asp:FileUpload ID="fuKategoriIcon" runat="server" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td><strong>
                    <asp:Button ID="btnKategoriEkle" runat="server" CssClass="auto-style9" Text="Ekle" Width="100px" OnClick="btnKategoriEkle_Click" />
                    </strong></td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
