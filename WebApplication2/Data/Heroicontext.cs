using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.moldes;
using System.Text;

namespace WebApplication2.Data
{
    public class Heroicontext : DbContext
    {
        public DbSet<Heroi> HErois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<IndentidadeSecreta> IndentidadeSecretas { get; set; }
        public DbSet<HeroiBatalha> HeroiBatalhas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HeroApp;Data Source=DESKTOP-BDE2IU1\\SQLEXPRESS");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(entity =>
            {
                entity.HasKey(e => new { e.BatalhaID, e.HeroiId });
            });


        }
    }
}