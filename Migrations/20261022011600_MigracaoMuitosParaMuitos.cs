using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADE_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADE",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 66, 89, 138, 213, 164, 199, 235, 6, 63, 105, 53, 110, 81, 250, 166, 35, 243, 15, 40, 38, 141, 212, 129, 67, 245, 193, 142, 162, 221, 44, 180, 236, 43, 237, 142, 219, 96, 50, 48, 26, 7, 81, 155, 213, 118, 54, 216, 132, 24, 235, 84, 26, 223, 16, 163, 205, 196, 218, 86, 125, 2, 139, 215, 196 }, new byte[] { 62, 8, 185, 243, 166, 31, 255, 233, 46, 98, 251, 72, 82, 219, 59, 148, 136, 121, 222, 76, 93, 54, 77, 31, 213, 90, 28, 176, 41, 180, 64, 202, 191, 178, 135, 239, 173, 149, 108, 159, 241, 120, 93, 148, 185, 43, 113, 20, 185, 73, 177, 104, 184, 204, 168, 224, 194, 35, 192, 148, 131, 185, 90, 97, 243, 25, 122, 143, 254, 18, 15, 145, 105, 56, 120, 193, 6, 63, 26, 159, 76, 132, 109, 255, 180, 82, 192, 46, 47, 237, 36, 79, 194, 107, 46, 88, 176, 231, 79, 138, 11, 161, 176, 181, 127, 223, 186, 11, 45, 119, 249, 110, 136, 244, 171, 222, 123, 245, 19, 210, 89, 186, 184, 167, 193, 23, 180, 44 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADE");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 107, 113, 178, 49, 116, 135, 136, 87, 86, 87, 58, 144, 72, 3, 159, 208, 143, 126, 215, 37, 184, 156, 34, 55, 67, 140, 52, 22, 219, 145, 163, 180, 215, 205, 118, 186, 80, 219, 175, 16, 66, 112, 82, 56, 29, 61, 190, 250, 6, 69, 168, 83, 246, 222, 191, 175, 64, 57, 62, 10, 254, 79, 35, 189 }, new byte[] { 27, 174, 39, 54, 254, 248, 219, 12, 198, 8, 190, 72, 43, 111, 44, 152, 133, 174, 176, 139, 134, 96, 122, 4, 25, 11, 109, 142, 228, 50, 165, 122, 50, 0, 155, 255, 68, 117, 110, 141, 113, 98, 32, 125, 92, 92, 143, 224, 159, 69, 133, 74, 56, 182, 206, 251, 200, 71, 120, 172, 213, 97, 142, 192, 68, 150, 51, 51, 96, 192, 219, 104, 168, 250, 252, 79, 156, 189, 85, 130, 88, 81, 225, 167, 31, 31, 9, 231, 32, 243, 183, 193, 89, 157, 222, 33, 186, 185, 83, 103, 185, 60, 86, 176, 143, 49, 0, 206, 161, 246, 38, 205, 71, 186, 93, 231, 71, 53, 47, 152, 236, 129, 26, 8, 119, 218, 68, 20 } });
        }
    }
}
