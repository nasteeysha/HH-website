using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace OnlineShop.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<UserLikeVacancy> UserLikeVacancies { get; set; }
     
    }
}