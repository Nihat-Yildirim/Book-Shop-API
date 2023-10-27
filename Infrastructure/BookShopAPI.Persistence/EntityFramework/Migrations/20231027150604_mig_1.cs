using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShopAPI.Persistence.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "Int", nullable: true),
                    CategoryName = table.Column<string>(type: "VarChar(75)", maxLength: 75, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(9116)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Claims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VarChar(25)", maxLength: 25, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 556, DateTimeKind.Local).AddTicks(813)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    FilePath = table.Column<string>(type: "VarChar(MAX)", nullable: false),
                    FileExtension = table.Column<string>(type: "VarChar(5)", maxLength: 5, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 558, DateTimeKind.Local).AddTicks(14)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 558, DateTimeKind.Local).AddTicks(3111)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VarChar(15)", maxLength: 15, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 562, DateTimeKind.Local).AddTicks(7703)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorPictureFileId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: false),
                    Autobiography = table.Column<string>(type: "VarChar(MAX)", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 553, DateTimeKind.Local).AddTicks(2973)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authors_Files_AuthorPictureFileId",
                        column: x => x.AuthorPictureFileId,
                        principalTable: "Files",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherLogoFileId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 563, DateTimeKind.Local).AddTicks(8186)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publishers_Files_PublisherLogoFileId",
                        column: x => x.PublisherLogoFileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAvatarFileId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "VarChar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "VarBinary(500)", maxLength: 500, nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "VarBinary(500)", maxLength: 500, nullable: false),
                    AuthenticatorType = table.Column<int>(type: "Int", maxLength: 1, nullable: false, defaultValue: 0),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 566, DateTimeKind.Local).AddTicks(955)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Files_UserAvatarFileId",
                        column: x => x.UserAvatarFileId,
                        principalTable: "Files",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "VarChar(30)", maxLength: 30, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 557, DateTimeKind.Local).AddTicks(7280)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    BookName = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    ISBN = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    PaperType = table.Column<string>(type: "VarChar(25)", maxLength: 25, nullable: false),
                    SkinType = table.Column<string>(type: "VarChar(25)", maxLength: 25, nullable: false),
                    Dimension = table.Column<string>(type: "VarChar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "VarChar(MAX)", maxLength: 250, nullable: false),
                    ReleaseDate = table.Column<string>(type: "Char(10)", maxLength: 10, nullable: false),
                    PageOfNumber = table.Column<int>(type: "Int", nullable: false),
                    Stock = table.Column<short>(type: "SmallInt", nullable: false),
                    Price = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 554, DateTimeKind.Local).AddTicks(8630)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AddressTitle = table.Column<string>(type: "VarChar(25)", maxLength: 25, nullable: false),
                    Description = table.Column<string>(type: "VarChar(125)", maxLength: 125, nullable: false),
                    Province = table.Column<string>(type: "VarChar(15)", maxLength: 15, nullable: false),
                    District = table.Column<string>(type: "VarChar(25)", maxLength: 25, nullable: false),
                    OpenAddress = table.Column<string>(type: "VarChar(250)", maxLength: 250, nullable: false),
                    Selected = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 552, DateTimeKind.Local).AddTicks(6623)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Visible = table.Column<bool>(type: "Bit", nullable: false, defaultValue: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 553, DateTimeKind.Local).AddTicks(7763)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Baskets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MailAuthentications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ActivationKey = table.Column<string>(type: "Char(6)", maxLength: 6, nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    ActivationDuration = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 558, DateTimeKind.Local).AddTicks(9193)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailAuthentications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MailAuthentications_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MailComfirmCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ComfirmCode = table.Column<string>(type: "Char(6)", maxLength: 6, nullable: false),
                    IsComfirm = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    ComfirmDuration = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 559, DateTimeKind.Local).AddTicks(6030)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailComfirmCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MailComfirmCodes_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtpAuthentications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    SecretKey = table.Column<byte[]>(type: "VarBinary(500)", maxLength: 500, nullable: false),
                    IsVerified = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 561, DateTimeKind.Local).AddTicks(6827)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtpAuthentications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtpAuthentications_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PhoneTitle = table.Column<string>(type: "VarChar(45)", maxLength: 45, nullable: true),
                    PhoneNumber = table.Column<string>(type: "Char(10)", maxLength: 10, nullable: false),
                    Selected = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 562, DateTimeKind.Local).AddTicks(5077)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "Char(36)", maxLength: 36, nullable: false),
                    Expires = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 564, DateTimeKind.Local).AddTicks(4157)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 564, DateTimeKind.Local).AddTicks(8454)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Claims_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "Claims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Neighbourhoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 560, DateTimeKind.Local).AddTicks(825)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighbourhoods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Neighbourhoods_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuthorBook",
                columns: table => new
                {
                    AuthorsId = table.Column<int>(type: "int", nullable: false),
                    BooksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBook", x => new { x.AuthorsId, x.BooksId });
                    table.ForeignKey(
                        name: "FK_AuthorBook_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookCategory",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    CategoriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategory", x => new { x.BooksId, x.CategoriesId });
                    table.ForeignKey(
                        name: "FK_BookCategory_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategory_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookPictures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    BookPictureFileId = table.Column<int>(type: "int", nullable: false),
                    ShowOrder = table.Column<byte>(type: "TinyInt", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 555, DateTimeKind.Local).AddTicks(7105)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookPictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookPictures_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookPictures_Files_BookPictureFileId",
                        column: x => x.BookPictureFileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ParentCommentId = table.Column<int>(type: "Int", nullable: false, defaultValue: 0),
                    Comment = table.Column<string>(type: "VarChar(1000)", maxLength: 1000, nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 556, DateTimeKind.Local).AddTicks(6731)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasketId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<byte>(type: "TinyInt", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 554, DateTimeKind.Local).AddTicks(3172)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtpRecoveryCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtpAuthenticationId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "Char(6)", maxLength: 6, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 562, DateTimeKind.Local).AddTicks(594)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtpRecoveryCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtpRecoveryCodes_OtpAuthentications_OtpAuthenticationId",
                        column: x => x.OtpAuthenticationId,
                        principalTable: "OtpAuthentications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasketId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    PhoneNumberId = table.Column<int>(type: "int", nullable: false),
                    TotalPayment = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    Pay = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    PaymentDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Comfirm = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    ComfirmedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Send = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    SendedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 561, DateTimeKind.Local).AddTicks(520)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_PhoneNumbers_PhoneNumberId",
                        column: x => x.PhoneNumberId,
                        principalTable: "PhoneNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommentRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: false),
                    Useful = table.Column<bool>(type: "Bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 10, 27, 18, 6, 4, 557, DateTimeKind.Local).AddTicks(2485)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentRatings_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommentRatings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "DeletedDate", "ParentId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Edebiyat", null, 0, null },
                    { 2, "Tarih", null, 0, null },
                    { 3, "Siyaset", null, 0, null },
                    { 4, "Ekonomi", null, 0, null },
                    { 5, "Eğitim", null, 0, null },
                    { 6, "Sınav", null, 0, null },
                    { 7, "Ders Kitapları", null, 0, null },
                    { 8, "Kişisel Gelişim", null, 0, null },
                    { 9, "Çocuk Kitapları", null, 0, null },
                    { 10, "Dünya Klasikleri", null, 0, null },
                    { 11, "Mitoloji Efsane", null, 0, null },
                    { 12, "Roman", null, 1, null },
                    { 13, "Öykü", null, 1, null },
                    { 14, "Masal", null, 1, null },
                    { 15, "Deneme", null, 1, null },
                    { 16, "Biyografi", null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Claims",
                columns: new[] { "Id", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, "Customer", null },
                    { 2, null, "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Türkçe", null },
                    { 2, "İngilizce", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UpdatedDate", "UserAvatarFileId" },
                values: new object[] { 1, new DateTime(2023, 10, 27, 18, 6, 4, 566, DateTimeKind.Local).AddTicks(3602), null, "BookShopAdmin@gmail.com", "Admin", "Admin", new byte[] { 3, 85, 244, 230, 24, 93, 54, 68, 60, 10, 48, 99, 111, 66, 73, 60, 18, 241, 87, 249, 47, 91, 234, 4, 84, 191, 234, 24, 208, 86, 210, 215, 24, 176, 67, 126, 7, 169, 9, 240, 42, 70, 7, 194, 139, 114, 188, 205, 63, 66, 115, 244, 7, 50, 240, 133, 58, 209, 27, 182, 122, 111, 194, 202 }, new byte[] { 196, 92, 71, 81, 38, 146, 22, 141, 243, 220, 124, 234, 151, 201, 49, 61, 116, 139, 170, 3, 119, 223, 151, 208, 228, 69, 239, 152, 68, 70, 246, 48, 42, 88, 203, 217, 128, 143, 235, 65, 88, 15, 106, 156, 124, 190, 66, 143, 100, 47, 110, 187, 122, 121, 103, 160, 11, 229, 252, 132, 3, 64, 9, 102, 1, 175, 18, 237, 216, 20, 40, 170, 76, 243, 133, 63, 70, 160, 205, 93, 210, 102, 49, 190, 211, 105, 254, 200, 110, 198, 100, 246, 153, 116, 183, 120, 40, 113, 117, 244, 128, 38, 13, 149, 232, 121, 31, 134, 0, 15, 33, 80, 26, 93, 36, 197, 108, 167, 41, 105, 3, 99, 12, 215, 30, 235, 72, 53 }, null, null });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ClaimId", "CreatedDate", "UpdatedDate", "UserId" },
                values: new object[] { 1, 2, new DateTime(2023, 10, 27, 18, 6, 4, 566, DateTimeKind.Local).AddTicks(2759), null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BooksId",
                table: "AuthorBook",
                column: "BooksId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_AuthorPictureFileId",
                table: "Authors",
                column: "AuthorPictureFileId",
                unique: true,
                filter: "[AuthorPictureFileId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_BasketId",
                table: "BasketItems",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_BookId",
                table: "BasketItems",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_UserId",
                table: "Baskets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCategory_CategoriesId",
                table: "BookCategory",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_BookPictures_BookId",
                table: "BookPictures",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookPictures_BookPictureFileId",
                table: "BookPictures",
                column: "BookPictureFileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_LanguageId",
                table: "Books",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentRatings_CommentId",
                table: "CommentRatings",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentRatings_UserId",
                table: "CommentRatings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BookId",
                table: "Comments",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_ProvinceId",
                table: "Districts",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Neighbourhoods_DistrictId",
                table: "Neighbourhoods",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BasketId",
                table: "Orders",
                column: "BasketId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PhoneNumberId",
                table: "Orders",
                column: "PhoneNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OtpRecoveryCodes_OtpAuthenticationId",
                table: "OtpRecoveryCodes",
                column: "OtpAuthenticationId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_UserId",
                table: "PhoneNumbers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Publishers_PublisherLogoFileId",
                table: "Publishers",
                column: "PublisherLogoFileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_ClaimId",
                table: "UserClaims",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserAvatarFileId",
                table: "Users",
                column: "UserAvatarFileId",
                unique: true,
                filter: "[UserAvatarFileId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "BookCategory");

            migrationBuilder.DropTable(
                name: "BookPictures");

            migrationBuilder.DropTable(
                name: "CommentRatings");

            migrationBuilder.DropTable(
                name: "MailAuthentications");

            migrationBuilder.DropTable(
                name: "MailComfirmCodes");

            migrationBuilder.DropTable(
                name: "Neighbourhoods");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "OtpRecoveryCodes");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "OtpAuthentications");

            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "Files");
        }
    }
}
