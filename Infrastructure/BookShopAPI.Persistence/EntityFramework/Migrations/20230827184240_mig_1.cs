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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 816, DateTimeKind.Local).AddTicks(1723)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 816, DateTimeKind.Local).AddTicks(2990)),
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
                    FilePath = table.Column<string>(type: "VarChar", nullable: false),
                    FileExtension = table.Column<string>(type: "VarChar(5)", maxLength: 5, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 816, DateTimeKind.Local).AddTicks(5109)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 814, DateTimeKind.Local).AddTicks(1971)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 819, DateTimeKind.Local).AddTicks(4462)),
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
                    IsComfirmed = table.Column<bool>(type: "Bit", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "VarBinary(500)", maxLength: 500, nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "VarBinary(500)", maxLength: 500, nullable: false),
                    AuthenticatorType = table.Column<string>(type: "Char(1)", maxLength: 1, nullable: false, defaultValue: "None"),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 822, DateTimeKind.Local).AddTicks(210)),
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
                    BookName = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    Language = table.Column<string>(type: "VarChar(15)", maxLength: 15, nullable: false),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 815, DateTimeKind.Local).AddTicks(3380)),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 813, DateTimeKind.Local).AddTicks(6724)),
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
                    IsCompleted = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 814, DateTimeKind.Local).AddTicks(5446)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 817, DateTimeKind.Local).AddTicks(103)),
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
                name: "OtpAuthentications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    SecretKey = table.Column<byte[]>(type: "VarBinary(500)", maxLength: 500, nullable: false),
                    IsVerified = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 817, DateTimeKind.Local).AddTicks(5644)),
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
                    PhoneNumber = table.Column<string>(type: "Char(12)", maxLength: 12, nullable: false),
                    Selected = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    DeletedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 818, DateTimeKind.Local).AddTicks(2584)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 820, DateTimeKind.Local).AddTicks(556)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 820, DateTimeKind.Local).AddTicks(6151)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 815, DateTimeKind.Local).AddTicks(9411)),
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
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 814, DateTimeKind.Local).AddTicks(9501)),
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
                    IsUse = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false, defaultValue: new DateTime(2023, 8, 27, 21, 42, 40, 817, DateTimeKind.Local).AddTicks(9006)),
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

            migrationBuilder.InsertData(
                table: "Claims",
                columns: new[] { "Id", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, "Customer", null },
                    { 2, null, "Admin", null }
                });

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
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

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
                name: "Addresses");

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
                name: "OtpRecoveryCodes");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "OtpAuthentications");

            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Files");
        }
    }
}
