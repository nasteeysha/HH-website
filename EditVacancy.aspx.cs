using OnlineShop.Models;
using OnlineShop.Models.Repository;
using System;

namespace OnlineShop
{
    public partial class EditVacancy : System.Web.UI.Page
    {
        Repository repository = new Repository();
        Vacancy vacancy = null;
        int vacancyId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cookies.Role(this) == "admin")
            {
                int.TryParse(Request.QueryString["vacancyId"], out vacancyId);
                if (vacancyId != -1 && !this.IsPostBack)
                {
                    vacancy = repository.SelectVacancy(vacancyId);
                    if (vacancyId == 0 || vacancy == null)
                    {
                        Response.Redirect("/editvacancy?vacancyId=-1");
                        return;
                    }
                    Name.Text = vacancy.Name;
                    Responsibilities.Text = vacancy.Responsibilities;
                    Address.Text = vacancy.Address;
                    Desc.Text = vacancy.Desc;
                    JobExperience.Text = vacancy.JobExperience;
                    Salary.Text = vacancy.Salary.ToString();
                    bool visible = true;
                    if (vacancy.IsHide > 0)
                        visible = false;
                    isVisible.Checked = visible;
                    Label2.Text = "Изменить вакансию";
                    LinkButton1.Text = "Сохранить";
                }
            }
            else
                Response.Redirect("/vacancies");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
           
            if (vacancyId == -1 || vacancy == null)
            {
                vacancy = new Vacancy();
            }
            if (vacancy != null)
            {
                vacancy.UserId = Convert.ToInt32(this.Request.Cookies["id"].Value);
                vacancy.Responsibilities = Responsibilities.Text;
                vacancy.Name = Name.Text;
                vacancy.Address = Address.Text;
                if (JobExperience.Text != "")
                    vacancy.JobExperience = JobExperience.Text;
                else
                {
                    JobExperience.Text = "Не требуется";
                    vacancy.JobExperience = "Не требуется";
            }
                vacancy.Desc = Desc.Text;
                vacancy.Salary = Convert.ToInt32(Salary.Text);
                byte isHide = 1;
                if (isVisible.Checked)
                    isHide = 0;
                vacancy.IsHide = isHide;
                if (vacancyId == -1)
                    repository.AddVacancy(vacancy);
                else
                {
                    vacancy.Id = vacancyId;
                    repository.UpdateVacancy(vacancy);
                }
            }
            Response.Redirect("/uservacancies");
            return;
        }
    }
}