using Microsoft.EntityFrameworkCore.Migrations;

namespace CotoviaSite2.Data.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "ID",
                keyValue: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Utilizadores",
                columns: new[] { "ID", "Cargo", "Email", "Foto", "Nome" },
                values: new object[,]
                {
                    { 1, 0, "a2101@cotovia.pt", "C:/Imagens/A_Mendonca_A.jpg", "Álvaro Mendonça" },
                    { 2, 0, "a2004@cotovia.pt", "C:/Imagens/C_Domingues_A.jpg", "Cátia Domingues" },
                    { 3, 1, "a2003@cotovia.pt", "C:/Imagens/F_Lopes_A.jpg", "Francisco Lopes" },
                    { 4, 0, "a2002@cotovia.pt", "C:/Imagens/N_Faria_A.jpg", "Nuno Faria" },
                    { 5, 1, "a2001@cotovia.pt", "C:/Imagens/I_Pereira_A.jpg", "Inês Pereira" }
                });
        }
    }
}
