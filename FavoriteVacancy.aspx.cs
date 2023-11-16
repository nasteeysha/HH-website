using OnlineShop.Models;
using OnlineShop.Models.Repository;
using System;

namespace OnlineShop
{
    public partial class FavoriteVacancy : System.Web.UI.Page
    {
        Repository repository = new Repository();
        public Models.Vacancy vacancy;
        int vacancyId = 0;


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
            UserLikeVacancy userLikeVacancy = repository.SelectUserLikeVacancy(vacancyId, userId);
            if (userLikeVacancy != null)
            {
                repository.DeleteUserLikeVacancy(userLikeVacancy.Id);
            }
            else
            {
                userLikeVacancy = new UserLikeVacancy();
                userLikeVacancy.UserId = userId;
                userLikeVacancy.VacancyId = vacancyId;
                repository.AddUserLikeVacancy(userLikeVacancy);
                Response.Redirect("/showvacancy?id=" + vacancyId);
            }
            return;
        }
    }
}