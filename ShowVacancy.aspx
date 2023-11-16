
<%@ Page Title="Вакансия" Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="ShowVacancy.aspx.cs" Inherits="OnlineShop.ShowVacancy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" href="/css/style-lessons.css" />
    <link rel="stylesheet" href="/css/style-st-profile.css" />
    <link rel="stylesheet" href="/css/style-reg-form.css" />
    <main class="page">
        <div class="page__container _container">
            <div class="page-title-boxing">
                <h1 class="page-title"><%Response.Write(vacancy.Name); %></h1>
                    <h2 class="page__boxing-name">Добавили в избранное: <%Response.Write(countUserLikeVacancy); %> человек</h2>
            </div>
            <div class="page__boxing-description">
                <div class="name__boxing">                    
                    <h2 class="page__boxing-name">Обязанности:   
                                <asp:TextBox TextMode="MultiLine" ReadOnly="true" ID="Responsibilities" CssClass="form-input-description-show-without-shadow" runat="server" /></h2>
                    <h2 class="page__boxing-name">Описание:   
                                <asp:TextBox TextMode="MultiLine" ReadOnly="true" ID="Desc" CssClass="form-input-description-show-without-shadow" runat="server" /></h2>
                    <h2 class="page__boxing-name">Опыт работы: <%Response.Write(vacancy.JobExperience); %></h2>
                    <h2 class="page__boxing-name">Оклад: <%Response.Write(vacancy.Salary.ToString()); %> руб</h2>
                    <h2 class="page__boxing-name">Адрес: <%Response.Write(vacancy.Address); %></h2>
                    <% if (mail != "")
                            Response.Write("<h2 class=\"page__boxing-name\">Почта: "+mail+"</h2>");
                        if (phone != null)
                            Response.Write("<h2 class=\"page__boxing-name\">Телефон: "+phone+"</h2>");
                    %>          
                    <br />
                </div>
            </div>
            <div class="page-boxing__buttons">
                <div class="page__buttons"><a href="/vacancies" class="page__button_last">Вернуться</a></div>
                <%
                    string text;
                    if (this.isFavoirite)
                        text = "Убрать из избранного";
                    else
                        text = "Добавить в избранное";
                    if (OnlineShop.Cookies.Role(this) == "user")
                        Response.Write("<div class=\"page__buttons\"><a href=\"/favoritevacancy?id=" + vacancy.Id + "\" class=\"page__button_last\">" + text + "</a></div>");
                    if (isOwner)
                    {
                        Response.Write("<div class=\"page__buttons\"><a href=\"/editVacancy?vacancyId=" + vacancy.Id + "\" class=\"page__button_last\"> Изменить</a></div>");
                        Response.Write("<div class=\"page__buttons\"><a href=\"/delete?vacancyId=" + vacancy.Id + "\" class=\"page__button_last\">Удалить</a></div>");
                    }
                %>
            </div>
        </div>
    </main>
</asp:Content>
