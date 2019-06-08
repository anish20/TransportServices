using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportServices.Migrations.TransportDb
{
    public partial class add_amountAndRate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "amount",
                table: "vehicle_entry",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "rate_pmt",
                table: "vehicle_entry",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "amount",
                table: "vehicle_entry");

            migrationBuilder.DropColumn(
                name: "rate_pmt",
                table: "vehicle_entry");
        }
    }
}
