<%@ Page Language="C#" Title="Личный кабинет" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="Profile.aspx.cs" Inherits="OnlineShop.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="/css/style-st-profile.css" />
    <link rel="stylesheet" href="/css/style-reg-form.css" />
    <main class="page">
        <div class="page__container _container">
            <div class="page__boxing">
                <div class="page__boxing-description">
                   
                    <div class="name__boxing">
                         <% if (user.Role == "admin")
                            Response.Write("<h1 class=\"page__boxing-title\">Профиль работодателя</h1>");
                        else
                            Response.Write("<h1 class=\"page__boxing-title\">Профиль соискателя</h1>");
                    %>
                        <h2 class="page__boxing-name">Имя: <% Response.Write(this.user.FName); %></h2>
                        <h2 class="page__boxing-name">Фамилия: <%Response.Write(this.user.LName); %></h2>
                        <h2 class="page__boxing-name">Дата рождения: <%Response.Write(this.user.Birthday.ToShortDateString()); %></h2>
                        <h2 class="page__boxing-name">Почта: <%Response.Write(this.user.Email); %></h2>
                        <h2 class="page__boxing-name">Описание:   
                                <asp:TextBox TextMode="MultiLine" ReadOnly="true" ID="Desc" CssClass="form-input-description-show-without-shadow" runat="server" /></h2>
                        <h2 class="page__boxing-name">Телефон: <%Response.Write(this.user.Number); %></h2>
                        <br />
                        <div class="main-block__buttons">
                            <asp:LinkButton ID="LinkButton3" OnClick="LinkButton3_Click" CssClass="main-block__button" runat="server">Редактировать</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </main>
</asp:Content>
