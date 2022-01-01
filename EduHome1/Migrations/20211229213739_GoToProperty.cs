using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome1.Migrations
{
    public partial class GoToProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherDetailsId",
                table: "TeacherSkill",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSkill_TeacherDetailsId",
                table: "TeacherSkill",
                column: "TeacherDetailsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherSkill_TeacherDetail_TeacherDetailsId",
                table: "TeacherSkill",
                column: "TeacherDetailsId",
                principalTable: "TeacherDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherSkill_TeacherDetail_TeacherDetailsId",
                table: "TeacherSkill");

            migrationBuilder.DropIndex(
                name: "IX_TeacherSkill_TeacherDetailsId",
                table: "TeacherSkill");

            migrationBuilder.DropColumn(
                name: "TeacherDetailsId",
                table: "TeacherSkill");
        }
    }
}
