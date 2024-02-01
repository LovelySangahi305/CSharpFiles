using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppl1_day21.Migrations
{
    /// <inheritdoc />
    public partial class addcoldate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Releasedate",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Releasedate",
                table: "Movies");
        }
    }
}
