using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CollegeList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profession = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoursInDay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<bool>(type: "bit", nullable: false),
                    Profession = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CollegeCId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeList_CollegeList_CollegeCId",
                        column: x => x.CollegeCId,
                        principalTable: "CollegeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CollegeCJobC",
                columns: table => new
                {
                    CollegesId = table.Column<int>(type: "int", nullable: false),
                    JobsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeCJobC", x => new { x.CollegesId, x.JobsId });
                    table.ForeignKey(
                        name: "FK_CollegeCJobC_CollegeList_CollegesId",
                        column: x => x.CollegesId,
                        principalTable: "CollegeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollegeCJobC_JobList_JobsId",
                        column: x => x.JobsId,
                        principalTable: "JobList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeCJobC",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    JobsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCJobC", x => new { x.EmployeesId, x.JobsId });
                    table.ForeignKey(
                        name: "FK_EmployeeCJobC_EmployeeList_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "EmployeeList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeCJobC_JobList_JobsId",
                        column: x => x.JobsId,
                        principalTable: "JobList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CollegeCJobC_JobsId",
                table: "CollegeCJobC",
                column: "JobsId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCJobC_JobsId",
                table: "EmployeeCJobC",
                column: "JobsId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeList_CollegeCId",
                table: "EmployeeList",
                column: "CollegeCId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollegeCJobC");

            migrationBuilder.DropTable(
                name: "EmployeeCJobC");

            migrationBuilder.DropTable(
                name: "EmployeeList");

            migrationBuilder.DropTable(
                name: "JobList");

            migrationBuilder.DropTable(
                name: "CollegeList");
        }
    }
}
