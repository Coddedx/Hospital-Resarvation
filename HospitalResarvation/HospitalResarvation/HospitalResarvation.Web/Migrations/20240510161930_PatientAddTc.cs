using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalResarvation.Web.Migrations
{
    public partial class PatientAddTc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tc",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tc",
                table: "Patients");
        }
    }
}
