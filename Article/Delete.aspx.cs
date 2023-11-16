using OnlineShop.Models;
using OnlineShop.Models.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;

namespace OnlineShop
{
    public partial class _Delete : Page
    {/*
        private int articleId = 0;
        private Repository repository = new Repository();
        private Article article = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            int.TryParse(Request.QueryString["id"], out articleId);
            article = repository.SelectArticle(articleId);
            if (Cookies.Role(this) == "user" || articleId == 0 || article == null)
            {
                Response.Redirect("~/Default.aspx");
                return;
            }
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            repository.DeleteArticle(articleId);
            Response.Redirect("~/Default.aspx");
        }

        protected void button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }*/
    }
}