using Microsoft.EntityFrameworkCore.Migrations;

namespace Three_Sisters_Hotel.Data.Migrations
{
    public partial class mig02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        { 
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Room",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "Booking",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
