using OnlineShop.Models;
using OnlineShop.Models.Repository;
using System;
using System.Web.UI;

namespace OnlineShop
{
    public partial class _Edit : Page
    {/*
        private int articleId;
        private Repository repository = new Repository();
        private Article article;
        protected void Page_Load(object sender, EventArgs e)
        {

            int.TryParse(Request.QueryString["id"], out articleId);
            article = repository.SelectArticle(articleId);
            if (Cookies.Role(this) == "user" || articleId == 0 || article == null)
            {
                Response.Redirect("~/Default.aspx");
                return;
            }
            if (!this.IsPostBack)
            {
                nameProduct.Text = article.Name;
                descProduct.Text = article.Desc;
            }
        }
        protected void button1_Click(object sender, EventArgs e)
        {
            string name = nameProduct.Text.ToString();
            Article product = new Article { Id = articleId, Name = name, Desc = descProduct.Text.ToString()};
            repository.UpdateArticle(product);
            Response.Redirect("~/Default.aspx");
        }*/
    }
}