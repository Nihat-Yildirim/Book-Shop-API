﻿// <auto-generated />
using System;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookShopAPI.Persistence.EntityFramework.Migrations
{
    [DbContext(typeof(BookShopDbContext))]
    [Migration("20230829115847_mig_2")]
    partial class mig_2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsId")
                        .HasColumnType("int");

                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.HasKey("AuthorsId", "BooksId");

                    b.HasIndex("BooksId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.HasKey("BooksId", "CategoriesId");

                    b.HasIndex("CategoriesId");

                    b.ToTable("BookCategory");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressTitle")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("VarChar");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 162, DateTimeKind.Local).AddTicks(4928));

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("DateTime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(125)
                        .HasColumnType("VarChar");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("VarChar");

                    b.Property<string>("Neighbourhood")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar");

                    b.Property<string>("OpenAddress")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("VarChar");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("VarChar");

                    b.Property<bool>("Selected")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AuthorPictureFileId")
                        .HasColumnType("int");

                    b.Property<string>("Autobiography")
                        .IsRequired()
                        .HasColumnType("VarChar(MAX)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 163, DateTimeKind.Local).AddTicks(390));

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("DateTime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("VarChar");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorPictureFileId")
                        .IsUnique()
                        .HasFilter("[AuthorPictureFileId] IS NOT NULL");

                    b.ToTable("Authors", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 163, DateTimeKind.Local).AddTicks(4294));

                    b.Property<bool>("IsCompleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Baskets", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BasketId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 163, DateTimeKind.Local).AddTicks(8931));

                    b.Property<byte>("Quantity")
                        .HasColumnType("TinyInt");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.HasIndex("BookId");

                    b.ToTable("BasketItems", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 164, DateTimeKind.Local).AddTicks(3876));

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("DateTime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("VarChar");

                    b.Property<string>("Dimension")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("VarChar");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("VarChar");

                    b.Property<int>("PageOfNumber")
                        .HasColumnType("Int");

                    b.Property<string>("PaperType")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("VarChar");

                    b.Property<decimal>("Price")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<string>("ReleaseDate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("Char");

                    b.Property<string>("SkinType")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("VarChar");

                    b.Property<short>("Stock")
                        .HasColumnType("SmallInt");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.BookPicture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("BookPictureFileId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 165, DateTimeKind.Local).AddTicks(3631));

                    b.Property<byte>("ShowOrder")
                        .HasColumnType("TinyInt");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("BookPictureFileId")
                        .IsUnique();

                    b.ToTable("BookPictures", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("VarChar");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 165, DateTimeKind.Local).AddTicks(6777));

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("DateTime2");

                    b.Property<int?>("ParentId")
                        .HasColumnType("Int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.Claim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 165, DateTimeKind.Local).AddTicks(8177));

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("DateTime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("VarChar");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("Id");

                    b.ToTable("Claims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Customer"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.FileEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 166, DateTimeKind.Local).AddTicks(593));

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("VarChar");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("VarChar");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("Id");

                    b.ToTable("Files", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.MailAuthentication", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("ActivationDuration")
                        .HasColumnType("DateTime2");

                    b.Property<string>("ActivationKey")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("Char");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 166, DateTimeKind.Local).AddTicks(7098));

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("Id");

                    b.ToTable("MailAuthentications", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.MailComfirmCode", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("ComfirmCode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("Char");

                    b.Property<DateTime>("ComfirmDuration")
                        .HasColumnType("DateTime2");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 167, DateTimeKind.Local).AddTicks(5071));

                    b.Property<bool>("IsComfirm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("Id");

                    b.ToTable("MailComfirmCodes", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.OtpAuthentication", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 168, DateTimeKind.Local).AddTicks(6731));

                    b.Property<bool>("IsVerified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Bit")
                        .HasDefaultValue(false);

                    b.Property<byte[]>("SecretKey")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("VarBinary");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("Id");

                    b.ToTable("OtpAuthentications", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.OtpRecoveryCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("Char");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 170, DateTimeKind.Local).AddTicks(1867));

                    b.Property<bool>("IsUse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Bit")
                        .HasDefaultValue(false);

                    b.Property<int>("OtpAuthenticationId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("Id");

                    b.HasIndex("OtpAuthenticationId");

                    b.ToTable("OtpRecoveryCodes", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.PhoneNumberEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 171, DateTimeKind.Local).AddTicks(5119));

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("DateTime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("Char");

                    b.Property<string>("PhoneTitle")
                        .HasMaxLength(45)
                        .HasColumnType("VarChar");

                    b.Property<bool>("Selected")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PhoneNumbers", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 173, DateTimeKind.Local).AddTicks(6904));

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("DateTime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar");

                    b.Property<int>("PublisherLogoFileId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("Id");

                    b.HasIndex("PublisherLogoFileId")
                        .IsUnique();

                    b.ToTable("Publishers", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 174, DateTimeKind.Local).AddTicks(3870));

                    b.Property<DateTime>("Expires")
                        .HasColumnType("DateTime2");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("Char");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("Id");

                    b.ToTable("RefreshTokens", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthenticatorType")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1)
                        .HasColumnType("Char")
                        .HasDefaultValue("None");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 175, DateTimeKind.Local).AddTicks(9552));

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("DateTime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VarChar");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("VarChar");

                    b.Property<bool>("IsComfirmed")
                        .HasColumnType("Bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VarChar");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("VarBinary");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("VarBinary");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.Property<int?>("UserAvatarFileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserAvatarFileId")
                        .IsUnique()
                        .HasFilter("[UserAvatarFileId] IS NOT NULL");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClaimId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime2")
                        .HasDefaultValue(new DateTime(2023, 8, 29, 14, 58, 47, 174, DateTimeKind.Local).AddTicks(8291));

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("DateTime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClaimId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("BookShopAPI.Domain.Entities.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopAPI.Domain.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.HasOne("BookShopAPI.Domain.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopAPI.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.Address", b =>
                {
                    b.HasOne("BookShopAPI.Domain.Entities.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.Author", b =>
                {
                    b.HasOne("BookShopAPI.Domain.Entities.FileEntity", "File")
                        .WithOne("Author")
                        .HasForeignKey("BookShopAPI.Domain.Entities.Author", "AuthorPictureFileId");

                    b.Navigation("File");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.Basket", b =>
                {
                    b.HasOne("BookShopAPI.Domain.Entities.User", "User")
                        .WithMany("Baskets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.BasketItem", b =>
                {
                    b.HasOne("BookShopAPI.Domain.Entities.Basket", "Basket")
                        .WithMany("BasketItems")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopAPI.Domain.Entities.Book", "Book")
                        .WithMany("BasketItems")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.Book", b =>
                {
                    b.HasOne("BookShopAPI.Domain.Entities.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.BookPicture", b =>
                {
                    b.HasOne("BookShopAPI.Domain.Entities.Book", "Book")
                        .WithMany("BookPictures")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopAPI.Domain.Entities.FileEntity", "File")
                        .WithOne("BookPicture")
                        .HasForeignKey("BookShopAPI.Domain.Entities.BookPicture", "BookPictureFileId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("File");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.MailAuthentication", b =>
                {
                    b.HasOne("BookShopAPI.Domain.Entities.User", "User")
                        .WithOne("MailAuthentication")
                        .HasForeignKey("BookShopAPI.Domain.Entities.MailAuthentication", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.MailComfirmCode", b =>
                {
                    b.HasOne("BookShopAPI.Domain.Entities.User", "User")
                        .WithOne("MailComfirmCode")
                        .HasForeignKey("BookShopAPI.Domain.Entities.MailComfirmCode", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.OtpAuthentication", b =>
                {
                    b.HasOne("BookShopAPI.Domain.Entities.User", "User")
                        .WithOne("OtpAuthentication")
                        .HasForeignKey("BookShopAPI.Domain.Entities.OtpAuthentication", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.OtpRecoveryCode", b =>
                {
                    b.HasOne("BookShopAPI.Domain.Entities.OtpAuthentication", "OtpAuthentication")
                        .WithMany("OtpRecoveryCodes")
                        .HasForeignKey("OtpAuthenticationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OtpAuthentication");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.PhoneNumberEntity", b =>
                {
                    b.HasOne("BookShopAPI.Domain.Entities.User", "User")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.Publisher", b =>
                {
                    b.HasOne("BookShopAPI.Domain.Entities.FileEntity", "File")
                        .WithOne("Publisher")
                        .HasForeignKey("BookShopAPI.Domain.Entities.Publisher", "PublisherLogoFileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("File");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.RefreshToken", b =>
                {
                    b.HasOne("BookShopAPI.Domain.Entities.User", "User")
                        .WithOne("RefreshToken")
                        .HasForeignKey("BookShopAPI.Domain.Entities.RefreshToken", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.User", b =>
                {
                    b.HasOne("BookShopAPI.Domain.Entities.FileEntity", "File")
                        .WithOne("User")
                        .HasForeignKey("BookShopAPI.Domain.Entities.User", "UserAvatarFileId");

                    b.Navigation("File");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.UserClaim", b =>
                {
                    b.HasOne("BookShopAPI.Domain.Entities.Claim", "Claim")
                        .WithMany("UserClaims")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShopAPI.Domain.Entities.User", "User")
                        .WithOne("UserClaim")
                        .HasForeignKey("BookShopAPI.Domain.Entities.UserClaim", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Claim");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.Basket", b =>
                {
                    b.Navigation("BasketItems");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.Book", b =>
                {
                    b.Navigation("BasketItems");

                    b.Navigation("BookPictures");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.Claim", b =>
                {
                    b.Navigation("UserClaims");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.FileEntity", b =>
                {
                    b.Navigation("Author");

                    b.Navigation("BookPicture");

                    b.Navigation("Publisher");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.OtpAuthentication", b =>
                {
                    b.Navigation("OtpRecoveryCodes");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookShopAPI.Domain.Entities.User", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Baskets");

                    b.Navigation("MailAuthentication");

                    b.Navigation("MailComfirmCode");

                    b.Navigation("OtpAuthentication");

                    b.Navigation("PhoneNumbers");

                    b.Navigation("RefreshToken");

                    b.Navigation("UserClaim");
                });
#pragma warning restore 612, 618
        }
    }
}
