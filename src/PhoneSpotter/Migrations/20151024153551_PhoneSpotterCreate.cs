using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace PhoneSpotter.Migrations
{
    public partial class PhoneSpotterCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhoneSpotting",
                columns: table => new
                {
                    PhoneSpottingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    PhoneManufacturer = table.Column<string>(nullable: true),
                    PhoneModel = table.Column<string>(nullable: true),
                    SpotTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneSpotting", x => x.PhoneSpottingId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("PhoneSpotting");
        }
    }
}
