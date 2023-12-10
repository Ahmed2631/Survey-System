using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Survey_System.Migrations
{
    public partial class thrMigra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb1Kbis",
                columns: table => new
                {
                    DepNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kpidnum = table.Column<int>(type: "int", nullable: false),
                    MeasurementUnit = table.Column<bool>(type: "bit", nullable: false),
                    Kpidescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    TargetedValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb1Kbis", x => x.DepNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb1Kbis");
        }
    }
}
