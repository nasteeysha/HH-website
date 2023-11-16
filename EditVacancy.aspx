<%@ Page Language="C#" Title="Редактировать вакансию" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditVacancy.aspx.cs" Inherits="OnlineShop.EditVacancy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="/css/style-reg-form.css" />
    <main class="page">
        <div class="page__container _container">
            <div class="page__boxing">
                <div class="page__reg-form-container">
                    <asp:Label ID="Label2" runat="server" CssClass="form-title" Text="Добавление вакансии"></asp:Label>
                    <div class="form-fields">
                        <div class="form-field">
                            <asp:TextBox ID="Name" CssClass="form-input" runat="server" placeholder="Название вакансии" />
                            <asp:RequiredFieldValidator ID="NameCheck"  runat="server" CssClass="simple-text" ErrorMessage=" Необходимо указать название вакансии" ControlToValidate="Name"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-field">
                            <asp:TextBox ID="Responsibilities" CssClass="form-input" runat="server" placeholder="Обязанности" TextMode="MultiLine" Height="100px" />
                            <asp:RequiredFieldValidator ID="ResponsibilitiesCheck"  runat="server" CssClass="simple-text" ErrorMessage=" Необходимо указать обязанности" ControlToValidate="Responsibilities"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-field">
                            <asp:TextBox ID="Address" CssClass="form-input" runat="server" placeholder="Адрес" />
                            <asp:RequiredFieldValidator ID="AddressCheck"  CssClass="simple-text" ErrorMessage=" Необходимо указать адрес" runat="server" ControlToValidate="Address"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-field">
                            <asp:TextBox ID="JobExperience" CssClass="form-input" runat="server" placeholder="Опыт работы" />      
                        </div>
                        <div class="form-field">
                            <asp:TextBox ID="Salary" CssClass="form-input" runat="server" placeholder="Оклад" TextMode="Number" />
                            <asp:RequiredFieldValidator ID="SalaryCheck" CssClass="simple-text" ErrorMessage=" Необходимо указать оклад" runat="server" ControlToValidate="Salary"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-field">
                            <asp:TextBox ID="Desc" CssClass="form-input-description" runat="server" placeholder="Описание" TextMode="MultiLine" Height="100px" />
                        </div>
                    </div>
                    <div class="form-buttons">
                        <div class="form-visible-button">
                            <asp:CheckBox ID="isVisible" Text="Отображать" runat="server" Checked="true" />
                        </div>
                        <asp:LinkButton ID="LinkButton1" OnClick="LinkButton1_Click" runat="server" CssClass="f-button" Text="Добавить"></asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </main>
</asp:Content>

