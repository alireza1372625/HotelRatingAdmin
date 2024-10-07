﻿// <auto-generated />
using HotelRating.Persistance.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelRating.Persistance.EF.Migrations;

[DbContext(typeof(ApplicationDbContext))]
[Migration("20240929112805_SeedData")]
partial class SeedData
{
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("Relational:MaxIdentifierLength", 128)
            .HasAnnotation("ProductVersion", "5.0.17")
            .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        modelBuilder.Entity("HotelRating.Models.Answer", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("QuestionId")
                    .HasColumnType("int");

                b.Property<string>("Response")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("QuestionId");

                b.ToTable("Answers");
            });

        modelBuilder.Entity("HotelRating.Models.Hotel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Address")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Hotels");

                b.HasData(
                    new
                    {
                        Id = 1,
                        Address = "Address A",
                        Name = "Hotel A"
                    },
                    new
                    {
                        Id = 2,
                        Address = "Address B",
                        Name = "Hotel B"
                    });
            });

        modelBuilder.Entity("HotelRating.Models.Question", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("HotelId")
                    .HasColumnType("int");

                b.Property<string>("Text")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Type")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("HotelId");

                b.ToTable("Questions");

                b.HasData(
                    new
                    {
                        Id = 1,
                        HotelId = 1,
                        Text = "How would you rate the cleanliness?",
                        Type = "Rating"
                    },
                    new
                    {
                        Id = 2,
                        HotelId = 1,
                        Text = "Was the staff friendly?",
                        Type = "YesNo"
                    },
                    new
                    {
                        Id = 3,
                        HotelId = 1,
                        Text = "Any comments about your stay?",
                        Type = "OpenEnded"
                    },
                    new
                    {
                        Id = 4,
                        HotelId = 2,
                        Text = "How would you rate the service?",
                        Type = "Rating"
                    },
                    new
                    {
                        Id = 5,
                        HotelId = 2,
                        Text = "Would you recommend this hotel?",
                        Type = "YesNo"
                    });
            });

        modelBuilder.Entity("HotelRating.Models.Rating", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("HotelId")
                    .HasColumnType("int");

                b.Property<double>("Score")
                    .HasColumnType("float");

                b.HasKey("Id");

                b.HasIndex("HotelId");

                b.ToTable("Ratings");
            });

        modelBuilder.Entity("HotelRating.Models.Answer", b =>
            {
                b.HasOne("HotelRating.Models.Question", "Question")
                    .WithMany()
                    .HasForeignKey("QuestionId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Question");
            });

        modelBuilder.Entity("HotelRating.Models.Question", b =>
            {
                b.HasOne("HotelRating.Models.Hotel", "Hotel")
                    .WithMany("Questions")
                    .HasForeignKey("HotelId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Hotel");
            });

        modelBuilder.Entity("HotelRating.Models.Rating", b =>
            {
                b.HasOne("HotelRating.Models.Hotel", "Hotel")
                    .WithMany()
                    .HasForeignKey("HotelId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Hotel");
            });

        modelBuilder.Entity("HotelRating.Models.Hotel", b =>
            {
                b.Navigation("Questions");
            });
#pragma warning restore 612, 618
    }
}

