using OnlineShop.Models;
using OnlineShop.Models.Repository;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;

namespace OnlineShop
{
    public partial class _Logout : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie username = new HttpCookie("username", string.Empty);
            HttpCookie role = new HttpCookie("role", string.Empty);
            HttpCookie sign = new HttpCookie("sign", string.Empty);
            HttpCookie id = new HttpCookie("id", string.Empty);
            username.Expires = DateTime.Now.AddDays(-1);
            sign.Expires = DateTime.Now.AddDays(-1);
            id.Expires = DateTime.Now.AddDays(-1);
            role.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(username);
            Response.Cookies.Add(role);
            Response.Cookies.Add(sign);
            Response.Cookies.Add(id);
            Response.Redirect("MainPage.aspx");
        }
    }
}