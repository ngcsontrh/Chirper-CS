using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Chirper_CS.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    FullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Chirps",
                columns: table => new
                {
                    ChirpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chirps", x => x.ChirpId);
                    table.ForeignKey(
                        name: "FK_Chirps_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FullName" },
                values: new object[,]
                {
                    { -50, "user-50@gmail.com", "User -50" },
                    { -49, "user-49@gmail.com", "User -49" },
                    { -48, "user-48@gmail.com", "User -48" },
                    { -47, "user-47@gmail.com", "User -47" },
                    { -46, "user-46@gmail.com", "User -46" },
                    { -45, "user-45@gmail.com", "User -45" },
                    { -44, "user-44@gmail.com", "User -44" },
                    { -43, "user-43@gmail.com", "User -43" },
                    { -42, "user-42@gmail.com", "User -42" },
                    { -41, "user-41@gmail.com", "User -41" },
                    { -40, "user-40@gmail.com", "User -40" },
                    { -39, "user-39@gmail.com", "User -39" },
                    { -38, "user-38@gmail.com", "User -38" },
                    { -37, "user-37@gmail.com", "User -37" },
                    { -36, "user-36@gmail.com", "User -36" },
                    { -35, "user-35@gmail.com", "User -35" },
                    { -34, "user-34@gmail.com", "User -34" },
                    { -33, "user-33@gmail.com", "User -33" },
                    { -32, "user-32@gmail.com", "User -32" },
                    { -31, "user-31@gmail.com", "User -31" },
                    { -30, "user-30@gmail.com", "User -30" },
                    { -29, "user-29@gmail.com", "User -29" },
                    { -28, "user-28@gmail.com", "User -28" },
                    { -27, "user-27@gmail.com", "User -27" },
                    { -26, "user-26@gmail.com", "User -26" },
                    { -25, "user-25@gmail.com", "User -25" },
                    { -24, "user-24@gmail.com", "User -24" },
                    { -23, "user-23@gmail.com", "User -23" },
                    { -22, "user-22@gmail.com", "User -22" },
                    { -21, "user-21@gmail.com", "User -21" },
                    { -20, "user-20@gmail.com", "User -20" },
                    { -19, "user-19@gmail.com", "User -19" },
                    { -18, "user-18@gmail.com", "User -18" },
                    { -17, "user-17@gmail.com", "User -17" },
                    { -16, "user-16@gmail.com", "User -16" },
                    { -15, "user-15@gmail.com", "User -15" },
                    { -14, "user-14@gmail.com", "User -14" },
                    { -13, "user-13@gmail.com", "User -13" },
                    { -12, "user-12@gmail.com", "User -12" },
                    { -11, "user-11@gmail.com", "User -11" },
                    { -10, "user-10@gmail.com", "User -10" },
                    { -9, "user-9@gmail.com", "User -9" },
                    { -8, "user-8@gmail.com", "User -8" },
                    { -7, "user-7@gmail.com", "User -7" },
                    { -6, "user-6@gmail.com", "User -6" },
                    { -5, "user-5@gmail.com", "User -5" },
                    { -4, "user-4@gmail.com", "User -4" },
                    { -3, "user-3@gmail.com", "User -3" },
                    { -2, "user-2@gmail.com", "User -2" },
                    { -1, "user-1@gmail.com", "User -1" }
                });

            migrationBuilder.InsertData(
                table: "Chirps",
                columns: new[] { "ChirpId", "Message", "UserId" },
                values: new object[,]
                {
                    { -50, "Chirp #-50", -33 },
                    { -49, "Chirp #-49", -15 },
                    { -48, "Chirp #-48", -47 },
                    { -47, "Chirp #-47", -14 },
                    { -46, "Chirp #-46", -6 },
                    { -45, "Chirp #-45", -43 },
                    { -44, "Chirp #-44", -3 },
                    { -43, "Chirp #-43", -14 },
                    { -42, "Chirp #-42", -30 },
                    { -41, "Chirp #-41", -22 },
                    { -40, "Chirp #-40", -1 },
                    { -39, "Chirp #-39", -17 },
                    { -38, "Chirp #-38", -24 },
                    { -37, "Chirp #-37", -14 },
                    { -36, "Chirp #-36", -16 },
                    { -35, "Chirp #-35", -31 },
                    { -34, "Chirp #-34", -29 },
                    { -33, "Chirp #-33", -33 },
                    { -32, "Chirp #-32", -16 },
                    { -31, "Chirp #-31", -37 },
                    { -30, "Chirp #-30", -30 },
                    { -29, "Chirp #-29", -38 },
                    { -28, "Chirp #-28", -39 },
                    { -27, "Chirp #-27", -46 },
                    { -26, "Chirp #-26", -14 },
                    { -25, "Chirp #-25", -24 },
                    { -24, "Chirp #-24", -3 },
                    { -23, "Chirp #-23", -38 },
                    { -22, "Chirp #-22", -13 },
                    { -21, "Chirp #-21", -4 },
                    { -20, "Chirp #-20", -16 },
                    { -19, "Chirp #-19", -20 },
                    { -18, "Chirp #-18", -45 },
                    { -17, "Chirp #-17", -45 },
                    { -16, "Chirp #-16", -5 },
                    { -15, "Chirp #-15", -13 },
                    { -14, "Chirp #-14", -30 },
                    { -13, "Chirp #-13", -10 },
                    { -12, "Chirp #-12", -48 },
                    { -11, "Chirp #-11", -22 },
                    { -10, "Chirp #-10", -3 },
                    { -9, "Chirp #-9", -6 },
                    { -8, "Chirp #-8", -27 },
                    { -7, "Chirp #-7", -13 },
                    { -6, "Chirp #-6", -34 },
                    { -5, "Chirp #-5", -2 },
                    { -4, "Chirp #-4", -11 },
                    { -3, "Chirp #-3", -8 },
                    { -2, "Chirp #-2", -4 },
                    { -1, "Chirp #-1", -43 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chirps_UserId",
                table: "Chirps",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chirps");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
