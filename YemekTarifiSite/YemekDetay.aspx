<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="YemekDetay.aspx.cs" Inherits="YemekTarifiSite.YemekDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style9 {
        width: 100%;
    }
        .auto-style11 {
            font-size: x-large;
            color: #FFFFFF;
        }
        .auto-style12 {
            font-size: x-large;
            color: #CCCCCC;
        }
        .auto-style13 {
            background-color: #EEA4A4;
            text-align: center;
        }
        .auto-style14 {
            text-align: right;
        }
        .auto-style16 {
            text-align: left;
        }
        .auto-style17 {
            font-size: medium;
            font-weight: bold;
        }
    .auto-style10 {
        font-size: small;
    }
        .auto-style18 {
            height: 31px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <strong>
    <asp:Label ID="Label3" runat="server" CssClass="auto-style11" Text="Label"></asp:Label>
    <br />
    </strong>
<asp:DataList ID="DataList2" runat="server" Width="448px">
    <ItemTemplate>
        <table class="auto-style9">
            <tr>
                <td class="auto-style18">
                    <asp:Label ID="Label4" runat="server" CssClass="auto-style12" Text='<%# Eval("YorumAdSoyad") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("Yorumicerik") %>'></asp:Label>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="border-bottom-style: groove; border-bottom-width: thin; border-bottom-color: #000000">
                    <asp:Label ID="Label6" runat="server" CssClass="auto-style10" Text='<%# Eval("YorumTarih") %>'></asp:Label>
                </td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>
    <br />

    <div class="auto-style13"> YORUM YAPMA PANELİ </div>

    <asp:Panel ID="Panel1" runat="server">
        <table class="auto-style9">
            <tr>
                <td class="auto-style14"><strong>Ad Soyad : </strong></td>
                <td>
                    <asp:TextBox ID="txtAdSoyad" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14"><strong>E-mail : &nbsp;</strong></td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14"><strong>Yorumunuz : </strong></td>
                <td>
                    <asp:TextBox ID="txtYorum" runat="server" Height="100px" TextMode="MultiLine" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style16"><strong>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style17" OnClick="Button1_Click" Text="Yorum Yap" />
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
