<%@ Page Title="Редактирование статьи" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="OnlineShop._Edit" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-4">
            <h2>
                <asp:Label ID="Label2" runat="server" Text="Редактирование статьи" Font-Size="XX-Large" Width="1000px"></asp:Label></h2>
            <br />
            <h4>Название статьи </h4>
            <asp:TextBox ID="nameProduct" runat="server" Height="30px" Width="500px"></asp:TextBox>
            <h4 lang="ru">Текст статьи</h4>
            <asp:TextBox ID="descProduct" runat="server" Height="400px" Width="500px" TextMode="MultiLine" Rows="12"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Font-Italic="True" Font-Size="Small" ForeColor="#FF3300" Text="Статья с таким именем уже есть" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="button1" Text="Изменить" OnClick="button1_Click" runat="server" Height="30px" Width="240px" />
            <br />
        </div>
    </div>
</asp:Content>
