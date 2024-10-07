using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelRating.Persistance.EF.Migrations
{

    public partial class SeedHotelsAndRatings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Hotels",
                newName: "Location");

            migrationBuilder.AlterColumn<double>(
                name: "Score",
                table: "Ratings",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[] { 1, "Location A", "Hotel A" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[] { 2, "Location B", "Hotel B" });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Comment", "HotelId", "Score" },
                values: new object[] { 1, "Great experience!", 1, 4.5 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Comment", "HotelId", "Score" },
                values: new object[] { 2, "Nice stay!", 1, 4.0 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Comment", "HotelId", "Score" },
                values: new object[] { 3, "Average service.", 2, 3.5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Hotels",
                newName: "Address");

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "Ratings",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}

