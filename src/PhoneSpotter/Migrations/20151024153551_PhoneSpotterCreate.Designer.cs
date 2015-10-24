using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using PhoneSpotter.Models;

namespace PhoneSpotter.Migrations
{
    [DbContext(typeof(PhoneSpottingDbContext))]
    [Migration("20151024153551_PhoneSpotterCreate")]
    partial class PhoneSpotterCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Annotation("ProductVersion", "7.0.0-beta8-15964")
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PhoneSpotter.Models.PhoneSpotting", b =>
                {
                    b.Property<int>("PhoneSpottingId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Notes");

                    b.Property<string>("PhoneManufacturer");

                    b.Property<string>("PhoneModel");

                    b.Property<DateTime>("SpotTime");

                    b.HasKey("PhoneSpottingId");
                });
        }
    }
}
