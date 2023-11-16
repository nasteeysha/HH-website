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
    public partial class Vacancies : System.Web.UI.Page
    {
        private Repository repository = new Repository();
        public IEnumerable<Vacancy> vacancies= new List<Vacancy>();
        private string str= "";
       
        protected void Page_Load(object sender, EventArgs e)
        {
            str = find.Text;
            vacancies = repository.VacanciesLikeStr(str);
        }
    }
}