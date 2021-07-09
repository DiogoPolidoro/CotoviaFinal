using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CotoviaSite2.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fotografias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataFoto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocalFoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fotografo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotografias", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Utilizadores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cargo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizadores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Noticias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resumo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conteudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tema = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    AutorFK = table.Column<int>(type: "int", nullable: false),
                    RevisorFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticias", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Noticias_Utilizadores_AutorFK",
                        column: x => x.AutorFK,
                        principalTable: "Utilizadores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Noticias_Utilizadores_RevisorFK",
                        column: x => x.RevisorFK,
                        principalTable: "Utilizadores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FotosNoticias",
                columns: table => new
                {
                    FotoFK = table.Column<int>(type: "int", nullable: false),
                    NoticiaFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotosNoticias", x => new { x.FotoFK, x.NoticiaFK });
                    table.ForeignKey(
                        name: "FK_FotosNoticias_Fotografias_FotoFK",
                        column: x => x.FotoFK,
                        principalTable: "Fotografias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FotosNoticias_Noticias_NoticiaFK",
                        column: x => x.NoticiaFK,
                        principalTable: "Noticias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Fotografias",
                columns: new[] { "ID", "DataFoto", "Foto", "Fotografo", "LocalFoto" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto1", "João Silva", "Tomar" },
                    { 8, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto8", "Francisco Rodrigues", "Porto" },
                    { 7, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto7", "Carolina Cunha", "Lisboa" },
                    { 6, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto6", "João Silva", "Tomar" },
                    { 9, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto9", "Francisco Rodrigues", "Porto" },
                    { 4, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto4", "Manuel Oliveira", "Aveiro" },
                    { 3, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto3", "Joana Lopes", "Coimbra" },
                    { 2, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto2", "Maria dos Santos", "Leiria" },
                    { 5, new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "C:/Imagens/foto5", "João Silva", "Tomar" }
                });

            migrationBuilder.InsertData(
                table: "Utilizadores",
                columns: new[] { "ID", "Cargo", "Email", "Foto", "Nome", "UserID" },
                values: new object[,]
                {
                    { 7, 1, "r2003@cotovia.pt", "C:/Imagens/foto7", "Maria Antónia", null },
                    { 1, 0, "a2000@cotovia.pt", "C:/Imagens/foto1", "António Maria", null },
                    { 2, 1, "r2000@cotovia.pt", "C:/Imagens/foto2", "Manuel Lopes", null },
                    { 3, 1, "r2001@cotovia.pt", "C:/Imagens/foto3", "Raquel Andrade", null },
                    { 4, 1, "r2002@cotovia.pt", "C:/Imagens/foto4", "Ana Gomes", null },
                    { 5, 0, "a2001@cotovia.pt", "C:/Imagens/foto5", "João Maria", null },
                    { 6, 0, "a2002@cotovia.pt", "C:/Imagens/foto6", "Carlos Pinha", null },
                    { 8, 0, "a2003@cotovia.pt", "C:/Imagens/foto8", "Giselle Marie", null }
                });

            migrationBuilder.InsertData(
                table: "Noticias",
                columns: new[] { "ID", "AutorFK", "Conteudo", "Data", "Estado", "Resumo", "RevisorFK", "Tema", "Titulo" },
                values: new object[,]
                {
                    { 4, 1, "Conteudo 4", new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 4", 1, 6, "Titulo 4" },
                    { 2, 2, "Conteudo 2", new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 2", 1, 4, "Titulo 2" },
                    { 3, 2, "Conteudo 3", new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Resumo 3", 2, 2, "Titulo 3" },
                    { 9, 1, "Conteudo 9", new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Resumo 9", 2, 7, "Titulo 9" },
                    { 6, 3, "Conteudo 6", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Resumo 6", 1, 3, "Titulo 6" },
                    { 10, 2, "Conteudo 10", new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Resumo 10", 3, 8, "Titulo 10" },
                    { 1, 4, "Conteudo 1", new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 1", 1, 0, "Titulo 1" },
                    { 7, 4, "Conteudo 7", new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 7", 3, 5, "Titulo 7" },
                    { 5, 5, "Conteudo 5", new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Resumo 5", 3, 1, "Titulo 5" },
                    { 8, 5, "Conteudo 8", new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Resumo 8", 3, 2, "Titulo 8" }
                });

            migrationBuilder.InsertData(
                table: "FotosNoticias",
                columns: new[] { "FotoFK", "NoticiaFK" },
                values: new object[,]
                {
                    { 3, 4 },
                    { 4, 2 },
                    { 8, 3 },
                    { 2, 9 },
                    { 1, 6 },
                    { 6, 10 },
                    { 1, 1 },
                    { 5, 7 },
                    { 7, 5 },
                    { 9, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FotosNoticias_NoticiaFK",
                table: "FotosNoticias",
                column: "NoticiaFK");

            migrationBuilder.CreateIndex(
                name: "IX_Noticias_AutorFK",
                table: "Noticias",
                column: "AutorFK");

            migrationBuilder.CreateIndex(
                name: "IX_Noticias_RevisorFK",
                table: "Noticias",
                column: "RevisorFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FotosNoticias");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Fotografias");

            migrationBuilder.DropTable(
                name: "Noticias");

            migrationBuilder.DropTable(
                name: "Utilizadores");
        }
    }
}
