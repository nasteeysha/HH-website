using OnlineShop.Models;
using OnlineShop.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop
{
    public partial class UserVacancies : System.Web.UI.Page
    {
        private Repository repository = new Repository();
        public IEnumerable<Vacancy> vacancies = new List<Vacancy>();

        protected void Page_Load(object sender, EventArgs e)
        {
            vacancies = repository.Vacancies.Where(Vacancy => Vacancy.UserId == Convert.ToInt32(this.Request.Cookies["id"].Value));
        }
    }
}