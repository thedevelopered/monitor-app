using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AltenChallengeApp.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UpdateddAt = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RegistrationNumber = table.Column<string>(nullable: true),
                    CustomerId = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    UpdateddAt = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Country", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "UpdatedBy", "UpdateddAt", "ZipCode" },
                values: new object[] { new Guid("4dcd05e1-69c4-49ca-8863-9359858d8ff5"), "Cementvägen 8", "Södertälje", "Sweden", new DateTime(2018, 11, 16, 0, 19, 18, 295, DateTimeKind.Local), new Guid("00000000-0000-0000-0000-000000000000"), false, "Kalles Grustransporter AB", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2018, 11, 16, 0, 19, 18, 295, DateTimeKind.Local), "111 11" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Country", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "UpdatedBy", "UpdateddAt", "ZipCode" },
                values: new object[] { new Guid("6d23151a-6904-4154-af0e-f97ae201c89b"), "Balkvägen 12", "Stockholm", "Sweden", new DateTime(2018, 11, 16, 0, 19, 18, 295, DateTimeKind.Local), new Guid("00000000-0000-0000-0000-000000000000"), false, "Johans Bulk AB", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2018, 11, 16, 0, 19, 18, 295, DateTimeKind.Local), "222 22" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Country", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "UpdatedBy", "UpdateddAt", "ZipCode" },
                values: new object[] { new Guid("7df039b0-eb98-4415-813a-f930ce3a20c7"), "Budgetvägen 1", "Uppsala", "Sweden", new DateTime(2018, 11, 16, 0, 19, 18, 295, DateTimeKind.Local), new Guid("00000000-0000-0000-0000-000000000000"), false, "Haralds Värdetransporter AB", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2018, 11, 16, 0, 19, 18, 295, DateTimeKind.Local), "333 33" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "CustomerId", "IsDeleted", "RegistrationNumber", "UpdatedBy", "UpdateddAt" },
                values: new object[,]
                {
                    { new Guid("cc9d160d-9cb4-43bf-80f5-ef945e619408"), new DateTime(2018, 11, 16, 0, 19, 18, 292, DateTimeKind.Local), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4dcd05e1-69c4-49ca-8863-9359858d8ff5"), false, "ABC123", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local) },
                    { new Guid("5c131134-6d49-48f5-ad8d-a2dccf738ce7"), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4dcd05e1-69c4-49ca-8863-9359858d8ff5"), false, "DEF456", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local) },
                    { new Guid("9fa0be73-befe-4584-9aac-81c04605f905"), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("4dcd05e1-69c4-49ca-8863-9359858d8ff5"), false, "GHI789", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local) },
                    { new Guid("ed6a27e9-7f20-4bf4-896e-4ce540307a73"), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("6d23151a-6904-4154-af0e-f97ae201c89b"), false, "JKL012", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local) },
                    { new Guid("d40f33e3-19f6-4c55-ba5f-28d7a575879f"), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("6d23151a-6904-4154-af0e-f97ae201c89b"), false, "MNO345      ", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local) },
                    { new Guid("b38f284c-d6f3-4732-adc1-94dd56b04e62"), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("7df039b0-eb98-4415-813a-f930ce3a20c7"), false, "PQR678", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local) },
                    { new Guid("e3131a06-3a3f-4fc8-98b4-ee762ca4af83"), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("7df039b0-eb98-4415-813a-f930ce3a20c7"), false, "STU901", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2018, 11, 16, 0, 19, 18, 293, DateTimeKind.Local) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CustomerId",
                table: "Vehicles",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
