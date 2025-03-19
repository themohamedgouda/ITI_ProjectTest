using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITI_Project.Migrations
{
    /// <inheritdoc />
    public partial class OnetoOneRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Manager_Id",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Manager_Id",
                table: "Departments",
                column: "Manager_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Manager_Id",
                table: "Departments",
                column: "Manager_Id",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Manager_Id",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Manager_Id",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Manager_Id",
                table: "Departments");
        }
    }
}
