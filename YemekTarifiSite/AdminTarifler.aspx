<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminTarifler.aspx.cs" Inherits="YemekTarifiSite.AdminTarifler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            background-color: #CCCCCC;
            margin-top:25px;
        }       
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
     </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style3">
        <table class="auto-style2">
            <tr>
                <td class="auto-style7"><strong>
                    <asp:Button ID="btnAc" runat="server" Height="30px"  Text="+" Width="30px" OnClick="btnAc_Click1"    />
                    </strong></td>
                <td class="auto-style8"><strong>
                    <asp:Button ID="btnKapat" runat="server" Height="30px"  Text="-" Width="30px" OnClick="btnKapat_Click1" />
                    </strong></td>
                <td>ONAYSIZ TARİF LİSTESİ&nbsp;</td>
            </tr>
        </table>
     </asp:Panel>
        <asp:Panel ID="Panel2" runat="server">
            <asp:DataList ID="DataList1" runat="server" Width="446px">
                <ItemTemplate>
                    <table class="auto-style2">
                        <tr>
                            <td class="auto-style4">
                                <asp:Label ID="Label1" runat="server" CssClass="auto-style6" Text='<%# Eval("TarifAd") %>'></asp:Label>
                            </td>
                            <td class="auto-style5">                              
                                   <a href="TarifOnerDetay.aspx?Tarifid=<%# Eval("Tarifid") %>"><asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/resimler/oneri.png" Width="30px" /></a>                               
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
         </asp:Panel>
         
    <asp:Panel ID="Panel3" runat="server" CssClass="auto-style3">
                <table class="auto-style2">
                    <tr>
                        <td class="auto-style7"><strong>
                            <asp:Button ID="btnAc0" runat="server" Height="30px"  Text="+" Width="30px" OnClick="btnAc0_Click" />
                            </strong></td>
                        <td class="auto-style8"><strong>
                            <asp:Button ID="btnKapat0" runat="server" Height="30px"  Text="-" Width="30px" OnClick="btnKapat0_Click" />
                            </strong></td>
                        <td>&nbsp;ONAYLI TARİF LİSTESİ&nbsp;</td>
                    </tr>
                </table>
        </asp:Panel>
            <asp:Panel ID="Panel4" runat="server">
            <asp:DataList ID="DataList2" runat="server" Width="446px">
                <ItemTemplate>
                    <table class="auto-style2">
                        <tr>
                            <td class="auto-style4">
                                <asp:Label ID="Label1" runat="server" CssClass="auto-style6" Text='<%# Eval("TarifAd") %>'></asp:Label>
                            </td>
                            <td class="auto-style5">                              
                                   <a href="TarifOnerDetay.aspx?Tarifid=<%# Eval("Tarifid") %>"><asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/resimler/oneri.png" Width="30px" /></a>                               
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
         </asp:Panel>
</asp:Content>
