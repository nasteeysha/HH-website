<%@ Page Language="C#" Title="Редактировать" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UserEdit.aspx.cs" Inherits="OnlineShop.UserEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="/css/style-reg-form.css" />
    <main class="page">
        <div class="page__container _container">
            <div class="page__boxing">
                <div class="page__reg-form-container">
                    <asp:Label ID="Label2" runat="server" CssClass="form-title" Text="Редактировать"></asp:Label>
                    <%--<h1 class="form-title">Регистрация</h1>--%>
                    <div class="form-fields">
                        <div class="form-field">
                            <!--<input type="text" placeholder="Имя" />-->
                            <asp:TextBox ID="FName" CssClass="form-input" runat="server" placeholder="Имя" />
                            <asp:RequiredFieldValidator CssClass="simple-text" ErrorMessage="Необходимо указать имя" ID="RequiredFieldValidator1" runat="server" ControlToValidate="FName"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-field">
                            <!-- <input type="text" placeholder="Фамилия" />-->
                            <asp:TextBox ID="LName" CssClass="form-input" runat="server" placeholder="Фамилия" />
                            <asp:RequiredFieldValidator CssClass="simple-text" ErrorMessage="Необходимо указать фамилию" ID="RequiredFieldValidator2" runat="server" ControlToValidate="LName"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-field">
                            <!-- <input type="text" placeholder="Почта" />-->
                            <asp:TextBox ID="Email" CssClass="form-input" runat="server" placeholder="Почта" />
                            <asp:RequiredFieldValidator CssClass="simple-text" ErrorMessage="Необходимо указать почту" ID="RequiredFieldValidator3" runat="server" ControlToValidate="Email"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-field">
                            <asp:TextBox ID="Number" CssClass="form-input" runat="server" placeholder="Номер телефона" TextMode="Number" />
                            <asp:RangeValidator CssClass="simple-text" ErrorMessage="Необходимо указать номер в формате 8..."
                                ID="NumberCheck" Type="Double" MinimumValue="80000000000" MaximumValue="89999999999" runat="server" ControlToValidate="Number"></asp:RangeValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="Number"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-field">
                            <asp:TextBox ID="Desc" CssClass="form-input-description" runat="server" placeholder="Описание" Wrap="true" TextMode="MultiLine" Height="100px" />
                        </div>
                        <div class="form-field">
                            <asp:TextBox ID="Birthday" CssClass="form-input" runat="server" placeholder="Дата рождения" TextMode="Date" />
                            <asp:RequiredFieldValidator CssClass="simple-text" ErrorMessage="Необходимо указать дату рождения" ID="RequiredFieldValidator7" runat="server" ControlToValidate="Birthday"></asp:RequiredFieldValidator>

                        </div>
                        <div class="form-field">
                            <asp:TextBox ID="Username" CssClass="form-input" runat="server" placeholder="Логин" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="simple-text" ErrorMessage=" Необходимо указать логин" runat="server" ControlToValidate="Username"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-field">
                            <asp:TextBox ID="Password" CssClass="form-input" runat="server" placeholder="Пароль" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Password"></asp:RequiredFieldValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" CssClass="simple-text" ErrorMessage=" Необходимо указать пароль" runat="server" ControlToValidate="Password"></asp:RequiredFieldValidator>
                        </div>
                          <div>
                        <asp:Label runat="server" ID="Label1" Visible="false" CssClass="simple-text">Аккаунт с таким логином уже существует</asp:Label>
                    </div>
                    </div>
                    <div class="form-buttons">
                        <br />
                        <asp:LinkButton ID="LinkButton1" OnClick="RegistrationClick" runat="server" CssClass="f-button" Text="Редактировать"></asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </main>
</asp:Content>

