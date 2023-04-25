<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Ogrenciler.aspx.cs" Inherits="YazOkuluKayıt_Projesi.Ogrenciler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="Form1" runat="server">

        <table class="table table-bordered table-hover">

            <tr>
                <th>Öğrenci ID</th>
                <th>Öğrenci Ad</th>
                <th>Öğrenci Soyad</th>
                <th>Öğrenci Numara</th>
                <th>Öğrenci Şifre</th>
                <th>Öğrenci Fotoğraf</th>
                <th>Bakiye</th>
                <th>İşlemler</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("Id") %></td>
                            <td><%#Eval("Ad") %></td>
                            <td><%#Eval("Soyad") %></td>
                            <td><%#Eval("Numara") %></td>
                            <td><%#Eval("Mail") %></td>
                            <td><%#Eval("Fotograf") %></td>
                            <td><%#Eval("Bakiye") %></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%#"~/OgrenciGuncelle.aspx?OgrID=" + Eval("Id") %>' ID="HyperLink1"  CssClass="btn-success" runat="server">Güncelle</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%# "~/OgrenciSil.aspx?OgrID=" + Eval("Id")%>'  ID="HyperLink2"  CssClass="btn-danger" runat="server">Sil</asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>


        </table>

        </form>
</asp:Content>
