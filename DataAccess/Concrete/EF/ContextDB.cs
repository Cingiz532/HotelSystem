using Entitties.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EF
{
    public class ContextDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=CINGIZ\MSSQLSERVER01;Database=HotelSystem;Trusted_Connection=true;TrustServerCertificate=true");
        }
        DbSet<Product> Products { get; set; }
        DbSet<Assistant> Assistants { get; set; }
    }
}
