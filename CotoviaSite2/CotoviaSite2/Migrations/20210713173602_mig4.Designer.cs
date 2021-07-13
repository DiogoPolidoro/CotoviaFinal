﻿// <auto-generated />
using System;
using CotoviaSite2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CotoviaSite2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210713173602_mig4")]
    partial class mig4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CotoviaSite2.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CotoviaSite2.Models.Fotografias", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataFoto")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fotografo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalFoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Fotografias");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DataFoto = new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "C:/Imagens/foto1",
                            Fotografo = "João Silva",
                            LocalFoto = "Tomar",
                            NomeFoto = "Foto1"
                        },
                        new
                        {
                            ID = 2,
                            DataFoto = new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "C:/Imagens/foto2",
                            Fotografo = "Maria dos Santos",
                            LocalFoto = "Leiria",
                            NomeFoto = "Foto2"
                        },
                        new
                        {
                            ID = 3,
                            DataFoto = new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "C:/Imagens/foto3",
                            Fotografo = "Joana Lopes",
                            LocalFoto = "Coimbra",
                            NomeFoto = "Foto3"
                        },
                        new
                        {
                            ID = 4,
                            DataFoto = new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "C:/Imagens/foto4",
                            Fotografo = "Manuel Oliveira",
                            LocalFoto = "Aveiro",
                            NomeFoto = "Foto4"
                        },
                        new
                        {
                            ID = 5,
                            DataFoto = new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "C:/Imagens/foto5",
                            Fotografo = "João Silva",
                            LocalFoto = "Tomar",
                            NomeFoto = "Foto5"
                        },
                        new
                        {
                            ID = 6,
                            DataFoto = new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "C:/Imagens/foto6",
                            Fotografo = "João Silva",
                            LocalFoto = "Tomar",
                            NomeFoto = "Foto6"
                        },
                        new
                        {
                            ID = 7,
                            DataFoto = new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "C:/Imagens/foto7",
                            Fotografo = "Carolina Cunha",
                            LocalFoto = "Lisboa",
                            NomeFoto = "Foto7"
                        },
                        new
                        {
                            ID = 8,
                            DataFoto = new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "C:/Imagens/foto8",
                            Fotografo = "Francisco Rodrigues",
                            LocalFoto = "Porto",
                            NomeFoto = "Foto8"
                        },
                        new
                        {
                            ID = 9,
                            DataFoto = new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "C:/Imagens/foto9",
                            Fotografo = "Francisco Rodrigues",
                            LocalFoto = "Porto",
                            NomeFoto = "Foto9"
                        });
                });

            modelBuilder.Entity("CotoviaSite2.Models.FotosNoticias", b =>
                {
                    b.Property<int>("FotoFK")
                        .HasColumnType("int");

                    b.Property<int>("NoticiaFK")
                        .HasColumnType("int");

                    b.HasKey("FotoFK", "NoticiaFK");

                    b.HasIndex("NoticiaFK");

                    b.ToTable("FotosNoticias");

                    b.HasData(
                        new
                        {
                            FotoFK = 1,
                            NoticiaFK = 1
                        },
                        new
                        {
                            FotoFK = 4,
                            NoticiaFK = 2
                        },
                        new
                        {
                            FotoFK = 8,
                            NoticiaFK = 3
                        },
                        new
                        {
                            FotoFK = 3,
                            NoticiaFK = 4
                        },
                        new
                        {
                            FotoFK = 7,
                            NoticiaFK = 5
                        },
                        new
                        {
                            FotoFK = 1,
                            NoticiaFK = 6
                        },
                        new
                        {
                            FotoFK = 5,
                            NoticiaFK = 7
                        },
                        new
                        {
                            FotoFK = 9,
                            NoticiaFK = 8
                        },
                        new
                        {
                            FotoFK = 2,
                            NoticiaFK = 9
                        },
                        new
                        {
                            FotoFK = 6,
                            NoticiaFK = 10
                        });
                });

            modelBuilder.Entity("CotoviaSite2.Models.Noticias", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutorFK")
                        .HasColumnType("int");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Resumo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RevisorFK")
                        .HasColumnType("int");

                    b.Property<int>("Tema")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AutorFK");

                    b.HasIndex("RevisorFK");

                    b.ToTable("Noticias");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AutorFK = 4,
                            Conteudo = "Conteudo 1",
                            Data = new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = 0,
                            Resumo = "Resumo 1",
                            RevisorFK = 1,
                            Tema = 0,
                            Titulo = "Titulo 1"
                        },
                        new
                        {
                            ID = 2,
                            AutorFK = 2,
                            Conteudo = "Conteudo 2",
                            Data = new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = 0,
                            Resumo = "Resumo 2",
                            RevisorFK = 1,
                            Tema = 4,
                            Titulo = "Titulo 2"
                        },
                        new
                        {
                            ID = 3,
                            AutorFK = 2,
                            Conteudo = "Conteudo 3",
                            Data = new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = 1,
                            Resumo = "Resumo 3",
                            RevisorFK = 2,
                            Tema = 2,
                            Titulo = "Titulo 3"
                        },
                        new
                        {
                            ID = 4,
                            AutorFK = 1,
                            Conteudo = "Conteudo 4",
                            Data = new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = 0,
                            Resumo = "Resumo 4",
                            RevisorFK = 1,
                            Tema = 6,
                            Titulo = "Titulo 4"
                        },
                        new
                        {
                            ID = 5,
                            AutorFK = 5,
                            Conteudo = "Conteudo 5",
                            Data = new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = 0,
                            Resumo = "Resumo 5",
                            RevisorFK = 3,
                            Tema = 1,
                            Titulo = "Titulo 5"
                        },
                        new
                        {
                            ID = 6,
                            AutorFK = 3,
                            Conteudo = "Conteudo 6",
                            Data = new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = 1,
                            Resumo = "Resumo 6",
                            RevisorFK = 1,
                            Tema = 3,
                            Titulo = "Titulo 6"
                        },
                        new
                        {
                            ID = 7,
                            AutorFK = 4,
                            Conteudo = "Conteudo 7",
                            Data = new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = 0,
                            Resumo = "Resumo 7",
                            RevisorFK = 3,
                            Tema = 5,
                            Titulo = "Titulo 7"
                        },
                        new
                        {
                            ID = 8,
                            AutorFK = 5,
                            Conteudo = "Conteudo 8",
                            Data = new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = 1,
                            Resumo = "Resumo 8",
                            RevisorFK = 3,
                            Tema = 2,
                            Titulo = "Titulo 8"
                        },
                        new
                        {
                            ID = 9,
                            AutorFK = 1,
                            Conteudo = "Conteudo 9",
                            Data = new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = 1,
                            Resumo = "Resumo 9",
                            RevisorFK = 2,
                            Tema = 7,
                            Titulo = "Titulo 9"
                        },
                        new
                        {
                            ID = 10,
                            AutorFK = 2,
                            Conteudo = "Conteudo 10",
                            Data = new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = 1,
                            Resumo = "Resumo 10",
                            RevisorFK = 3,
                            Tema = 8,
                            Titulo = "Titulo 10"
                        });
                });

            modelBuilder.Entity("CotoviaSite2.Models.Utilizadores", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cargo")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Utilizadores");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Cargo = 0,
                            Email = "a2000@cotovia.pt",
                            Foto = "C:/Imagens/foto1",
                            Nome = "António Maria"
                        },
                        new
                        {
                            ID = 2,
                            Cargo = 1,
                            Email = "r2000@cotovia.pt",
                            Foto = "C:/Imagens/foto2",
                            Nome = "Manuel Lopes"
                        },
                        new
                        {
                            ID = 3,
                            Cargo = 1,
                            Email = "r2001@cotovia.pt",
                            Foto = "C:/Imagens/foto3",
                            Nome = "Raquel Andrade"
                        },
                        new
                        {
                            ID = 4,
                            Cargo = 1,
                            Email = "r2002@cotovia.pt",
                            Foto = "C:/Imagens/foto4",
                            Nome = "Ana Gomes"
                        },
                        new
                        {
                            ID = 5,
                            Cargo = 0,
                            Email = "a2001@cotovia.pt",
                            Foto = "C:/Imagens/foto5",
                            Nome = "João Maria"
                        },
                        new
                        {
                            ID = 6,
                            Cargo = 0,
                            Email = "a2002@cotovia.pt",
                            Foto = "C:/Imagens/foto6",
                            Nome = "Carlos Pinha"
                        },
                        new
                        {
                            ID = 7,
                            Cargo = 1,
                            Email = "r2003@cotovia.pt",
                            Foto = "C:/Imagens/foto7",
                            Nome = "Maria Antónia"
                        },
                        new
                        {
                            ID = 8,
                            Cargo = 0,
                            Email = "a2003@cotovia.pt",
                            Foto = "C:/Imagens/foto8",
                            Nome = "Giselle Marie"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CotoviaSite2.Models.FotosNoticias", b =>
                {
                    b.HasOne("CotoviaSite2.Models.Fotografias", "Fotografias")
                        .WithMany("ListaNoticias")
                        .HasForeignKey("FotoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CotoviaSite2.Models.Noticias", "Noticia")
                        .WithMany("ListaFotografias")
                        .HasForeignKey("NoticiaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fotografias");

                    b.Navigation("Noticia");
                });

            modelBuilder.Entity("CotoviaSite2.Models.Noticias", b =>
                {
                    b.HasOne("CotoviaSite2.Models.Utilizadores", "Autor")
                        .WithMany("ListaNoticiasEscritas")
                        .HasForeignKey("AutorFK")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CotoviaSite2.Models.Utilizadores", "Revisor")
                        .WithMany("ListaNoticiasRevistas")
                        .HasForeignKey("RevisorFK")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Autor");

                    b.Navigation("Revisor");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CotoviaSite2.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CotoviaSite2.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CotoviaSite2.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CotoviaSite2.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CotoviaSite2.Models.Fotografias", b =>
                {
                    b.Navigation("ListaNoticias");
                });

            modelBuilder.Entity("CotoviaSite2.Models.Noticias", b =>
                {
                    b.Navigation("ListaFotografias");
                });

            modelBuilder.Entity("CotoviaSite2.Models.Utilizadores", b =>
                {
                    b.Navigation("ListaNoticiasEscritas");

                    b.Navigation("ListaNoticiasRevistas");
                });
#pragma warning restore 612, 618
        }
    }
}
