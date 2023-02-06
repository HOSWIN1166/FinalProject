using Microsoft.EntityFrameworkCore;
using Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OnlineShopDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=FinalProject;Integrated Security=True;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
