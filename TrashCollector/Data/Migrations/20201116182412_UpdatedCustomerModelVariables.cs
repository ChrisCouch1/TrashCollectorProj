using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class UpdatedCustomerModelVariables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99071aad-3e19-4a9a-af94-6756ff28c853");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af625ea7-a630-4aac-8626-13998dede503");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "Customer",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "OneTimePickUpDate",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuspendTrashDate",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrashDay",
                table: "Customer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "64103305-e756-43ca-9a23-c677b224b81e", "9f267fe7-0c7b-4de0-8a6f-688a7baa461e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6689c4f-2ab1-4f74-8219-3149f759521e", "a54f2004-7e33-4e96-b59f-eb02481d16ef", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64103305-e756-43ca-9a23-c677b224b81e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6689c4f-2ab1-4f74-8219-3149f759521e");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "OneTimePickUpDate",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "SuspendTrashDate",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "TrashDay",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af625ea7-a630-4aac-8626-13998dede503", "dd016448-2c48-47ef-8eee-652d8c251429", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "99071aad-3e19-4a9a-af94-6756ff28c853", "ad2feb78-49f2-4bee-9883-dc866ef3d076", "Employee", "EMPLOYEE" });
        }
    }
}
