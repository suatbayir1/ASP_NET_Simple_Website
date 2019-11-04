<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="TarifOnerDetay.aspx.cs" Inherits="YemekTarifiSite.TarifOnerDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style9 {
            width: 100%;
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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <table class="auto-style9">
            <tr>
                <td class="auto-style14"><strong>Tarif Ad : </strong></td>
                <td>
                    <asp:TextBox ID="txtTarifAd" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14"><strong>Tarif Malzemeler : &nbsp;</strong></td>
                <td>
                    <asp:TextBox ID="txtMalzemeler" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14"><strong>Yapılış : </strong></td>
                <td>
                    <asp:TextBox ID="txtYapilis" runat="server" Height="100px" TextMode="MultiLine" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14"><strong>Tarif Resim : </strong></td>
                <td class="auto-style16">
                    <asp:FileUpload ID="fuResim" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style14"><strong>Tarif Öneren : </strong></td>
                <td class="auto-style16">
                    <asp:TextBox ID="txtTarifOneren" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14"><strong>Öneren Email : </strong></td>
                <td class="auto-style16">
                    <asp:TextBox ID="txtOnerenMail" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14"><strong>Kategori : </strong></td>
                <td class="auto-style16">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="200px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style16"><strong>
                    <asp:Button ID="btnTarifOnayla" runat="server" CssClass="auto-style17" OnClick="btnTarifOnayla_Click" Text="Onayla" Width="151px" />
                </strong></td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
