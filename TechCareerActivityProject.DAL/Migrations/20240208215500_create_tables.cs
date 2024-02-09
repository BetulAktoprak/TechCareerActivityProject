using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechCareerActivityProject.DAL.Migrations
{
    public partial class create_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Concerts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConcertName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcertType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcertLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcertImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcertDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcertTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concerts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exhibitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExhibitionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExhibitionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExhibitionLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExhibitionImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExhibitionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExhibitionTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exhibitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Festivals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FestivalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FestivalType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FestivalLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FestivalImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FestivalDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FestivalTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Festivals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Concerts");

            migrationBuilder.DropTable(
                name: "Exhibitions");

            migrationBuilder.DropTable(
                name: "Festivals");

            migrationBuilder.DropTable(
                name: "Stages");
        }
    }
}
