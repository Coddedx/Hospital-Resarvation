using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalResarvation.Web.Migrations
{
    public partial class AddBAseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Medications");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Medications");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Abouts");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Staffs",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Salaries",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "RoomTypes",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Rooms",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Prescriptions",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Patients",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Medications",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "MainPages",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Hospitals",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Doctors",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Departments",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Appointments",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Abouts",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Medications");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Abouts");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Staffs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Staffs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Salaries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Salaries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "RoomTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "RoomTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Rooms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Prescriptions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Prescriptions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Patients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Medications",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Medications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MainPages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "MainPages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Hospitals",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Hospitals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Doctors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Doctors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Departments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Departments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Appointments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Abouts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Abouts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
