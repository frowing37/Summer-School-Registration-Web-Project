<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="YeniDersBasvuru.aspx.cs" Inherits="YazOkuluKayıt_Projesi.Dersler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
        <div>
            <asp:Label runat="server" Text="Ders Seçin"></asp:Label>
        
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
            </asp:DropDownList>
        
        </div>
        <br />
        <div>
            <asp:Label runat="server" Text="Öğrenci Seçin"></asp:Label>
            
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control">
            </asp:DropDownList>
            
        </div>
        <br />
        <asp:Button ID="Kaydet" runat="server" CssClass="btn btn-warning" Text="Kaydet" OnClick="Unnamed3_Click" />
        
    </form>

</asp:Content>
