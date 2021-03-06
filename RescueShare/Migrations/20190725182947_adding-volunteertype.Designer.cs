﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RescueShare.Models;

namespace RescueShare.Migrations
{
    [DbContext(typeof(RescueContext))]
    [Migration("20190725182947_adding-volunteertype")]
    partial class addingvolunteertype
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

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
                        .ValueGeneratedOnAdd();

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
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

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

            modelBuilder.Entity("RescueShare.Models.Dog", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Age");

                    b.Property<string>("BreedId");

                    b.Property<string>("CurrentInjuries");

                    b.Property<string>("CurrentMedications");

                    b.Property<int>("Flag");

                    b.Property<string>("Food");

                    b.Property<string>("ImageId");

                    b.Property<DateTime>("InDate");

                    b.Property<bool>("IsSaved");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Notes");

                    b.Property<DateTime>("OutDate");

                    b.Property<string>("RescueId");

                    b.Property<string>("ShelterId");

                    b.Property<string>("SpaceId");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("BreedId");

                    b.HasIndex("ImageId");

                    b.HasIndex("RescueId");

                    b.HasIndex("ShelterId");

                    b.HasIndex("SpaceId");

                    b.ToTable("Dogs");
                });

            modelBuilder.Entity("RescueShare.Models.Entities.DogBreed", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("DogBreeds");
                });

            modelBuilder.Entity("RescueShare.Models.Entities.Image", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Data");

                    b.Property<int>("Height");

                    b.Property<int>("Length");

                    b.Property<string>("Name");

                    b.Property<int>("Width");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("RescueShare.Models.Entities.Opportunity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("LocationId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("TypeId");

                    b.ToTable("Opportunities");
                });

            modelBuilder.Entity("RescueShare.Models.Entities.OpportunityType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("OpportunityTypes");
                });

            modelBuilder.Entity("RescueShare.Models.Entities.Rescue", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1")
                        .IsRequired();

                    b.Property<string>("Address2");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("Zip")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Rescue");
                });

            modelBuilder.Entity("RescueShare.Models.Entities.RescueMember", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RescueId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RescueId");

                    b.HasIndex("UserId");

                    b.ToTable("RescueMember");
                });

            modelBuilder.Entity("RescueShare.Models.Entities.UserDeniedDogBreed", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DogBreedId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("DogBreedId");

                    b.HasIndex("UserId");

                    b.ToTable("UserDeniedDogBreeds");
                });

            modelBuilder.Entity("RescueShare.Models.Foster", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Foster");
                });

            modelBuilder.Entity("RescueShare.Models.Shelter", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1")
                        .IsRequired();

                    b.Property<string>("Address2");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("Zip")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Shelters");
                });

            modelBuilder.Entity("RescueShare.Models.ShelterMember", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ShelterId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ShelterId");

                    b.HasIndex("UserId");

                    b.ToTable("ShelterMembers");
                });

            modelBuilder.Entity("RescueShare.Models.Space", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Capacity");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Notes");

                    b.Property<string>("ShelterId");

                    b.Property<int>("SpaceType");

                    b.HasKey("Id");

                    b.HasIndex("ShelterId");

                    b.ToTable("Spaces");
                });

            modelBuilder.Entity("RescueShare.Models.Transport", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DropoffTime");

                    b.Property<string>("FosterReceiverId");

                    b.Property<string>("FosterSenderId");

                    b.Property<string>("OrganizingRescueId");

                    b.Property<DateTime>("PickupTime");

                    b.Property<int>("ReceiverType");

                    b.Property<string>("RescueReceiverId");

                    b.Property<string>("RescueSenderId");

                    b.Property<int>("SenderType");

                    b.Property<string>("ShelterReceiverId");

                    b.Property<string>("ShelterSenderId");

                    b.Property<DateTime>("TransportTime");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("FosterReceiverId");

                    b.HasIndex("FosterSenderId");

                    b.HasIndex("OrganizingRescueId");

                    b.HasIndex("RescueReceiverId");

                    b.HasIndex("RescueSenderId");

                    b.HasIndex("ShelterReceiverId");

                    b.HasIndex("ShelterSenderId");

                    b.HasIndex("UserId");

                    b.ToTable("Transports");
                });

            modelBuilder.Entity("RescueShare.Models.TransportMember", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TransportId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TransportId");

                    b.HasIndex("UserId");

                    b.ToTable("TransportMember");
                });

            modelBuilder.Entity("RescueShare.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("FosterAges");

                    b.Property<string>("FosterAvailability");

                    b.Property<string>("FosterBreeds");

                    b.Property<int>("FosterSpace");

                    b.Property<string>("FosterTemperment");

                    b.Property<string>("FosterWeights");

                    b.Property<bool>("IsFoster");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("TransportDayAvailability");

                    b.Property<int>("TransportSpace");

                    b.Property<string>("TransportTemperment");

                    b.Property<string>("TransportTimeAvailability");

                    b.Property<string>("TransportWeights");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int>("VolunteerType");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("RescueShare.Models.UserDeniedDogAge", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AgeMid");

                    b.Property<bool>("AgePuppy");

                    b.Property<bool>("AgeSenior");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserDeniedAges");
                });

            modelBuilder.Entity("RescueShare.Models.UserDeniedDogWeight", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserId");

                    b.Property<bool>("WeightClassLarge");

                    b.Property<bool>("WeightClassMedium");

                    b.Property<bool>("WeightClassMini");

                    b.Property<bool>("WeightClassSmall");

                    b.Property<bool>("WieghtClassExtraLarge");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserDeniedDogWeights");
                });

            modelBuilder.Entity("RescueShare.Models.UserDeniedTemperment", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Biter");

                    b.Property<bool>("GoodWithCats");

                    b.Property<bool>("GoodWithDogs");

                    b.Property<bool>("GoodWithKids");

                    b.Property<bool>("SpecialNeeds");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserDeniedTemperments");
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
                    b.HasOne("RescueShare.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RescueShare.Models.User")
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

                    b.HasOne("RescueShare.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RescueShare.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RescueShare.Models.Dog", b =>
                {
                    b.HasOne("RescueShare.Models.Entities.DogBreed", "Breed")
                        .WithMany()
                        .HasForeignKey("BreedId");

                    b.HasOne("RescueShare.Models.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.HasOne("RescueShare.Models.Entities.Rescue")
                        .WithMany("Dogs")
                        .HasForeignKey("RescueId");

                    b.HasOne("RescueShare.Models.Shelter", "Shelter")
                        .WithMany("Dogs")
                        .HasForeignKey("ShelterId");

                    b.HasOne("RescueShare.Models.Space", "Space")
                        .WithMany("Dogs")
                        .HasForeignKey("SpaceId");
                });

            modelBuilder.Entity("RescueShare.Models.Entities.Opportunity", b =>
                {
                    b.HasOne("RescueShare.Models.Shelter", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("RescueShare.Models.Entities.OpportunityType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("RescueShare.Models.Entities.RescueMember", b =>
                {
                    b.HasOne("RescueShare.Models.Entities.Rescue", "Rescue")
                        .WithMany("Members")
                        .HasForeignKey("RescueId");

                    b.HasOne("RescueShare.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RescueShare.Models.Entities.UserDeniedDogBreed", b =>
                {
                    b.HasOne("RescueShare.Models.Entities.DogBreed", "DogBreed")
                        .WithMany()
                        .HasForeignKey("DogBreedId");

                    b.HasOne("RescueShare.Models.User", "User")
                        .WithMany("UserDeniedDogBreeds")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RescueShare.Models.Foster", b =>
                {
                    b.HasOne("RescueShare.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RescueShare.Models.ShelterMember", b =>
                {
                    b.HasOne("RescueShare.Models.Shelter", "Shelter")
                        .WithMany("Members")
                        .HasForeignKey("ShelterId");

                    b.HasOne("RescueShare.Models.User", "User")
                        .WithMany("Members")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RescueShare.Models.Space", b =>
                {
                    b.HasOne("RescueShare.Models.Shelter", "Shelter")
                        .WithMany("Space")
                        .HasForeignKey("ShelterId");
                });

            modelBuilder.Entity("RescueShare.Models.Transport", b =>
                {
                    b.HasOne("RescueShare.Models.Foster", "FosterReceiver")
                        .WithMany()
                        .HasForeignKey("FosterReceiverId");

                    b.HasOne("RescueShare.Models.Foster", "FosterSender")
                        .WithMany()
                        .HasForeignKey("FosterSenderId");

                    b.HasOne("RescueShare.Models.Entities.Rescue", "OrganizingRescue")
                        .WithMany()
                        .HasForeignKey("OrganizingRescueId");

                    b.HasOne("RescueShare.Models.Entities.Rescue", "RescueReceiver")
                        .WithMany()
                        .HasForeignKey("RescueReceiverId");

                    b.HasOne("RescueShare.Models.Entities.Rescue", "RescueSender")
                        .WithMany()
                        .HasForeignKey("RescueSenderId");

                    b.HasOne("RescueShare.Models.Shelter", "ShelterReceiver")
                        .WithMany()
                        .HasForeignKey("ShelterReceiverId");

                    b.HasOne("RescueShare.Models.Shelter", "ShelterSender")
                        .WithMany()
                        .HasForeignKey("ShelterSenderId");

                    b.HasOne("RescueShare.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RescueShare.Models.TransportMember", b =>
                {
                    b.HasOne("RescueShare.Models.Transport")
                        .WithMany("Transporters")
                        .HasForeignKey("TransportId");

                    b.HasOne("RescueShare.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RescueShare.Models.UserDeniedDogAge", b =>
                {
                    b.HasOne("RescueShare.Models.User")
                        .WithMany("UserDeniedDogAges")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RescueShare.Models.UserDeniedDogWeight", b =>
                {
                    b.HasOne("RescueShare.Models.User")
                        .WithMany("UserDeniedDogWeights")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RescueShare.Models.UserDeniedTemperment", b =>
                {
                    b.HasOne("RescueShare.Models.User")
                        .WithMany("UserDeniedTemperments")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
