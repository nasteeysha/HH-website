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
    public partial class UserEdit : System.Web.UI.Page
    {
        private Repository repository = new Repository();
        private Repository repository2 = new Repository();
        private IEnumerable<User> GetUsers = null;
        protected void Page_Load(object sender, EventArgs e)
        {   
            Label1.Visible = false;
            GetUsers = repository.Users;
            User user = repository2.SelectUser(Cookies.GetUserId(this));
            if (!this.IsPostBack)
            {
                Username.Text = user.Username;
                LName.Text = user.LName;
                FName.Text = user.FName;
                Desc.Text = user.Desc;
                Email.Text = user.Email;
                Birthday.Text = user.Birthday.ToString("yyyy-MM-dd");
                Number.Text = user.Number;
                Password.Text = user.Password;
            }
        }
        protected void RegistrationClick(object sender, EventArgs e)
        {
            string role = Cookies.Role(this);
            User user = new User { Password = Password.Text,
                Username = Username.Text,
                Role = role, Number=Number.Text,
                Birthday = DateTime.Parse(Birthday.Text),
                Desc = Desc.Text, Email = Email.Text,
                FName=FName.Text,LName=LName.Text, 
                Id = Cookies.GetUserId(this) };
            bool t = false;
            foreach (User value in GetUsers)
            {
                if (value.Username == user.Username && value.Id!=user.Id)
                    t = true;
            }
            if (t == true)
                Label1.Visible = true;
            else
            {
                repository.UpdateUser(user);
                //  ClientScript.RegisterClientScriptBlock(this.GetType(), "MessageBox", "alert('Good');", true);
                Response.Redirect("Profile.aspx");
            }
        }

        protected void Changed(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }
    }
}