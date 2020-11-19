using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class UpdatedCustomerModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4937c1ae-334d-487f-a1e0-fcbd4a7a60f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e9398be-6c70-4e9a-9718-e3e91c64bf82");

            migrationBuilder.AddColumn<bool>(
                name: "VerifiedPickedUp",
                table: "Customer",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4de41805-d381-4b61-bfaf-30992e606c9d", "d2df8a05-af57-49b9-8876-f146746eca17", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f5c9549b-04ba-416d-abcc-21849e5eeae6", "0ae5037d-e145-4d69-993a-d6c691c896ac", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4de41805-d381-4b61-bfaf-30992e606c9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5c9549b-04ba-416d-abcc-21849e5eeae6");

            migrationBuilder.DropColumn(
                name: "VerifiedPickedUp",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4937c1ae-334d-487f-a1e0-fcbd4a7a60f6", "6c1ae4c0-ff42-430f-876b-d395fbe58526", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e9398be-6c70-4e9a-9718-e3e91c64bf82", "f1c65cbd-4857-472b-9182-96ccdfcd333d", "Employee", "EMPLOYEE" });
        }
    }
}
