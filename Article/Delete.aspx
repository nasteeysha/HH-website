<%@ Page Title="Создание статьи" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="OnlineShop._Delete" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-4">
            <h2>
                <asp:Label ID="Label2" runat="server" Text="Действительно хотите удалить?" Font-Size="XX-Large" Width="1000px"></asp:Label></h2>
            <br />
                <asp:Button ID="button1" Text="Да" OnClick="button1_Click" runat="server" Height="30px" Width="240px"/></asp:Button>
                <asp:Button ID="button2" Text="Нет" OnClick="button2_Click" runat="server" Height="30px" Width="240px"/></asp:Button>         
            <br />
        </div>
    </div>
</asp:Content>
