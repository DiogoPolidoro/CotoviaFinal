using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CotoviaSite2.Models;

namespace CotoviaSite2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Utilizadores>().HasData(
               new Utilizadores { ID = 1, Nome = "Álvaro Mendonça", Email = "a2101@cotovia.pt", Foto = "C:/Imagens/A_Mendonca_A.jpg", Cargo = (Cargo)0},
               new Utilizadores { ID = 2, Nome = "Cátia Domingues", Email = "a2004@cotovia.pt", Foto = "C:/Imagens/C_Domingues_A.jpg", Cargo = (Cargo)0 },
               new Utilizadores { ID = 3, Nome = "Francisco Lopes", Email = "a2003@cotovia.pt", Foto = "C:/Imagens/F_Lopes_A.jpg", Cargo = (Cargo)1 },
               new Utilizadores { ID = 4, Nome = "Nuno Faria", Email = "a2002@cotovia.pt", Foto = "C:/Imagens/N_Faria_A.jpg", Cargo = (Cargo)0 },
               new Utilizadores { ID = 5, Nome = "Inês Pereira", Email = "a2001@cotovia.pt", Foto = "C:/Imagens/I_Pereira_A.jpg", Cargo = (Cargo)1 }
            );

            modelBuilder.Entity<Fotografias>().HasData(
               new Fotografias { ID = 1, Foto = "C:/Imagens/foto1", DataFoto = new DateTime(2021, 2, 9).Date, LocalFoto = "Tomar", Fotografo = "João Silva" },
               new Fotografias { ID = 2, Foto = "C:/Imagens/foto2", DataFoto = new DateTime(2021, 2, 9).Date, LocalFoto = "Leiria", Fotografo = "Maria dos Santos" },
               new Fotografias { ID = 3, Foto = "C:/Imagens/foto3", DataFoto = new DateTime(2021, 2, 9).Date, LocalFoto = "Coimbra", Fotografo = "Joana Lopes" },
               new Fotografias { ID = 4, Foto = "C:/Imagens/foto4", DataFoto = new DateTime(2021, 2, 9).Date, LocalFoto = "Aveiro", Fotografo = "Manuel Oliveira" },
               new Fotografias { ID = 5, Foto = "C:/Imagens/foto5", DataFoto = new DateTime(2021, 2, 9).Date, LocalFoto = "Tomar", Fotografo = "João Silva" },
               new Fotografias { ID = 6, Foto = "C:/Imagens/foto6", DataFoto = new DateTime(2021, 2, 9).Date, LocalFoto = "Tomar", Fotografo = "João Silva" },
               new Fotografias { ID = 7, Foto = "C:/Imagens/foto7", DataFoto = new DateTime(2021, 2, 9).Date, LocalFoto = "Lisboa", Fotografo = "Carolina Cunha" },
               new Fotografias { ID = 8, Foto = "C:/Imagens/foto8", DataFoto = new DateTime(2021, 2, 9).Date, LocalFoto = "Porto", Fotografo = "Francisco Rodrigues" },
               new Fotografias { ID = 9, Foto = "C:/Imagens/foto9", DataFoto = new DateTime(2021, 2, 9).Date, LocalFoto = "Porto", Fotografo = "Francisco Rodrigues" }
            );

            modelBuilder.Entity<Noticias>().HasData(
               new Noticias { ID = 1, Data = new DateTime(2021, 2, 9).Date, Titulo = "Titulo 1", Resumo = "Resumo 1", Conteudo = "Conteudo 1", Estado= (Estado)0,Tema= (Tema)0, AutorFK = 4, RevisorFK = 1 },
               new Noticias { ID = 2, Data = new DateTime(2021, 2, 10).Date, Titulo = "Titulo 2", Resumo = "Resumo 2", Conteudo = "Conteudo 2", Estado = (Estado)0, Tema = (Tema)4, AutorFK = 2, RevisorFK = 1 },
               new Noticias { ID = 3, Data = new DateTime(2021, 2, 12).Date, Titulo = "Titulo 3", Resumo = "Resumo 3", Conteudo = "Conteudo 3", Estado = (Estado)1, Tema = (Tema)2, AutorFK = 2, RevisorFK = 2 },
               new Noticias { ID = 4, Data = new DateTime(2021, 2, 12).Date, Titulo = "Titulo 4", Resumo = "Resumo 4", Conteudo = "Conteudo 4", Estado = (Estado)0, Tema = (Tema)6, AutorFK = 1, RevisorFK = 1 },
               new Noticias { ID = 5, Data = new DateTime(2021, 2, 13).Date, Titulo = "Titulo 5", Resumo = "Resumo 5", Conteudo = "Conteudo 5", Estado = (Estado)0, Tema = (Tema)1, AutorFK = 5, RevisorFK = 3 },
               new Noticias { ID = 6, Data = new DateTime(2021, 2, 15).Date, Titulo = "Titulo 6", Resumo = "Resumo 6", Conteudo = "Conteudo 6", Estado = (Estado)1, Tema = (Tema)3, AutorFK = 3, RevisorFK = 1 },
               new Noticias { ID = 7, Data = new DateTime(2021, 2, 16).Date, Titulo = "Titulo 7", Resumo = "Resumo 7", Conteudo = "Conteudo 7", Estado = (Estado)0, Tema = (Tema)5, AutorFK = 4, RevisorFK = 3 },
               new Noticias { ID = 8, Data = new DateTime(2021, 2, 20).Date, Titulo = "Titulo 8", Resumo = "Resumo 8", Conteudo = "Conteudo 8", Estado = (Estado)1, Tema = (Tema)2, AutorFK = 5, RevisorFK = 3 },
               new Noticias { ID = 9, Data = new DateTime(2021, 2, 23).Date, Titulo = "Titulo 9", Resumo = "Resumo 9", Conteudo = "Conteudo 9", Estado = (Estado)1, Tema = (Tema)7, AutorFK = 1, RevisorFK = 2 },
               new Noticias { ID = 10, Data = new DateTime(2021, 2, 25).Date, Titulo = "Titulo 10", Resumo = "Resumo 10", Conteudo = "Conteudo 10", Estado = (Estado)1, Tema = (Tema)8, AutorFK = 2, RevisorFK = 3 }
            );
            modelBuilder.Entity<FotosNoticias>().HasData(
                new FotosNoticias { FotoFK = 1, NoticiaFK = 1 },
                new FotosNoticias { FotoFK = 4, NoticiaFK = 2 },
                new FotosNoticias { FotoFK = 8, NoticiaFK = 3 },
                new FotosNoticias { FotoFK = 3, NoticiaFK = 4 },
                new FotosNoticias { FotoFK = 7, NoticiaFK = 5 },
                new FotosNoticias { FotoFK = 1, NoticiaFK = 6 },
                new FotosNoticias { FotoFK = 5, NoticiaFK = 7 },
                new FotosNoticias { FotoFK = 9, NoticiaFK = 8 },
                new FotosNoticias { FotoFK = 2, NoticiaFK = 9 },
                new FotosNoticias { FotoFK = 6, NoticiaFK = 10 }
                );
            modelBuilder.Entity<FotosNoticias>().HasKey(c => new { c.FotoFK, c.NoticiaFK });
        }
        public DbSet<CotoviaSite2.Models.Noticias> Noticias { get; set; }
        public DbSet<CotoviaSite2.Models.Fotografias> Fotografias { get; set; }
        public DbSet<CotoviaSite2.Models.Utilizadores> Utilizadores { get; set; }
    }
}
