using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSUWEBPMOCAP.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PDFFILE",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PDFFILE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RegUser",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Net_ID = table.Column<string>(nullable: true),
                    Password = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegUser", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sponsor",
                columns: table => new
                {
                    Sponsor_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sponsor_Name = table.Column<string>(nullable: true),
                    Sponsor_Title = table.Column<string>(nullable: true),
                    Sponsor_Org = table.Column<string>(nullable: true),
                    Sponsor_Email = table.Column<string>(nullable: true),
                    Sponsor_Phone = table.Column<string>(nullable: true),
                    Sponsor_Address = table.Column<string>(nullable: true),
                    Sponsor_Website = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sponsor", x => x.Sponsor_ID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Student_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Student_Net_ID = table.Column<string>(nullable: true),
                    Student_LastName = table.Column<string>(nullable: true),
                    Student_FirstdName = table.Column<string>(nullable: true),
                    Student_Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Student_ID);
                });

            migrationBuilder.CreateTable(
                name: "TblFile",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ContenType = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFile", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Dept_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dept_Num = table.Column<int>(nullable: false),
                    Dept_Name = table.Column<string>(nullable: true),
                    Faculty_LastName = table.Column<string>(nullable: true),
                    AssignmentAssign_ID = table.Column<int>(nullable: true),
                    Project_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Dept_ID);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    Faculty_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Net_ID = table.Column<string>(nullable: true),
                    Faculty_LastName = table.Column<string>(nullable: true),
                    Faculty_FirstName = table.Column<string>(nullable: true),
                    Faculty_Email = table.Column<string>(nullable: true),
                    Dept_Name = table.Column<string>(nullable: true),
                    DepartmentDept_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.Faculty_ID);
                    table.ForeignKey(
                        name: "FK_Faculty_Department_DepartmentDept_ID",
                        column: x => x.DepartmentDept_ID,
                        principalTable: "Department",
                        principalColumn: "Dept_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Project_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Project_Num = table.Column<string>(nullable: true),
                    Proj_Type = table.Column<string>(nullable: true),
                    Num_Teams_Sponsored = table.Column<string>(nullable: true),
                    Project_Description = table.Column<string>(nullable: true),
                    Proj_Sponsor_Benefit = table.Column<string>(nullable: true),
                    Proj_Student_Benefit = table.Column<string>(nullable: true),
                    Proj_hasNDA = table.Column<bool>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Sponsor_Name = table.Column<string>(nullable: true),
                    Faculty_LastName = table.Column<string>(nullable: true),
                    Dept_Name = table.Column<string>(nullable: true),
                    Faculty_ID = table.Column<int>(nullable: true),
                    Project_ID1 = table.Column<int>(nullable: true),
                    Sponsor_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Project_ID);
                    table.ForeignKey(
                        name: "FK_Project_Faculty_Faculty_ID",
                        column: x => x.Faculty_ID,
                        principalTable: "Faculty",
                        principalColumn: "Faculty_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_Project_Project_ID1",
                        column: x => x.Project_ID1,
                        principalTable: "Project",
                        principalColumn: "Project_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_Sponsor_Sponsor_ID",
                        column: x => x.Sponsor_ID,
                        principalTable: "Sponsor",
                        principalColumn: "Sponsor_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    Assign_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Project_ID = table.Column<int>(nullable: false),
                    Net_ID = table.Column<string>(nullable: true),
                    Student_Net_ID = table.Column<string>(nullable: true),
                    Faculty_LastName = table.Column<string>(nullable: true),
                    Student_LastName = table.Column<string>(nullable: true),
                    Faculty_ID = table.Column<int>(nullable: true),
                    Student_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => x.Assign_ID);
                    table.ForeignKey(
                        name: "FK_Assignment_Faculty_Faculty_ID",
                        column: x => x.Faculty_ID,
                        principalTable: "Faculty",
                        principalColumn: "Faculty_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignment_Project_Project_ID",
                        column: x => x.Project_ID,
                        principalTable: "Project",
                        principalColumn: "Project_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignment_Student_Student_ID",
                        column: x => x.Student_ID,
                        principalTable: "Student",
                        principalColumn: "Student_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proposal",
                columns: table => new
                {
                    Propasal_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sponsor_ID = table.Column<int>(nullable: false),
                    Sponsor_Name = table.Column<string>(nullable: true),
                    Project_Type = table.Column<string>(nullable: true),
                    Project_Num = table.Column<int>(nullable: false),
                    Dept_Name = table.Column<string>(nullable: true),
                    DepartmentDept_ID = table.Column<int>(nullable: true),
                    Project_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proposal", x => x.Propasal_ID);
                    table.ForeignKey(
                        name: "FK_Proposal_Department_DepartmentDept_ID",
                        column: x => x.DepartmentDept_ID,
                        principalTable: "Department",
                        principalColumn: "Dept_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proposal_Project_Project_ID",
                        column: x => x.Project_ID,
                        principalTable: "Project",
                        principalColumn: "Project_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proposal_Sponsor_Sponsor_ID",
                        column: x => x.Sponsor_ID,
                        principalTable: "Sponsor",
                        principalColumn: "Sponsor_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_Faculty_ID",
                table: "Assignment",
                column: "Faculty_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_Project_ID",
                table: "Assignment",
                column: "Project_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_Student_ID",
                table: "Assignment",
                column: "Student_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_AssignmentAssign_ID",
                table: "Department",
                column: "AssignmentAssign_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_Project_ID",
                table: "Department",
                column: "Project_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_DepartmentDept_ID",
                table: "Faculty",
                column: "DepartmentDept_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Faculty_ID",
                table: "Project",
                column: "Faculty_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Project_ID1",
                table: "Project",
                column: "Project_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Sponsor_ID",
                table: "Project",
                column: "Sponsor_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Proposal_DepartmentDept_ID",
                table: "Proposal",
                column: "DepartmentDept_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Proposal_Project_ID",
                table: "Proposal",
                column: "Project_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Proposal_Sponsor_ID",
                table: "Proposal",
                column: "Sponsor_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Project_Project_ID",
                table: "Department",
                column: "Project_ID",
                principalTable: "Project",
                principalColumn: "Project_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Assignment_AssignmentAssign_ID",
                table: "Department",
                column: "AssignmentAssign_ID",
                principalTable: "Assignment",
                principalColumn: "Assign_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Faculty_Faculty_ID",
                table: "Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Faculty_Faculty_ID",
                table: "Project");

            migrationBuilder.DropTable(
                name: "PDFFILE");

            migrationBuilder.DropTable(
                name: "Proposal");

            migrationBuilder.DropTable(
                name: "RegUser");

            migrationBuilder.DropTable(
                name: "TblFile");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Sponsor");
        }
    }
}
