using OnlineShop.Models;
using OnlineShop.Models.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;

namespace OnlineShop
{
    public partial class _Read : Page
    {/*
        private Repository repository = new Repository();
        private Article article = null;
        private int articleId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            int.TryParse(Request.QueryString["id"], out articleId);
            article = repository.SelectArticle(articleId);
            if (Cookies.Role(this) == "user" || articleId == 0 || article == null)
            {
                Response.Redirect("~/Default.aspx");
                return;
            }
            nameProduct.Text = article.Name;
            descProduct.Text = article.Desc;
            priceProduct.Text = repository.RatingArticle(articleId).ToString() + "☆";
        }*/
    }
}