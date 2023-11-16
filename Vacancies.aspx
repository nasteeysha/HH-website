<%@ Page Language="C#" Title="Вакансии" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="Vacancies.aspx.cs" Inherits="OnlineShop.Vacancies" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" href="/css/style-modules.css" />
    <link rel="stylesheet" href="/css/style-vacancy.css" />
    <main class="page">
                </br>       
        <div class="page__vacancy-container">
              <h3 class="page-title">Актуальные вакансии</h3>
                   <asp:TextBox ID="find" CssClass="find-input" AutoPostBack="true" runat="server" placeholder="Поиск по вакансиям" ></asp:TextBox><br /> <br />
          </div>
        <%
            foreach (OnlineShop.Models.Vacancy vacancy in this.vacancies)
            {
                Response.Write("<div class=\"vacancy\"><a href=\"/showvacancy?id="+vacancy.Id+"\"><p>" + vacancy.Name + "</p><p>" + vacancy.Salary + " руб </p><p><small>" + vacancy.Address + "</small></p></a></div>");
            }
            %>     
    </main>
</asp:Content>
