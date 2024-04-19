using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MumbleDB.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__1788CC4C4F8167F5", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FromUserID = table.Column<int>(type: "int", nullable: false),
                    ToUserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Messages__C87C0C9C2E13BC06", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK__Messages__FromUs__628FA481",
                        column: x => x.FromUserID,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK__Messages__ToUser__6383C8BA",
                        column: x => x.ToUserID,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_FromUserID",
                table: "Messages",
                column: "FromUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ToUserID",
                table: "Messages",
                column: "ToUserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
