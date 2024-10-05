using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelRating.Migrations
{
    public partial class UpdateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Hotels",
                newName: "Address");

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_HotelId",
                table: "Questions",
                column: "HotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Hotels",
                newName: "Location");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Ratings",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
