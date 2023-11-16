using OnlineShop.Models;
using OnlineShop.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop
{
    public partial class Favorites : System.Web.UI.Page
    {
        private Repository repository = new Repository();
        public IEnumerable<Vacancy> vacancies = new List<Vacancy>();

        protected void Page_Load(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(this.Request.Cookies["id"].Value);
            vacancies = repository.FavoiriteVacancies(userId);
        }
    }
}