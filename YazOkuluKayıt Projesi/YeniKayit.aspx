<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="YeniKayit.aspx.cs" Inherits="YazOkuluKayıt_Projesi.YeniKayit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 38px"></div>
    <form id="form1" runat="server" style="padding: 1px; border-style: groove; border-width: 2px;">
        <table class="nav-justified" style="height: 328px">
            <tr>
                <td style="font-size: large"><strong>Öğrenci Adı</strong></td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="ad" runat="server" Width="604px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size: large"><strong>Öğrenci Soyadı</strong></td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="soyad" runat="server" Width="604px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size: large"><strong>Öğrenci Numarası</strong></td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="numara" runat="server" Width="604px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size: large"><strong>Öğrenci Mail</strong></td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="mail" runat="server" Width="604px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size: large"><strong>Öğrenci Şifre</strong></td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="sifre" runat="server" Width="604px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size: large"><strong>Öğrenci Fotoğraf</strong></td>
            </tr>
            <tr>
                <td style="font-size: large">
                    <asp:FileUpload ID="foto" runat="server" Width="606px" />
                </td>
            </tr>
            <tr>
                <td style="font-size: xx-small">&nbsp;</td>
            </tr>
            <tr>
                <td class="text-center" style="font-size: large">
                    <asp:Button ID="Button1" runat="server"  CssClass="btn-success" Height="28px" Text="Kaydet" Width="179px" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
