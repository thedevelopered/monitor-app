using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AltenChallengeApp.Infrastructure.Migrations
{
    public partial class Fix_Update_Property_Name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Vehicles",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateddAt",
                table: "Customers",
                newName: "UpdatedAt");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("4dcd05e1-69c4-49ca-8863-9359858d8ff5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 11, 18, 0, 3, 32, 982, DateTimeKind.Local), new DateTime(2018, 11, 18, 0, 3, 32, 982, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("6d23151a-6904-4154-af0e-f97ae201c89b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 11, 18, 0, 3, 32, 982, DateTimeKind.Local), new DateTime(2018, 11, 18, 0, 3, 32, 982, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("7df039b0-eb98-4415-813a-f930ce3a20c7"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 11, 18, 0, 3, 32, 982, DateTimeKind.Local), new DateTime(2018, 11, 18, 0, 3, 32, 982, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5c131134-6d49-48f5-ad8d-a2dccf738ce7"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 11, 18, 0, 3, 32, 980, DateTimeKind.Local), new DateTime(2018, 11, 18, 0, 3, 32, 980, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9fa0be73-befe-4584-9aac-81c04605f905"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 11, 18, 0, 3, 32, 980, DateTimeKind.Local), new DateTime(2018, 11, 18, 0, 3, 32, 980, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b38f284c-d6f3-4732-adc1-94dd56b04e62"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 11, 18, 0, 3, 32, 980, DateTimeKind.Local), new DateTime(2018, 11, 18, 0, 3, 32, 980, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("cc9d160d-9cb4-43bf-80f5-ef945e619408"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 11, 18, 0, 3, 32, 978, DateTimeKind.Local), new DateTime(2018, 11, 18, 0, 3, 32, 980, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d40f33e3-19f6-4c55-ba5f-28d7a575879f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 11, 18, 0, 3, 32, 980, DateTimeKind.Local), new DateTime(2018, 11, 18, 0, 3, 32, 980, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e3131a06-3a3f-4fc8-98b4-ee762ca4af83"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 11, 18, 0, 3, 32, 980, DateTimeKind.Local), new DateTime(2018, 11, 18, 0, 3, 32, 980, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ed6a27e9-7f20-4bf4-896e-4ce540307a73"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2018, 11, 18, 0, 3, 32, 980, DateTimeKind.Local), new DateTime(2018, 11, 18, 0, 3, 32, 980, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Vehicles",
                newName: "UpdateddAt");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Customers",
                newName: "UpdateddAt");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("4dcd05e1-69c4-49ca-8863-9359858d8ff5"),
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2018, 11, 16, 0, 19, 18, 295, DateTimeKind.Local), new DateTime(2018, 11, 16, 0, 19, 18, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("6d23151a-6904-4154-af0e-f97ae201c89b"),
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2018, 11, 16, 0, 19, 18, 295, DateTimeKind.Local), new DateTime(2018, 11, 16, 0, 19, 18, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("7df039b0-eb98-4415-813a-f930ce3a20c7"),
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2018, 11, 16, 0, 19, 18, 295, DateTimeKind.Local), new DateTime(2018, 11, 16, 0, 19, 18, 295, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5c131134-6d49-48f5-ad8d-a2dccf738ce7"),
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("9fa0be73-befe-4584-9aac-81c04605f905"),
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b38f284c-d6f3-4732-adc1-94dd56b04e62"),
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("cc9d160d-9cb4-43bf-80f5-ef945e619408"),
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2018, 11, 16, 0, 19, 18, 292, DateTimeKind.Local), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d40f33e3-19f6-4c55-ba5f-28d7a575879f"),
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e3131a06-3a3f-4fc8-98b4-ee762ca4af83"),
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ed6a27e9-7f20-4bf4-896e-4ce540307a73"),
                columns: new[] { "CreatedAt", "UpdateddAt" },
                values: new object[] { new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local) });
        }
    }
}
