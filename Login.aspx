<%@ Page Title="Авторизация" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineShop.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="/css/style-reg-form.css" />
<main class="page">
        <div class="page__container _container">
          <div class="page__boxing">
            <div class="page__reg-form-container">
              <h3 class="form-title">Вход в личный кабинет</h3>
              <div class="form-fields">
                <div class="form-field">
                  
                    <asp:TextBox ID="UserLogin" CssClass="form-input" runat="server" placeholder="Логин" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ControlToValidate="UserLogin"></asp:RequiredFieldValidator>
                </div>
                <div class="form-field">
                  
                    <asp:TextBox ID="PasswordLogin" CssClass="form-input" runat="server" placeholder="Пароль" TextMode="Password" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2"  runat="server"  ControlToValidate="PasswordLogin"></asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="PasswordLogin" ></asp:CustomValidator>
                </div>
                  <br />
             <%--   <div class="form-important">*Не менее 8 символов</div>--%>
              </div>
              <div class="form-buttons">
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="Login_Click" CssClass="f-button" >Войти</asp:LinkButton>
              </div>
              <h2 class="simple-text">Еще нет аккаунта?</h2>
                
                <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" CssClass="create-acc-text" >Создать аккаунт</asp:LinkButton>
            </div>
            <div class="page__text">
              Необходимо войти в аккаунт, чтобы иметь возможность связаться с работодателем или добавить вакансию.
            </div>
              <asp:Label ID="Label1" Visible="false" Text="Неправлильный пароль" runat="server" />
          </div>
        </div>
      </main>
    
</asp:Content>