﻿// <auto-generated />
using CustomersSalesDetails.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomersSalesDetails.Migrations
{
    [DbContext(typeof(AllClassContext))]
    [Migration("20190930094735_Initialcreate")]
    partial class Initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomersSalesDetails.Models.CustomerDetails", b =>
                {
                    b.Property<int>("Customer_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("AllowDiscount")
                        .HasColumnType("int");

                    b.Property<string>("Customer_Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Mobile")
                        .HasColumnType("int");

                    b.Property<int>("Total_Cradit")
                        .HasColumnType("int");

                    b.HasKey("Customer_Id");

                    b.ToTable("customerDetails");
                });

            modelBuilder.Entity("CustomersSalesDetails.Models.InvoicTwo", b =>
                {
                    b.Property<int>("Invoice_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Customer_Id")
                        .HasColumnType("int");

                    b.Property<string>("Item_Id")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 64)))
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quanty")
                        .HasColumnType("int");

                    b.HasKey("Invoice_Id");

                    b.ToTable("invoicTwos");
                });

            modelBuilder.Entity("CustomersSalesDetails.Models.Invoice", b =>
                {
                    b.Property<int>("Invoice_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Customer_Id")
                        .HasColumnType("int");

                    b.Property<string>("Item_Id")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 64)))
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quanty")
                        .HasColumnType("int");

                    b.HasKey("Invoice_Id");

                    b.ToTable("invoices");
                });

            modelBuilder.Entity("CustomersSalesDetails.Models.ItemsDetails", b =>
                {
                    b.Property<int>("Item_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Item_Id");

                    b.ToTable("itemsDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
