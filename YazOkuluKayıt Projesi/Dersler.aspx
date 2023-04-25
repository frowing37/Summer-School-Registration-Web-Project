<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dersler.aspx.cs" Inherits="YazOkuluKayıt_Projesi.Dersler1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form ID="Form2" runat="server">
        <table class="table table-bordered table-hover">
            <tr>
                <th>Ders</th>
                <th>Minimum Kontenjan</th>
                <th>Maximum Kontenjan</th>
                <th>İşlem</th>
            </tr>
            <body>
                <asp:Repeater ID="Repeater2" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("Dersad") %></td>
                            <td><%#Eval("Max") %></td>
                            <td><%#Eval("Min") %></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%# "~/DersGüncelle.aspx?DersID=" + Eval("Id") %>' runat="server" CssClass="btn-success">Güncelle</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%# "~/DersSil.aspx?DersID=" + Eval("Id") %>' runat="server" CssClass="btn-danger">Sil</asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </body>
        </table>
    </form>



</asp:Content>
