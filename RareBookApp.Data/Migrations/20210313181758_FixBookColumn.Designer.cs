﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RareBookApp;

namespace RareBookApp.Data.Migrations
{
    [DbContext(typeof(RareBookAppContext))]
    [Migration("20210313181758_FixBookColumn")]
    partial class FixBookColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RareBookApp.Data.Author", b =>
                {
                    b.Property<int>("AuthorNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorFirstLastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorNumber");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("RareBookApp.Data.Book", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Binding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CopyrightYear")
                        .HasColumnType("int");

                    b.Property<int>("Edition")
                        .HasColumnType("int");

                    b.Property<int>("PublisherID")
                        .HasColumnType("int");

                    b.Property<int>("WorkNumber")
                        .HasColumnType("int");

                    b.HasKey("ISBN");

                    b.HasIndex("PublisherID");

                    b.HasIndex("WorkNumber");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("RareBookApp.Data.ConditionCodes", b =>
                {
                    b.Property<int>("ConditionCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConditionDescription")
                        .HasColumnType("int");

                    b.HasKey("ConditionCode");

                    b.ToTable("ConditionCodes");
                });

            modelBuilder.Entity("RareBookApp.Data.Customer", b =>
                {
                    b.Property<int>("CustomerNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateProvince")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("CustomerNumber");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("RareBookApp.Data.Publisher", b =>
                {
                    b.Property<int>("PublisherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PublisherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PublisherID");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("RareBookApp.Data.Sale", b =>
                {
                    b.Property<int>("SaleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreditCardNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("CustomerNumber")
                        .HasColumnType("int");

                    b.Property<int>("ExpirationDate")
                        .HasColumnType("int");

                    b.Property<int>("ExpirationMonth")
                        .HasColumnType("int");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("SalesTotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SaleID");

                    b.HasIndex("CustomerNumber");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("RareBookApp.Data.Volume", b =>
                {
                    b.Property<int>("InventoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AskingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ConditionCode")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAcquired")
                        .HasColumnType("datetime2");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SaleID")
                        .HasColumnType("int");

                    b.Property<decimal>("SellingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("InventoryID");

                    b.HasIndex("ConditionCode");

                    b.HasIndex("ISBN");

                    b.HasIndex("SaleID");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("RareBookApp.Data.Work", b =>
                {
                    b.Property<int>("WorkNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkNumber");

                    b.HasIndex("AuthorNumber");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("RareBookApp.Data.Book", b =>
                {
                    b.HasOne("RareBookApp.Data.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RareBookApp.Data.Work", "Work")
                        .WithMany("Books")
                        .HasForeignKey("WorkNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");

                    b.Navigation("Work");
                });

            modelBuilder.Entity("RareBookApp.Data.Sale", b =>
                {
                    b.HasOne("RareBookApp.Data.Customer", "Customer")
                        .WithMany("Purchases")
                        .HasForeignKey("CustomerNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("RareBookApp.Data.Volume", b =>
                {
                    b.HasOne("RareBookApp.Data.ConditionCodes", "Condition")
                        .WithMany("Invetory")
                        .HasForeignKey("ConditionCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RareBookApp.Data.Book", "Book")
                        .WithMany("Inventory")
                        .HasForeignKey("ISBN");

                    b.HasOne("RareBookApp.Data.Sale", "SaleTicket")
                        .WithMany()
                        .HasForeignKey("SaleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Condition");

                    b.Navigation("SaleTicket");
                });

            modelBuilder.Entity("RareBookApp.Data.Work", b =>
                {
                    b.HasOne("RareBookApp.Data.Author", "Author")
                        .WithMany("Works")
                        .HasForeignKey("AuthorNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("RareBookApp.Data.Author", b =>
                {
                    b.Navigation("Works");
                });

            modelBuilder.Entity("RareBookApp.Data.Book", b =>
                {
                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("RareBookApp.Data.ConditionCodes", b =>
                {
                    b.Navigation("Invetory");
                });

            modelBuilder.Entity("RareBookApp.Data.Customer", b =>
                {
                    b.Navigation("Purchases");
                });

            modelBuilder.Entity("RareBookApp.Data.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("RareBookApp.Data.Work", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
