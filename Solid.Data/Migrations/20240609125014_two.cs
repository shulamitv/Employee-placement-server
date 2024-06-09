using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollegeCJobC");

            migrationBuilder.DropTable(
                name: "EmployeeCJobC");

            migrationBuilder.AddColumn<int>(
                name: "JobCId",
                table: "EmployeeList",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobCId",
                table: "CollegeList",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeList_JobCId",
                table: "EmployeeList",
                column: "JobCId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeList_JobCId",
                table: "CollegeList",
                column: "JobCId");

            migrationBuilder.AddForeignKey(
                name: "FK_CollegeList_JobList_JobCId",
                table: "CollegeList",
                column: "JobCId",
                principalTable: "JobList",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeList_JobList_JobCId",
                table: "EmployeeList",
                column: "JobCId",
                principalTable: "JobList",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollegeList_JobList_JobCId",
                table: "CollegeList");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeList_JobList_JobCId",
                table: "EmployeeList");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeList_JobCId",
                table: "EmployeeList");

            migrationBuilder.DropIndex(
                name: "IX_CollegeList_JobCId",
                table: "CollegeList");

            migrationBuilder.DropColumn(
                name: "JobCId",
                table: "EmployeeList");

            migrationBuilder.DropColumn(
                name: "JobCId",
                table: "CollegeList");

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
        }
    }
}
