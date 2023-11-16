using OnlineShop.Models.Repository;
using System;

namespace OnlineShop
{
    public partial class Delete : System.Web.UI.Page
    {
        Repository repository = new Repository();
        int vacancyId;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (int.TryParse(Request.QueryString["vacancyId"], out vacancyId))
            {
                if (!repository.IsOwner(vacancyId, Convert.ToInt32(Request.Cookies["id"].Value)))
                    Response.Redirect("/vacancies");
            }
            else Response.Redirect("/vacancies");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            repository.DeleteVacancy(vacancyId);

        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/showVacancy?vacancyId=" + vacancyId);
        }
    }
}