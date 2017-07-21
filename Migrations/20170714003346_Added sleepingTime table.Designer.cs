using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EFCoreSleepApp;

namespace SleepApp.Migrations
{
    [DbContext(typeof(EFCoreSleepAppContext))]
    [Migration("20170714003346_Added sleepingTime table")]
    partial class AddedsleepingTimetable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("SleepApp.Models.UserModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("age");

                    b.Property<string>("firstName");

                    b.Property<string>("lastName");

                    b.Property<string>("password");

                    b.Property<DateTime>("sleepingTime");

                    b.Property<string>("userName");

                    b.HasKey("id");

                    b.ToTable("UserModel");
                });
        }
    }
}
