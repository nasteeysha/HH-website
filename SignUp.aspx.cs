using OnlineShop.Models.Repository;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShop
{
    public partial class SignUp : System.Web.UI.Page
    {
        private Repository repository = new Repository();
        private IEnumerable<User> GetUsers = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            GetUsers = repository.Users;
            if (!this.IsPostBack)
            {
                admin.Checked = true;

                if (Cookies.CheckLogin(this))
                {
                    Response.Redirect("/mainpage");
                    return;
                }
            }
        }
        protected void RegistrationClick(object sender, EventArgs e)
        {
            string role = "user";
            if (admin.Checked)
                role = "admin";
            User user = new User();
            user.Password = Password.Text;
            user.Username = Username.Text;
            user.Role = role;
            user.Email = Email.Text;
            user.Birthday = DateTime.Parse(Birthday.Text);
            user.Number = Number.Text;
            user.Desc = Desc.Text;
            user.FName = FName.Text;
            user.LName =LName.Text;
            bool t = false;         
            foreach (User value in GetUsers)
            {
                if (value.Username == user.Username)
                    t = true;
            }
            if (t == true)
                Label1.Visible = true;
            else
            {
                repository.AddUser(user);
                //  ClientScript.RegisterClientScriptBlock(this.GetType(), "MessageBox", "alert('Good');", true);
                Response.Redirect("Login.aspx");
            }
        }

        protected void Changed(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }
    }
}