using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaMicroservicios.Api.Cupon.Migrations
{
    /// <inheritdoc />
    public partial class ActualizacionDb : Migration
    {
        /// <inheritdoc />d
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaExpiracion",
                table: "Cupons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInicio",
                table: "Cupons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaExpiracion",
                table: "Cupons");

            migrationBuilder.DropColumn(
                name: "FechaInicio",
                table: "Cupons");
        }
    }
}
