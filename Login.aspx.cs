using OnlineShop.Models;
using OnlineShop.Models.Repository;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;

namespace OnlineShop
{ 
    public partial class Login : Page
    {
        private Repository repository = new Repository();
        private IEnumerable<User> GetUsers = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Cookies.CheckLogin(this))
            {
                Response.Redirect("MainPage.aspx");
                return;
            }
            GetUsers = repository.Users;
        }
        protected void Login_Click(object sender, EventArgs e)
        {
            User user = new User { Password = PasswordLogin.Text, Username = UserLogin.Text };
            bool t = false;
            foreach (User value in GetUsers)
            {
                if (value.Password == user.Password && value.Username == user.Username)
                {
                    t = true;
                    user = value;
                }
            }
            if (t == false)
            {
                Label1.Visible = true;
            }
            else
            {
                HttpCookie login = new HttpCookie("username", user.Username);
                HttpCookie sign = new HttpCookie("sign", Cookies.GetSign(user.Username + "secretCode" + user.Role + user.Id.ToString()));
                HttpCookie role = new HttpCookie("role", user.Role);
                HttpCookie id = new HttpCookie("id", user.Id.ToString());
                Response.Cookies.Add(login);
                Response.Cookies.Add(sign);
                Response.Cookies.Add(role);
                Response.Cookies.Add(id);
                Response.Redirect("MainPage.aspx");
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/SignUp");
            return;
        }

        protected void Changed(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }
    }
}