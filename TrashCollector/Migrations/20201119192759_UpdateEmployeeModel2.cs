using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class UpdateEmployeeModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f9ee3ef-1073-4a89-8df0-6ad1db4e228a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82d3ff41-2efd-4ff7-a6c5-b66c7a4d1710");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Customer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4937c1ae-334d-487f-a1e0-fcbd4a7a60f6", "6c1ae4c0-ff42-430f-876b-d395fbe58526", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e9398be-6c70-4e9a-9718-e3e91c64bf82", "f1c65cbd-4857-472b-9182-96ccdfcd333d", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_EmployeeId",
                table: "Customer",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Employee_EmployeeId",
                table: "Customer",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Employee_EmployeeId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_EmployeeId",
                table: "Customer");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4937c1ae-334d-487f-a1e0-fcbd4a7a60f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e9398be-6c70-4e9a-9718-e3e91c64bf82");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "82d3ff41-2efd-4ff7-a6c5-b66c7a4d1710", "cbe1c626-926a-4bb4-8c85-cfe55c3fad35", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f9ee3ef-1073-4a89-8df0-6ad1db4e228a", "a3f92f1d-d640-4287-a1cd-003e540e10f5", "Employee", "EMPLOYEE" });
        }
    }
}
