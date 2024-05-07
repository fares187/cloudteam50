using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mesterdoc.Migrations
{
    /// <inheritdoc />
    public partial class cgpa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CGPA",
                table: "Members",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CGPA",
                table: "Members");
        }
    }
}
