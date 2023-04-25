<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OgrtEkle.aspx.cs" Inherits="YazOkuluKayıt_Projesi.OgrtEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form ID="Form5" runat="server">
        <table class="table table-bordered table-hover">
            <div>
                <tr>
                <asp:Label ID="oad1" style="margin-left:10px;" runat="server" Text="Label">Öğretmen Ad ve Soyadı</asp:Label>
                <asp:TextBox ID="oad" runat="server" CssClass="form-control"></asp:TextBox>
            </tr>
            </div>
            <div>
                <tr>
                <asp:Label ID="omin" style="margin-left:10px;" runat="server" Text="Label">Öğretmen Branşı Seçiniz</asp:Label>
                <asp:DropDownList ID="drop1" runat="server" CssClass="form-control"></asp:DropDownList>
            </tr>
            </div>
            <div>&nbsp</div>
            <div>
                <tr>
                
                    <asp:Button ID="Button1" runat="server" style="margin-left:10px;" CssClass="btn btn-warning" Text="Kaydet" OnClick="click_Load" />
            </tr>
            </div>
        </table>
    </form>
</asp:Content>
