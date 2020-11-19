using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class UpdatedEmployeeModel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "894812ff-6639-4c95-9891-4bedee22eec3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5c49347-b06d-40f4-820c-4f1c8bbec301");

            migrationBuilder.AddColumn<string>(
                name: "DayOfWork",
                table: "Employee",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "82d3ff41-2efd-4ff7-a6c5-b66c7a4d1710", "cbe1c626-926a-4bb4-8c85-cfe55c3fad35", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f9ee3ef-1073-4a89-8df0-6ad1db4e228a", "a3f92f1d-d640-4287-a1cd-003e540e10f5", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f9ee3ef-1073-4a89-8df0-6ad1db4e228a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82d3ff41-2efd-4ff7-a6c5-b66c7a4d1710");

            migrationBuilder.DropColumn(
                name: "DayOfWork",
                table: "Employee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5c49347-b06d-40f4-820c-4f1c8bbec301", "58fcd582-91d6-4a3e-af3e-5d7a9988243d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "894812ff-6639-4c95-9891-4bedee22eec3", "dfc77edc-68ae-4542-99ef-4d2769843b60", "Employee", "EMPLOYEE" });
        }
    }
}
