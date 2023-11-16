using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShop
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Page.Title != "Авторизация" && this.Page.Title != "Регистрация" && Page.Title != "Главная")
                Cookies.CheckLoginAndRedirectToMain(this.Page);
        }
        protected string Role()
        {
            return Cookies.Role(this.Page);
        }
    }
}