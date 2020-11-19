using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class UpdatedCustomerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ed5516e-fc9b-49a7-b147-6ff2c3b3a16a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51401559-d488-4830-9c77-bc294e9d2ce7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5c49347-b06d-40f4-820c-4f1c8bbec301", "58fcd582-91d6-4a3e-af3e-5d7a9988243d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "894812ff-6639-4c95-9891-4bedee22eec3", "dfc77edc-68ae-4542-99ef-4d2769843b60", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "894812ff-6639-4c95-9891-4bedee22eec3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5c49347-b06d-40f4-820c-4f1c8bbec301");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ed5516e-fc9b-49a7-b147-6ff2c3b3a16a", "879b54ef-19a0-4ef7-8247-7c75fe7cb6f7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51401559-d488-4830-9c77-bc294e9d2ce7", "06a84279-07dc-4199-aa6e-76e0439b9587", "Employee", "EMPLOYEE" });
        }
    }
}
