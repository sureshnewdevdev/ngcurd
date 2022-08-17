using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cards.API.Migrations
{
    public partial class fieldnamechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpiryMonty",
                table: "Cards",
                newName: "ExpiryMonth");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpiryMonth",
                table: "Cards",
                newName: "ExpiryMonty");
        }
    }
}
