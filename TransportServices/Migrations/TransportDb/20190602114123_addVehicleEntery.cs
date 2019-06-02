using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportServices.Migrations.TransportDb
{
    public partial class addVehicleEntery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vehicle_entry",
                columns: table => new
                {
                    vehicleNo = table.Column<string>(nullable: false),
                    biltyNo = table.Column<string>(nullable: true),
                    quantity_pmt = table.Column<int>(nullable: false),
                    invoiceNo = table.Column<string>(nullable: true),
                    transporterName = table.Column<string>(nullable: true),
                    transportName = table.Column<string>(nullable: true),
                    driverName = table.Column<string>(nullable: true),
                    driverContact = table.Column<long>(nullable: false),
                    vehicleInDate = table.Column<DateTime>(nullable: false),
                    veheicleOutDate = table.Column<DateTime>(nullable: false),
                    TotalTime = table.Column<int>(nullable: false),
                    status = table.Column<string>(nullable: true),
                    remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicle_entry", x => x.vehicleNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vehicle_entry");
        }
    }
}
