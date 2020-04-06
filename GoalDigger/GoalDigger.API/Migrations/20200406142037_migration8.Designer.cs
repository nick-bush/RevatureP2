﻿// <auto-generated />
using System;
using GoalDigger.DataStore.Databases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoalDigger.API.Migrations
{
    [DbContext(typeof(GoalDiggerDBContext))]
    [Migration("20200406142037_migration8")]
    partial class migration8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoalDigger.Domain.Models.GoalModel", b =>
                {
                    b.Property<long>("uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("Useruid")
                        .HasColumnType("bigint");

                    b.HasKey("uid");

                    b.HasIndex("Useruid");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("GoalDigger.Domain.Models.HashtagModel", b =>
                {
                    b.Property<long>("uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("HashtagPostuid")
                        .HasColumnType("bigint");

                    b.HasKey("uid");

                    b.HasIndex("HashtagPostuid");

                    b.ToTable("Hashtags");
                });

            modelBuilder.Entity("GoalDigger.Domain.Models.HashtagPostModel", b =>
                {
                    b.Property<long>("uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("uid");

                    b.ToTable("HashtagPosts");
                });

            modelBuilder.Entity("GoalDigger.Domain.Models.MentionModel", b =>
                {
                    b.Property<long>("uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("Postuid")
                        .HasColumnType("bigint");

                    b.Property<long?>("Useruid")
                        .HasColumnType("bigint");

                    b.HasKey("uid");

                    b.HasIndex("Postuid");

                    b.HasIndex("Useruid");

                    b.ToTable("Mentions");
                });

            modelBuilder.Entity("GoalDigger.Domain.Models.PostModel", b =>
                {
                    b.Property<long>("uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("HashtagPostuid")
                        .HasColumnType("bigint");

                    b.Property<long?>("Useruid")
                        .HasColumnType("bigint");

                    b.HasKey("uid");

                    b.HasIndex("HashtagPostuid");

                    b.HasIndex("Useruid");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            uid = 1L,
                            Body = "My first #goal !!!"
                        },
                        new
                        {
                            uid = 2L,
                            Body = "My second #goal !!!"
                        });
                });

            modelBuilder.Entity("GoalDigger.Domain.Models.UserModel", b =>
                {
                    b.Property<long>("uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("uid");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            uid = 1L,
                            UserName = "Alex1234"
                        });
                });

            modelBuilder.Entity("GoalDigger.Domain.Models.GoalModel", b =>
                {
                    b.HasOne("GoalDigger.Domain.Models.UserModel", "User")
                        .WithMany("Goals")
                        .HasForeignKey("Useruid");
                });

            modelBuilder.Entity("GoalDigger.Domain.Models.HashtagModel", b =>
                {
                    b.HasOne("GoalDigger.Domain.Models.HashtagPostModel", "HashtagPost")
                        .WithMany("Hashtags")
                        .HasForeignKey("HashtagPostuid");
                });

            modelBuilder.Entity("GoalDigger.Domain.Models.MentionModel", b =>
                {
                    b.HasOne("GoalDigger.Domain.Models.PostModel", "Post")
                        .WithMany("Mentions")
                        .HasForeignKey("Postuid");

                    b.HasOne("GoalDigger.Domain.Models.UserModel", "User")
                        .WithMany("Mentions")
                        .HasForeignKey("Useruid");
                });

            modelBuilder.Entity("GoalDigger.Domain.Models.PostModel", b =>
                {
                    b.HasOne("GoalDigger.Domain.Models.HashtagPostModel", "HashtagPost")
                        .WithMany("Posts")
                        .HasForeignKey("HashtagPostuid");

                    b.HasOne("GoalDigger.Domain.Models.UserModel", "User")
                        .WithMany("Posts")
                        .HasForeignKey("Useruid");
                });
#pragma warning restore 612, 618
        }
    }
}
