using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanTrack.Migrations.Supplies
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Supplies",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    OutOf = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplies", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "Supplies",
                columns: new[] { "Name", "OutOf" },
                values: new object[,]
                {
                    { "Trash Bags", false },
                    { "Mopping Solution", false },
                    { "Hand Towels", false },
                    { "Paper Towles", false },
                    { "Duster Replacements", false },
                    { "Window Cleaner", false },
                    { "Pumice Stone", false },
                    { "Toilet Bowl Cleaner", false },
                    { "All Purpose Cleaner", false },
                    { "Mop", false },
                    { "Dust Mop", false },
                    { "Vacuum", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Supplies");
        }
    }
}
