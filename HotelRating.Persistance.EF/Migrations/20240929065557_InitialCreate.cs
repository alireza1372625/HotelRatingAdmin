using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelRating.Persistance.EF.Migrations;

public partial class InitialCreate : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Hotels",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Hotels", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Ratings",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Score = table.Column<int>(type: "int", nullable: false),
                Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                HotelId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Ratings", x => x.Id);
                table.ForeignKey(
                    name: "FK_Ratings_Hotels_HotelId",
                    column: x => x.HotelId,
                    principalTable: "Hotels",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_Ratings_HotelId",
            table: "Ratings",
            column: "HotelId");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Ratings");

        migrationBuilder.DropTable(
            name: "Hotels");
    }
}
