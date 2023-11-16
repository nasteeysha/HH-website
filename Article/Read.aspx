<%@ Page Title="Чтение статьи" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Read.aspx.cs" Inherits="OnlineShop._Read" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-4">
            <h2>
                <asp:Label ID="Label2" runat="server" Text="Чтение статьи" Font-Size="XX-Large" Width="1000px"></asp:Label></h2>
            <br />
            <h4>Название статьи </h4>
            <asp:Label ID="nameProduct" runat="server" Height="30px" Width="500px" AutoPostBack="True"></asp:Label>
            <h4 lang="ru">Текст статьи</h4>
            <asp:Label ID="descProduct" runat="server" Height="400px" Width="500px" TextMode="MultiLine" Rows="12"></asp:Label>
            <h4>Рейтинг</h4>
            <asp:Label ID="priceProduct" runat="server" Height="30px" Width="500px" Font-Size="Large"></asp:Label>
            <br />
            <h4>Поставить оценку</h4>
            <asp:Label ID="star1" runat="server" Height="30px" Width="31px" Font-Size="XX-Large">☆</asp:Label>
            <asp:Label ID="star2" runat="server" Height="30px" Width="31px" Font-Size="XX-Large">☆</asp:Label>
            <asp:Label ID="star3" runat="server" Height="30px" Width="31px" Font-Size="XX-Large">☆</asp:Label>
            <asp:Label ID="star4" runat="server" Height="30px" Width="31px" Font-Size="XX-Large">☆</asp:Label>
            <asp:Label ID="star5" runat="server" Height="30px" Width="31px" Font-Size="XX-Large">☆</asp:Label>
        </div>
    </div>
</asp:Content>
