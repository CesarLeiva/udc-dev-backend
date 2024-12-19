using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace udc_dev_backend.Migrations
{
    /// <inheritdoc />
    public partial class IntermediateTablesCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExperienceTechnology");

            migrationBuilder.DropTable(
                name: "ProjectTechnology");

            migrationBuilder.DropTable(
                name: "TechnologyUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExperienceTechnology",
                columns: table => new
                {
                    ExperienceTechnologiesId = table.Column<int>(type: "integer", nullable: false),
                    ExperiencesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceTechnology", x => new { x.ExperienceTechnologiesId, x.ExperiencesId });
                    table.ForeignKey(
                        name: "FK_ExperienceTechnology_Experiences_ExperiencesId",
                        column: x => x.ExperiencesId,
                        principalTable: "Experiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperienceTechnology_Technologies_ExperienceTechnologiesId",
                        column: x => x.ExperienceTechnologiesId,
                        principalTable: "Technologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTechnology",
                columns: table => new
                {
                    ProjectsId = table.Column<int>(type: "integer", nullable: false),
                    ProyectTechnologiesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTechnology", x => new { x.ProjectsId, x.ProyectTechnologiesId });
                    table.ForeignKey(
                        name: "FK_ProjectTechnology_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectTechnology_Technologies_ProyectTechnologiesId",
                        column: x => x.ProyectTechnologiesId,
                        principalTable: "Technologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechnologyUser",
                columns: table => new
                {
                    UserTechnologiesId = table.Column<int>(type: "integer", nullable: false),
                    UsersId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnologyUser", x => new { x.UserTechnologiesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_TechnologyUser_Technologies_UserTechnologiesId",
                        column: x => x.UserTechnologiesId,
                        principalTable: "Technologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TechnologyUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceTechnology_ExperiencesId",
                table: "ExperienceTechnology",
                column: "ExperiencesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTechnology_ProyectTechnologiesId",
                table: "ProjectTechnology",
                column: "ProyectTechnologiesId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnologyUser_UsersId",
                table: "TechnologyUser",
                column: "UsersId");
        }
    }
}
