using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Condidature.Migrations
{
    /// <inheritdoc />
    public partial class fisrtMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    IdAdmin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomAdmin = table.Column<string>(type: "varchar(30)", nullable: false),
                    PrenomAdmin = table.Column<string>(type: "varchar(30)", nullable: false),
                    Email = table.Column<string>(type: "varchar(30)", nullable: false),
                    Password = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.IdAdmin);
                });

            migrationBuilder.CreateTable(
                name: "Condidats",
                columns: table => new
                {
                    IdCondidat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "varchar(30)", nullable: false),
                    Prenom = table.Column<string>(type: "varchar(30)", nullable: false),
                    Email = table.Column<string>(type: "varchar(30)", nullable: false),
                    Téléphone = table.Column<int>(type: "int", nullable: false),
                    Niveau = table.Column<string>(type: "varchar(10)", nullable: false),
                    expérience = table.Column<int>(type: "int", nullable: false),
                    employeur = table.Column<string>(type: "varchar(50)", nullable: false),
                    CV = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condidats", x => x.IdCondidat);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Condidats");
        }
    }
}
