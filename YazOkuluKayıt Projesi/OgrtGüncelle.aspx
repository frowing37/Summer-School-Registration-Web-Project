<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OgrtGüncelle.aspx.cs" Inherits="YazOkuluKayıt_Projesi.OgrtGüncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form ID="Form5" runat="server" style="height: 162px">
        <table class="table table-bordered table-hover">
            <tr>
                <asp:Label ID="oad" style="margin-left:10px;" runat="server" Text="Label">Öğretmen Ad ve Soyadı</asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </tr>
            <tr>
                <asp:Label ID="omin" style="margin-left:10px;" runat="server" Text="Label">Öğretmen Branşı Seçiniz</asp:Label>
                <asp:DropDownList ID="drop1" runat="server" CssClass="form-control"></asp:DropDownList>
            </tr>
            <tr>
                <asp:Button ID="kaydet" style="margin-left:10px;" runat="server" CssClass="btn btn-success" Text="Güncelle" OnClick="click"/>
            </tr>
        </table>
    </form>
</asp:Content>
