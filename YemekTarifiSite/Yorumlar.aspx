<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yorumlar.aspx.cs" Inherits="YemekTarifiSite.Yorumlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style7 {
            width: 31px;
        }
        .auto-style8 {
            width: 34px;
        }
        .auto-style4 {
            text-align: left;
            width: 302px;
        }
        .auto-style6 {
            font-size: large;
        }
        .auto-style5 {
            text-align: right;
        }
                .auto-style3 {
            background-color: #CCCCCC;
            margin-top:25px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style3">
        <table class="auto-style2">
            <tr>
                <td class="auto-style7"><strong>
                    <asp:Button ID="btnAc" runat="server" Height="30px"  Text="+" Width="30px" OnClick="btnAc_Click1"   />
                    </strong></td>
                <td class="auto-style8"><strong>
                    <asp:Button ID="btnKapat" runat="server" Height="30px"  Text="-" Width="30px" OnClick="btnKapat_Click1"   />
                    </strong></td>
                <td>&nbsp;ONAYLANAN YORUM LİSTESİ&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>

    <asp:Panel ID="Panel2" runat="server">
        <asp:DataList ID="DataList1" runat="server" Width="446px">
            <ItemTemplate>
                <table class="auto-style2">
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style6" Text='<%# Eval("YorumAdSoyad") %>'></asp:Label>
                        </td>
                        <td class="auto-style5">
                           <a href="Yorumlar.aspx?Yorumid=<%# Eval("Yorumid") %>&islem=sil"> <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/resimler/delete.jpg" Width="30px" /></a>
                        </td>
                        <td class="auto-style5">
                           <a href="YemekDuzenle.aspx?Yemekid=<%# Eval("Yemekid") %>"><asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/resimler/update.png" Width="30px" /></a> 
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>

        <asp:Panel ID="Panel3" runat="server" CssClass="auto-style3" >
        <table class="auto-style2">
            <tr>
                <td class="auto-style7"><strong>
                    <asp:Button ID="Button1" runat="server" Height="30px"  Text="+" Width="30px" OnClick="Button1_Click"   />
                    </strong></td>
                <td class="auto-style8"><strong>
                    <asp:Button ID="Button2" runat="server" Height="30px"  Text="-" Width="30px" OnClick="Button2_Click"  />
                    </strong></td>
                <td>&nbsp;ONAYSIZ YORUM LİSTESİ&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>

    <asp:Panel ID="Panel4" runat="server">
        <asp:DataList ID="DataList2" runat="server" Width="446px">
            <ItemTemplate>
                <table class="auto-style2">
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style6" Text='<%# Eval("YorumAdSoyad") %>'></asp:Label>
                        </td>
                        <td class="auto-style5">
                           <a href="Yorumlar.aspx?Yorumid=<%# Eval("Yorumid") %>&islem=sil"> <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/resimler/delete.jpg" Width="30px" /></a>
                        </td>
                        <td class="auto-style5">
                           <a href="YorumDetay.aspx?Yorumid=<%# Eval("Yorumid") %>"><asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/resimler/update.png" Width="30px" /></a> 
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>

        </asp:Content>
