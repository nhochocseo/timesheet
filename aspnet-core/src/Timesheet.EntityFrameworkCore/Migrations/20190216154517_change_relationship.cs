using Microsoft.EntityFrameworkCore.Migrations;

namespace Timesheet.Migrations
{
    public partial class change_relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Projects_ProjectId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_Projects_ProjectId",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Customers_CustomerId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Members_MemberId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_ProjectId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Projects_CustomerId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_MemberId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Members_ProjectId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ProjectId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Customers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ProjectId",
                table: "Tasks",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CustomerId",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MemberId",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProjectId",
                table: "Members",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProjectId",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ProjectId",
                table: "Tasks",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CustomerId",
                table: "Projects",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_MemberId",
                table: "Projects",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_ProjectId",
                table: "Members",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ProjectId",
                table: "Customers",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Projects_ProjectId",
                table: "Customers",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Projects_ProjectId",
                table: "Members",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Customers_CustomerId",
                table: "Projects",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Members_MemberId",
                table: "Projects",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
