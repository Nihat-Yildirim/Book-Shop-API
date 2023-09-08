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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 347, DateTimeKind.Local).AddTicks(4202)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 347, DateTimeKind.Local).AddTicks(5807)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 347, DateTimeKind.Local).AddTicks(8347)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 348, DateTimeKind.Local).AddTicks(1175)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorPictureFileId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "VarChar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    Autobiography = table.Column<string>(type: "VarChar(MAX)", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 345, DateTimeKind.Local).AddTicks(207)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 352, DateTimeKind.Local).AddTicks(6848)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 355, DateTimeKind.Local).AddTicks(3658)),
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
                    Description = table.Column<string>(type: "VarChar(250)", maxLength: 250, nullable: false),
                    ReleaseDate = table.Column<string>(type: "Char(10)", maxLength: 10, nullable: false),
                    PageOfNumber = table.Column<int>(type: "Int", nullable: false),
                    Stock = table.Column<short>(type: "SmallInt", nullable: false),
                    Price = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 346, DateTimeKind.Local).AddTicks(4577)),
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
                    Neighbourhood = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    OpenAddress = table.Column<string>(type: "VarChar(250)", maxLength: 250, nullable: false),
                    Selected = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 344, DateTimeKind.Local).AddTicks(4415)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 345, DateTimeKind.Local).AddTicks(4777)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 348, DateTimeKind.Local).AddTicks(6665)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 349, DateTimeKind.Local).AddTicks(2751)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 350, DateTimeKind.Local).AddTicks(7327)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 351, DateTimeKind.Local).AddTicks(5170)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 353, DateTimeKind.Local).AddTicks(6895)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 354, DateTimeKind.Local).AddTicks(891)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 347, DateTimeKind.Local).AddTicks(1480)),
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
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasketId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<byte>(type: "TinyInt", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 345, DateTimeKind.Local).AddTicks(9724)),
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
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasketId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    TotalPayment = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    Pay = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    PaymentDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Comfirm = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    ComfirmedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    Send = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    SendedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 350, DateTimeKind.Local).AddTicks(1497)),
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
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OtpRecoveryCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtpAuthenticationId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "Char(6)", maxLength: 6, nullable: false),
                    IsUse = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 9, 8, 12, 2, 29, 351, DateTimeKind.Local).AddTicks(1230)),
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
                name: "OrderPhoneNumber",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    PhoneNumbersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPhoneNumber", x => new { x.OrdersId, x.PhoneNumbersId });
                    table.ForeignKey(
                        name: "FK_OrderPhoneNumber_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderPhoneNumber_PhoneNumbers_PhoneNumbersId",
                        column: x => x.PhoneNumbersId,
                        principalTable: "PhoneNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                values: new object[] { 1, new DateTime(2023, 9, 8, 12, 2, 29, 355, DateTimeKind.Local).AddTicks(6081), null, "BookShopAdmin@gmail.com", "Admin", "Admin", new byte[] { 125, 84, 19, 226, 23, 150, 90, 115, 105, 233, 31, 24, 249, 233, 42, 243, 46, 244, 32, 227, 74, 205, 169, 188, 233, 151, 51, 101, 214, 136, 244, 203, 46, 197, 243, 242, 19, 40, 168, 160, 126, 87, 136, 14, 94, 38, 64, 211, 12, 2, 250, 73, 171, 61, 42, 99, 178, 112, 127, 150, 196, 50, 9, 53 }, new byte[] { 137, 138, 181, 111, 140, 238, 207, 217, 26, 243, 133, 150, 36, 191, 49, 246, 221, 174, 163, 202, 9, 86, 109, 193, 134, 4, 105, 203, 123, 51, 143, 27, 20, 3, 23, 229, 183, 255, 186, 59, 218, 122, 154, 77, 242, 118, 131, 97, 62, 161, 170, 201, 161, 14, 130, 119, 104, 21, 152, 176, 171, 115, 208, 30, 185, 129, 180, 112, 95, 116, 99, 24, 249, 207, 100, 251, 135, 36, 158, 49, 155, 228, 171, 84, 231, 46, 156, 228, 173, 179, 227, 100, 156, 183, 91, 91, 123, 188, 107, 252, 4, 132, 172, 86, 206, 38, 206, 1, 154, 121, 47, 45, 70, 141, 181, 139, 224, 95, 92, 59, 67, 185, 60, 227, 104, 77, 54, 94 }, null, null });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ClaimId", "CreatedDate", "UpdatedDate", "UserId" },
                values: new object[] { 1, 2, new DateTime(2023, 9, 8, 12, 2, 29, 355, DateTimeKind.Local).AddTicks(4967), null, 1 });

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
                name: "IX_OrderPhoneNumber_PhoneNumbersId",
                table: "OrderPhoneNumber",
                column: "PhoneNumbersId");

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
                name: "MailAuthentications");

            migrationBuilder.DropTable(
                name: "MailComfirmCodes");

            migrationBuilder.DropTable(
                name: "OrderPhoneNumber");

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
                name: "Books");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "OtpAuthentications");

            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Files");
        }
    }
}
