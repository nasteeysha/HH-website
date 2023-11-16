<%@ Page Title="Главная" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="OnlineShop.MainPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <main class="page">
        <div class="page__main-block main-block">
          <div class="main-block__container _container">
            <div class="main-block__body">
              <h1 class="main-block__title">
                Найти работу - легко!
              </h1>
              <div class="main-block__buttons">             
                  <asp:LinkButton ID="LinkButton1" OnClick="LinkButton3_Click" CssClass="main-block__button" runat="server">Соискатель</asp:LinkButton>
              </div>
                <br />
              <div class="main-block__buttons">             
                  <asp:LinkButton ID="LinkButton3" OnClick="LinkButton1_Click" CssClass="main-block__button" runat="server">Работодатель </asp:LinkButton>
              </div>
            </div>
          </div>
          </div>     
      </main>
</asp:Content>
