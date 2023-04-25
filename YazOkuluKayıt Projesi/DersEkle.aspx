<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DersEkle.aspx.cs" Inherits="YazOkuluKayıt_Projesi.DersEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="Form3" runat="server">
        <table>
            <tr>
                <asp:Label ID="Label1" style="margin-left:10px;" runat="server" Text="Label">Ders Adı</asp:Label>
                <asp:TextBox ID="dad" CssClass="form-control" runat="server"></asp:TextBox>
            </tr>
            <tr>
                <asp:Label ID="Label2" style="margin-left:10px;" runat="server" Text="Label">Minimum Kontenjan</asp:Label>
                <asp:TextBox ID="dmin" CssClass="form-control" runat="server"></asp:TextBox>
            </tr>
            <tr>
                <asp:Label ID="Label3" style="margin-left:10px;" runat="server" Text="Label">Maximum Kontenjan</asp:Label>
                <asp:TextBox ID="dmax" CssClass="form-control" runat="server"></asp:TextBox>
            </tr>
            <tr><div>&nbsp</div></tr>
            <tr>
                <asp:Button ID="dk" style="margin-left:10px;" CssClass="btn-success" runat="server" Text="Dersi Kaydet" OnClick="Kaydet_Click" />
            </tr>
        </table>
    </form>
</asp:Content>
