<%@ Page Language="C#" Title="Вакансии работодателя" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="UserVacancies.aspx.cs" Inherits="OnlineShop.UserVacancies" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" href="/css/style-modules.css" />
    <link rel="stylesheet" href="/css/style-vacancy.css" />
    <main class="page">
        </br>         
        <h3 class="page-title">Вакансии работодателя</h3>
        <%
            foreach (OnlineShop.Models.Vacancy vacancy in this.vacancies)
            {
                Response.Write("<div class=\"vacancy\"><a href=\"/showvacancy?id="+vacancy.Id+"\"><p>" + vacancy.Name + "</p><p>" + vacancy.Salary + " руб </p><p><small>" + vacancy.Address + "</small></p></a></div>");
            }
            %>     
    </main>
</asp:Content>
