﻿// <auto-generated />
using System;
using EFGetStarted;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFGetStarted.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20201019003236_AddPostDateTime")]
    partial class AddPostDateTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("EFGetStarted.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogId");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            BlogId = 1,
                            Url = "http://sample.com"
                        },
                        new
                        {
                            BlogId = 2,
                            Url = "http://www.tsn.ca"
                        },
                        new
                        {
                            BlogId = 3,
                            Url = "http://www.sportsnet.ca"
                        },
                        new
                        {
                            BlogId = 4,
                            Url = "http://www.theglobeandmail.com"
                        },
                        new
                        {
                            BlogId = 5,
                            Url = "http://www.quora.com"
                        },
                        new
                        {
                            BlogId = 6,
                            Url = "http://www.twitter.com"
                        });
                });

            modelBuilder.Entity("EFGetStarted.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Postdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostId");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            BlogId = 1,
                            Content = "test test test",
                            Postdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Sample post-test"
                        },
                        new
                        {
                            PostId = 2,
                            BlogId = 2,
                            Content = "Where's Travis Hamonic going to sign?",
                            Postdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Sports Headlines"
                        },
                        new
                        {
                            PostId = 3,
                            BlogId = 4,
                            Content = "Justin Trudeau spends $100 more tax dollars!",
                            Postdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Canadian News"
                        },
                        new
                        {
                            PostId = 4,
                            BlogId = 6,
                            Content = "This is my favorite dog, Hank!",
                            Postdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Some Tweet"
                        },
                        new
                        {
                            PostId = 5,
                            BlogId = 6,
                            Content = "Beautiful day here in Calgary!!!",
                            Postdate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Second Tweet"
                        });
                });

            modelBuilder.Entity("EFGetStarted.Post", b =>
                {
                    b.HasOne("EFGetStarted.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("EFGetStarted.Blog", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
