using System;

namespace OnlineShop
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cookies.CheckLogin(this))
            {
                if (Cookies.Role(this) == "admin")
                    LinkButton1.Visible = false;
                else
                    LinkButton3.Visible = false;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (Cookies.CheckLogin(this))
                Response.Redirect("/editvacancy?vacancyId=-1");
            else
                Response.Redirect("/login");
        }
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            if (Cookies.CheckLogin(this))
                Response.Redirect("/vacancies");
            else
                Response.Redirect("/login");
        }
    }
}