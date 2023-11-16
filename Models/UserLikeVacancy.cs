namespace OnlineShop.Models
{
    public class UserLikeVacancy
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int VacancyId { get; set; }
    }
}