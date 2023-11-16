using OnlineShop.Models;
using OnlineShop.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop
{
    public partial class Profile : System.Web.UI.Page
    {
        public User user = new User();
        public bool adminCheck = false;
        private Repository repository = new Repository();
        private Repository repository2 = new Repository();
        private Repository repository3 = new Repository();
        private Repository repository5 = new Repository();
        private Repository repository4 = new Repository();
        protected void Page_Load(object sender, EventArgs e)
        {                        
                user = repository.SelectUser(System.Convert.ToInt32(this.Request.Cookies["id"].Value));
                if (user == null)
                    Response.Redirect("Logout.aspx");
            Desc.Text = user.Desc;
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/useredit");
            return;
        }
    }
}