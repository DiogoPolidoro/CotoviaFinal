using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using CotoviaSite2.Models;
using Microsoft.AspNetCore.Identity;

namespace CotoviaSite2.Data
{
    public class ApplicationUser : IdentityUser { 
        public string Nome { get; set; }
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(
               new IdentityRole { Id = "a", Name = "autor", NormalizedName = "AUTOR"},
               new IdentityRole { Id = "r", Name = "revisor", NormalizedName = "REVISOR"}
            );

            modelBuilder.Entity<Noticias>(n => {
                n.HasOne(campo => campo.Autor).WithMany(fk => fk.ListaNoticiasEscritas).HasForeignKey(fk => fk.AutorFK).OnDelete(DeleteBehavior.Restrict);
                n.HasOne(campo => campo.Revisor).WithMany(fk => fk.ListaNoticiasRevistas).HasForeignKey(fk => fk.RevisorFK).OnDelete(DeleteBehavior.Restrict);
            });
           
            modelBuilder.Entity<FotosNoticias>().HasKey(c => new { c.FotoFK, c.NoticiaFK });
        }
        public DbSet<CotoviaSite2.Models.Utilizadores> Utilizadores { get; set; }
        public DbSet<CotoviaSite2.Models.Noticias> Noticias { get; set; }
        public DbSet<CotoviaSite2.Models.Fotografias> Fotografias { get; set; }
        public DbSet<FotosNoticias> FotosNoticias { get; set; }
    }
}
