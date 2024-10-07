using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelRating.Persistance.EF.Migrations;

public partial class SeedData : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.InsertData(
            table: "Hotels",
            columns: new[] { "Id", "Address", "Name" },
            values: new object[] { 1, "Address A", "Hotel A" });

        migrationBuilder.InsertData(
            table: "Hotels",
            columns: new[] { "Id", "Address", "Name" },
            values: new object[] { 2, "Address B", "Hotel B" });

        migrationBuilder.InsertData(
            table: "Questions",
            columns: new[] { "Id", "HotelId", "Text", "Type" },
            values: new object[,]
            {
                    { 1, 1, "How would you rate the cleanliness?", "Rating" },
                    { 2, 1, "Was the staff friendly?", "YesNo" },
                    { 3, 1, "Any comments about your stay?", "OpenEnded" },
                    { 4, 2, "How would you rate the service?", "Rating" },
                    { 5, 2, "Would you recommend this hotel?", "YesNo" }
            });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData(
            table: "Questions",
            keyColumn: "Id",
            keyValue: 1);

        migrationBuilder.DeleteData(
            table: "Questions",
            keyColumn: "Id",
            keyValue: 2);

        migrationBuilder.DeleteData(
            table: "Questions",
            keyColumn: "Id",
            keyValue: 3);

        migrationBuilder.DeleteData(
            table: "Questions",
            keyColumn: "Id",
            keyValue: 4);

        migrationBuilder.DeleteData(
            table: "Questions",
            keyColumn: "Id",
            keyValue: 5);

        migrationBuilder.DeleteData(
            table: "Hotels",
            keyColumn: "Id",
            keyValue: 1);

        migrationBuilder.DeleteData(
            table: "Hotels",
            keyColumn: "Id",
            keyValue: 2);
    }
}

