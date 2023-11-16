namespace OnlineShop.Models
{
    public class Vacancy
    {
      public  Vacancy()
        {
            IsHide = 0;
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Responsibilities { get; set; }
        public string Address { get; set; }
        public string JobExperience { get; set; }
        public string Desc { get; set; }
        public byte IsHide { get; set; }
    }
}