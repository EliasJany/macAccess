using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace macAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MacMinis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mac = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MacMinis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MacMiniDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MacMiniId = table.Column<int>(type: "int", nullable: true),
                    CPU = table.Column<int>(type: "int", nullable: false),
                    RAM = table.Column<int>(type: "int", nullable: false),
                    SSD = table.Column<int>(type: "int", nullable: false),
                    HDD = table.Column<int>(type: "int", nullable: false),
                    Netzwerk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MacMiniDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MacMiniDatas_MacMinis_MacMiniId",
                        column: x => x.MacMiniId,
                        principalTable: "MacMinis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MacMiniDatas_MacMiniId",
                table: "MacMiniDatas",
                column: "MacMiniId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MacMiniDatas");

            migrationBuilder.DropTable(
                name: "MacMinis");
        }
    }
}
