using Microsoft.EntityFrameworkCore.Migrations;

namespace JRShop.Infra.Migrations
{
    public partial class JRShop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id_Usuario = table.Column<string>(type: "Varchar(40)", nullable: false),
                    Nome_Usuario = table.Column<string>(type: "varchar(40)", nullable: false),
                    Email_Usuario = table.Column<string>(type: "varchar(40)", nullable: false),
                    Senha_Usuario = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id_Usuario);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
