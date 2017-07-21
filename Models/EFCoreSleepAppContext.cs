using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using SleepApp.Models;

namespace EFCoreSleepApp
{
    public class EFCoreSleepAppContext : DbContext
    {
        public DbSet<UserModel> UserModel {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=SleepApp.db");
        }
    }
}