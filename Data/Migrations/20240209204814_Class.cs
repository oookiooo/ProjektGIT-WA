using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Data.Migrations
{
    public partial class Class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Cards",
               columns: table => new
               {
                   CardId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                   NameCard = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                   Cost = table.Column<int>(type: "int", nullable: true),
                   AttackDamage = table.Column<int>(type: "int", nullable: true),
                   Hp = table.Column<int>(type: "int", nullable: true)

               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Cards_Users1Tokens", x => new { x.CardId });

               });
            migrationBuilder.CreateTable(
               name: "Cards_Users",
               columns: table => new
               {
                   CardsUsersId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                   CardId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                   Id = table.Column<string>(type: "nvarchar(450)", nullable: false)

               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Cards_UsersTokens", x => new { x.CardId });
                   table.ForeignKey(
                       name: "FK_AspNetUserTokens_AspNetUsers_UserId12",
                       column: x => x.Id,
                       principalTable: "AspNetUsers",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Cascade);
                   table.ForeignKey(
                       name: "FK_AspNetUserTokens_AspNetUsers_UserId21",
                       column: x => x.CardId,
                       principalTable: "Cards",
                       principalColumn: "CardId",
                       onDelete: ReferentialAction.Cascade);

               });
        }

    }

    
}
