using OnlineShop.Models;
using OnlineShop.Models.Repository;
using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop
{
    public partial class ShowVacancy : System.Web.UI.Page
    {
        Repository repository = new Repository();
        public Models.Vacancy vacancy;
        int vacancyId = 0;
        User UserOwner = null;
        public string phone = "";
        public string mail = "";
        public bool isOwner;
        public int countUserLikeVacancy = 0;
        public bool isFavoirite;

        protected void Page_Load(object sender, EventArgs e)
        {
            int.TryParse(Request.QueryString["id"], out vacancyId);
            vacancy = repository.SelectVacancy(vacancyId);
            if (vacancyId == 0 || vacancy == null)
            {
                Response.Redirect("/vacancies");
                return;
            }
            int userId = Convert.ToInt32(this.Request.Cookies["id"].Value);
            UserOwner = repository.SelectUser(vacancy.UserId);
            if(UserOwner!=null)
            {
                mail = UserOwner.Email;
                phone = UserOwner.Number;
            }
            countUserLikeVacancy = repository.CountUserFavoirite(vacancyId);
            Desc.Text = vacancy.Desc;
            Responsibilities.Text = vacancy.Responsibilities;
            isOwner = repository.IsOwner(vacancy.Id, userId);
            isFavoirite = repository.IsFavorite(vacancy.Id, userId);
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {

        }
    }
}