using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace OnlineShop.Models.Repository
{
    public class Repository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<User> Users
        {
            get { return context.Users; }
        }
        public IEnumerable<Vacancy> Vacancies
        {
            get { return context.Vacancies.OrderByDescending(Vacancy=> Vacancy.Id); }
        }
        public IEnumerable<Vacancy> VacanciesLikeStr(string str)
        {
            List<Vacancy> vacancies = new List<Vacancy>();
            foreach(Vacancy vacancy in context.Vacancies.Where(vacancy => vacancy.IsHide==0).OrderByDescending(Vacancy => Vacancy.Id))
            {
                if(vacancy.Name.ToLower().Contains(str.ToLower()))
                   vacancies.Add(vacancy);
            }
            return vacancies;
        }
        public int CountUserFavoirite(int vacancyId)
        {
            return context.UserLikeVacancies.Where(UserLikeVacancy=> UserLikeVacancy.VacancyId==vacancyId).Count();
        }
        public IEnumerable<UserLikeVacancy> UserLikeVacancies
        {
            get { return context.UserLikeVacancies; }
        }
        public void AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
        public void AddVacancy(Vacancy user)
        {
            context.Vacancies.Add(user);
            context.SaveChangesAsync();
        }
        public void AddUserLikeVacancy(UserLikeVacancy user)
        {
            context.UserLikeVacancies.Add(user);
            context.SaveChangesAsync();
        }
        public User SelectUser(int id)
        {
            return context.Users.Find(id);
        }
        public Vacancy SelectVacancy(int id)
        {
            return context.Vacancies.Find(id);
        }
        public UserLikeVacancy SelectUserLikeVacancy(int id)
        {
            return context.UserLikeVacancies.Find(id);
        }
        public UserLikeVacancy SelectUserLikeVacancy(int VacancyId, int UserId)
        {
            return context.UserLikeVacancies.Where(UserLikeVacancies => UserLikeVacancies.VacancyId == VacancyId && UserLikeVacancies.UserId == UserId).FirstOrDefault();
        }
        public void DeleteUserLikeVacancy(int id)
        {
            context.UserLikeVacancies.Remove(SelectUserLikeVacancy(id));
            context.SaveChangesAsync();
        }
        public void DeleteVacancy(int id)
        {
            context.UserLikeVacancies.Remove(SelectUserLikeVacancy(id));
            context.SaveChangesAsync();
        }
        public void UpdateUser(User user)
        {

            User localArticle = SelectUser(user.Id);
            context.Entry(localArticle).CurrentValues.SetValues(user);
            context.Entry(localArticle).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void UpdateVacancy(Vacancy vacancy)
        {

            Vacancy localArticle = SelectVacancy(vacancy.Id);
            context.Entry(localArticle).CurrentValues.SetValues(vacancy);
            context.Entry(localArticle).State = EntityState.Modified;
            context.SaveChanges();
        }
        public bool IsOwner(int vacancyId, int UserId)
        {
            bool isOwner = false;
            Vacancy vacancy = SelectVacancy(vacancyId);
            if (vacancy != null)
            {
                if (vacancy.UserId == UserId)
                    isOwner = true;
            }
            return isOwner;
        }
        public bool IsFavorite(int vacancyId, int UserId)
        {

            UserLikeVacancy userLikeVacancy = context.UserLikeVacancies.Where(Favorite => Favorite.UserId == UserId && Favorite.VacancyId == vacancyId).FirstOrDefault();
            if (userLikeVacancy != null)
                return true;
            else
                return false;
        }
        public IEnumerable<Vacancy> FavoiriteVacancies(int UserId)
        {
            List<Vacancy> vacancies = new List<Vacancy>();
            EFDbContext context2 = new EFDbContext();
            var userLikeVacancies = context2.UserLikeVacancies.Where(UserLikeVacancy => UserLikeVacancy.UserId == UserId);
            foreach (UserLikeVacancy userLikeVacancy in userLikeVacancies)
            {
                vacancies.Add(SelectVacancy(userLikeVacancy.VacancyId));
            }
            return vacancies;
        }
    }
}