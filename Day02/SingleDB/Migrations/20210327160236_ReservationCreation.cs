﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SingleDB.Migrations
{
    public partial class ReservationCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    birth_day = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    phone_number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    number_guest = table.Column<int>(type: "int", nullable: false),
                    street_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apt_suite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    zip_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    room_type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    room_floor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    room_number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    total_bill = table.Column<float>(type: "real", nullable: false),
                    payment_type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    card_type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    card_number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    card_exp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    card_cvc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    arrival_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    leaving_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    check_in = table.Column<bool>(type: "bit", nullable: false),
                    break_fast = table.Column<int>(type: "int", nullable: false),
                    lunch = table.Column<int>(type: "int", nullable: false),
                    dinner = table.Column<int>(type: "int", nullable: false),
                    cleaning = table.Column<bool>(type: "bit", nullable: false),
                    towel = table.Column<bool>(type: "bit", nullable: false),
                    s_surprise = table.Column<bool>(type: "bit", nullable: false),
                    supply_status = table.Column<bool>(type: "bit", nullable: false),
                    food_bill = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservation");
        }
    }
}
