using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jeanstackapi.Migrations
{
    /// <inheritdoc />
    public partial class databaseupdatedd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "orders",
                newName: "userId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "userId",
                table: "orders",
                newName: "UserId");
        }
    }
}
