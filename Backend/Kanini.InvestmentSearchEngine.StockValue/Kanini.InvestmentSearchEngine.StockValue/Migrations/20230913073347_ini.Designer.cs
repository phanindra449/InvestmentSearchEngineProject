﻿// <auto-generated />
using System;
using Kanini.InvestmentSearchEngine.StockValue.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kanini.InvestmentSearchEngine.StockValue.Migrations
{
    [DbContext(typeof(StockPriceContext))]
    [Migration("20230913073347_ini")]
    partial class ini
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Kanini.InvestmentSearchEngine.StockValue.Models.StockPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<double>("CurrentStockPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("UpdatedStockPercent")
                        .HasColumnType("float");

                    b.Property<double>("UpdatedStockPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId")
                        .IsUnique();

                    b.ToTable("StockPrices");
                });

            modelBuilder.Entity("Kanini.InvestmentSearchEngine.StockValue.Models.StockTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("StockId")
                        .HasColumnType("int");

                    b.Property<double>("StockValue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("StockId");

                    b.ToTable("StockTransactions");
                });

            modelBuilder.Entity("Kanini.InvestmentSearchEngine.StockValue.Models.StockTransaction", b =>
                {
                    b.HasOne("Kanini.InvestmentSearchEngine.StockValue.Models.StockPrice", "StockPrice")
                        .WithMany("StockTransactions")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StockPrice");
                });

            modelBuilder.Entity("Kanini.InvestmentSearchEngine.StockValue.Models.StockPrice", b =>
                {
                    b.Navigation("StockTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}
