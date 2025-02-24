﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Data;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(CountryContext))]
    partial class CountryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("backend.Models.Country", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Code");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("backend.Models.InternetStatistic", b =>
                {
                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("PercentITU")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PercentWB")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long?>("PopulationCIA")
                        .HasColumnType("bigint");

                    b.Property<int?>("YearCIA")
                        .HasColumnType("int");

                    b.Property<int?>("YearITU")
                        .HasColumnType("int");

                    b.Property<int?>("YearWB")
                        .HasColumnType("int");

                    b.HasKey("CountryCode");

                    b.ToTable("InternetStatistics");
                });

            modelBuilder.Entity("backend.Models.InternetStatistic", b =>
                {
                    b.HasOne("backend.Models.Country", "Country")
                        .WithMany("InternetStatistics")
                        .HasForeignKey("CountryCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("backend.Models.Country", b =>
                {
                    b.Navigation("InternetStatistics");
                });
#pragma warning restore 612, 618
        }
    }
}
