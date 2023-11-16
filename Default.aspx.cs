using OnlineShop.Models;
using OnlineShop.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShop
{
    public partial class _Default : Page
    {
        private Repository repository = new Repository();
        private Repository repository2 = new Repository();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Response.Redirect("/mainpage");
            return;
        }

    }
}