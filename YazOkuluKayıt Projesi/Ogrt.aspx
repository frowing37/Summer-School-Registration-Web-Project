<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Ogrt.aspx.cs" Inherits="YazOkuluKayıt_Projesi.Ogrt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form ID="Form4" runat="server">
        <table class="table table-bordered table-hover">
            <tr>
                <td>Öğretmen Adları</td>
                <td>Öğretmen Branşları</td>
                <td>İşlemler</td>
            </tr>
            <tr>
                <body>
                    <asp:Repeater ID="Repeater3" runat="server">
                    <ItemTemplate>
                        <tr>
                        <td><tb><%#Eval("Ogrtad") %></tb></td>
                        <td><tb><%#Eval("Ogrtbrans") %></tb></td>
                            <td>
                                <asp:HyperLink ID="hl1" NavigateUrl='<%# "OgrtGüncelle.aspx?OgrtID=" + Eval("Ogrtid") %>' CssClass="btn-success" runat="server">Güncelle</asp:HyperLink>
                                <asp:HyperLink ID="hl2" NavigateUrl='<%# "OgrtSil.aspx?OgrtID=" + Eval("Ogrtid") %>' CssClass="btn-danger" runat="server">Sil</asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                </body>
            </tr>
        </table>
    </form>
</asp:Content>
