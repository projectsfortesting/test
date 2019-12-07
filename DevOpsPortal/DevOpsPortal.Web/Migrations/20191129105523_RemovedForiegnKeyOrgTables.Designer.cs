﻿// <auto-generated />
using System;
using DevOpsPortal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DevOpsPortal.Web.Migrations
{
    [DbContext(typeof(DevOpsPortalContext))]
    [Migration("20191129105523_RemovedForiegnKeyOrgTables")]
    partial class RemovedForiegnKeyOrgTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DevOpsPortal.Data.ApplicationRoleGroup", b =>
                {
                    b.Property<string>("RoleId");

                    b.Property<int>("GroupId");

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId");

                    b.HasKey("RoleId", "GroupId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("GroupId");

                    b.ToTable("ApplicationRoleGroups");
                });

            modelBuilder.Entity("DevOpsPortal.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("IsPasswordReset");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<int>("OrgId");

                    b.Property<int?>("OrgLevelTypeId");

                    b.Property<int?>("OrgLevelid");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<bool>("User_Active");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("DevOpsPortal.Data.ApplicationUserGroup", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GroupId");

                    b.Property<string>("UserId1");

                    b.HasKey("UserId", "GroupId");

                    b.HasAlternateKey("UserId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId1");

                    b.ToTable("ApplicationUserGroups");
                });

            modelBuilder.Entity("DevOpsPortal.Data.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("DevOpsPortal.Data.Organizations", b =>
                {
                    b.Property<int>("OrgId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("ORG_CREATED_BY");

                    b.Property<DateTime?>("ORG_CREATED_DATE");

                    b.Property<bool>("ORG_LEVEL_ACTIVE");

                    b.Property<string>("ORG_MODIFIED_BY");

                    b.Property<DateTime?>("ORG_MODIFIED_DATE");

                    b.HasKey("OrgId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("DevOpsPortal.Data.OrgHierarchyLevelsUsers", b =>
                {
                    b.Property<int>("orghid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id");

                    b.Property<string>("Name");

                    b.Property<int>("OrgLevelTypeId");

                    b.Property<int>("Org_Id");

                    b.Property<bool>("isadmin");

                    b.Property<string>("userid");

                    b.Property<string>("username");

                    b.HasKey("orghid");

                    b.HasIndex("Id");

                    b.ToTable("OrgHierarchyLevelsUsers");
                });

            modelBuilder.Entity("DevOpsPortal.Data.OrgLevels", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("ORG_CREATED_BY");

                    b.Property<DateTime?>("ORG_CREATED_DATE");

                    b.Property<bool>("ORG_LEVEL_ACTIVE");

                    b.Property<string>("ORG_MODIFIED_BY");

                    b.Property<DateTime?>("ORG_MODIFIED_DATE");

                    b.Property<int?>("OrgId");

                    b.Property<int>("OrgLevelTypeId");

                    b.Property<int?>("OrgLevelTypestypeId");

                    b.Property<int>("Org_Id");

                    b.Property<int>("ParentId");

                    b.Property<string>("orgleveladminId");

                    b.HasKey("PId");

                    b.HasIndex("OrgId");

                    b.HasIndex("OrgLevelTypestypeId");

                    b.ToTable("OrgLevels");
                });

            modelBuilder.Entity("DevOpsPortal.Data.OrgLevelTypes", b =>
                {
                    b.Property<int>("typeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("typeId");

                    b.ToTable("OrgLevelTypes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.HasKey("UserId", "LoginProvider", "ProviderKey");

                    b.HasAlternateKey("LoginProvider", "ProviderKey");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DevOpsPortal.Data.ApplicationRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<string>("Description");

                    b.ToTable("ApplicationRole");

                    b.HasDiscriminator().HasValue("ApplicationRole");
                });

            modelBuilder.Entity("DevOpsPortal.Data.ApplicationRoleGroup", b =>
                {
                    b.HasOne("DevOpsPortal.Data.ApplicationUser", "ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("DevOpsPortal.Data.Group", "Group")
                        .WithMany("Roles")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DevOpsPortal.Data.ApplicationRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DevOpsPortal.Data.ApplicationUserGroup", b =>
                {
                    b.HasOne("DevOpsPortal.Data.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DevOpsPortal.Data.ApplicationUser", "User")
                        .WithMany("Groups")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("DevOpsPortal.Data.OrgHierarchyLevelsUsers", b =>
                {
                    b.HasOne("DevOpsPortal.Data.Organizations", "Org")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DevOpsPortal.Data.OrgLevels", b =>
                {
                    b.HasOne("DevOpsPortal.Data.Organizations", "Org")
                        .WithMany()
                        .HasForeignKey("OrgId");

                    b.HasOne("DevOpsPortal.Data.OrgLevelTypes", "OrgLevelTypes")
                        .WithMany()
                        .HasForeignKey("OrgLevelTypestypeId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DevOpsPortal.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DevOpsPortal.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DevOpsPortal.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DevOpsPortal.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}