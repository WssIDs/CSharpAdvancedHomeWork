﻿// <auto-generated />
using HomeWork9.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HomeWork9.Migrations
{
    [DbContext(typeof(StoryDbContext))]
    [Migration("20210222214455_AddedRequired_Fields_FirstNameLastName_Character")]
    partial class AddedRequired_Fields_FirstNameLastName_Character
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthorStory", b =>
                {
                    b.Property<int>("AuthorsId")
                        .HasColumnType("int");

                    b.Property<int>("StoriesId")
                        .HasColumnType("int");

                    b.HasKey("AuthorsId", "StoriesId");

                    b.HasIndex("StoriesId");

                    b.ToTable("AuthorStory");
                });

            modelBuilder.Entity("HomeWork9.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("FirstName", "LastName");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Reuel ",
                            LastName = "Tolkien"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Hans",
                            LastName = "Andersen"
                        });
                });

            modelBuilder.Entity("HomeWork9.Entities.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("StoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StoryId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 35,
                            FirstName = "Harry",
                            Gender = true,
                            LastName = "Seldon",
                            StoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            Age = 2700,
                            FirstName = "Arven",
                            Gender = false,
                            LastName = "Undomiel",
                            StoryId = 2
                        },
                        new
                        {
                            Id = 3,
                            Age = 14,
                            FirstName = "Finn",
                            Gender = true,
                            LastName = "Mertens",
                            StoryId = 3
                        });
                });

            modelBuilder.Entity("HomeWork9.Entities.Story", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "Foundation"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "LOTR"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "Hyperion"
                        });
                });

            modelBuilder.Entity("AuthorStory", b =>
                {
                    b.HasOne("HomeWork9.Entities.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomeWork9.Entities.Story", null)
                        .WithMany()
                        .HasForeignKey("StoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HomeWork9.Entities.Character", b =>
                {
                    b.HasOne("HomeWork9.Entities.Story", "Story")
                        .WithMany("Characters")
                        .HasForeignKey("StoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Story");
                });

            modelBuilder.Entity("HomeWork9.Entities.Story", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
