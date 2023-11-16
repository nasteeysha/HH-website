<%@ Page Language="C#" Title="Удаление" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="OnlineShop.Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="/css/style-reg-form.css" />
    <main class="page">
        <div class="page__container _container">
            <div class="page__boxing">
                <div class="page__reg-form-container">
                    <h1 class="form-title">Вы точно хотите удалить модуль?</h1>
                    <div class="form-fields">
                        <div class="form-boxing">
                            <div class="form-field">
                                <asp:LinkButton ID="LinkButton1" CssClass="form-yes" runat="server" OnClick="LinkButton1_Click" Text="Да"></asp:LinkButton>
                            </div>
                            <div class="form-field">
                                <asp:LinkButton ID="no" CssClass="form-no" runat="server" OnClick="LinkButton2_Click" Text="Нет"></asp:LinkButton>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </main>
</asp:Content>

