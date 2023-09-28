using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShopAPI.Persistence.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class mig_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 925, DateTimeKind.Local).AddTicks(6311),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 58, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 924, DateTimeKind.Local).AddTicks(4729),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 56, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 924, DateTimeKind.Local).AddTicks(1093),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 56, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 923, DateTimeKind.Local).AddTicks(5242),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 55, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 922, DateTimeKind.Local).AddTicks(4912),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 54, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 921, DateTimeKind.Local).AddTicks(9534),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 54, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 921, DateTimeKind.Local).AddTicks(6203),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 54, DateTimeKind.Local).AddTicks(56));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 921, DateTimeKind.Local).AddTicks(205),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 53, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 920, DateTimeKind.Local).AddTicks(1484),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 52, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 919, DateTimeKind.Local).AddTicks(5377),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 51, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 918, DateTimeKind.Local).AddTicks(9671),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 45, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 918, DateTimeKind.Local).AddTicks(6913),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 44, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(9519),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 44, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 918, DateTimeKind.Local).AddTicks(4263),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 44, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(2832),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 43, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 42, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 916, DateTimeKind.Local).AddTicks(2930),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 41, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 916, DateTimeKind.Local).AddTicks(9609),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 42, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 915, DateTimeKind.Local).AddTicks(3819),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 40, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 915, DateTimeKind.Local).AddTicks(8527),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 41, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 914, DateTimeKind.Local).AddTicks(9959),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 40, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 914, DateTimeKind.Local).AddTicks(4210),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 39, DateTimeKind.Local).AddTicks(9134));

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

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 918, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 918, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 21, 10, 3, 34, 925, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 9, 21, 10, 3, 34, 925, DateTimeKind.Local).AddTicks(9940), new byte[] { 202, 187, 186, 136, 174, 188, 232, 77, 42, 124, 98, 157, 191, 51, 96, 142, 199, 117, 30, 9, 109, 214, 19, 225, 25, 16, 223, 150, 36, 233, 179, 158, 202, 51, 223, 125, 29, 74, 113, 20, 185, 119, 133, 20, 221, 56, 232, 178, 71, 125, 239, 130, 161, 175, 26, 254, 254, 84, 88, 194, 47, 198, 31, 140 }, new byte[] { 103, 166, 2, 92, 159, 236, 12, 136, 199, 242, 241, 141, 138, 101, 117, 140, 23, 5, 224, 128, 243, 25, 226, 92, 199, 246, 169, 6, 242, 97, 103, 232, 133, 125, 197, 125, 170, 120, 219, 116, 149, 16, 126, 173, 4, 20, 90, 95, 91, 252, 255, 204, 204, 229, 148, 124, 21, 192, 86, 83, 250, 146, 77, 221, 28, 152, 41, 121, 23, 96, 61, 128, 80, 68, 34, 12, 71, 20, 213, 68, 26, 229, 125, 152, 18, 99, 134, 207, 67, 237, 93, 140, 80, 211, 195, 247, 126, 18, 14, 241, 10, 26, 222, 176, 244, 127, 88, 130, 69, 120, 19, 143, 8, 9, 215, 82, 217, 153, 208, 60, 14, 94, 156, 94, 156, 99, 246, 44 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 58, DateTimeKind.Local).AddTicks(436),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 925, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserClaims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 56, DateTimeKind.Local).AddTicks(9211),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 924, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RefreshTokens",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 56, DateTimeKind.Local).AddTicks(5172),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 924, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Publishers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 55, DateTimeKind.Local).AddTicks(9182),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 923, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PhoneNumbers",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 54, DateTimeKind.Local).AddTicks(8646),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 922, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpRecoveryCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 54, DateTimeKind.Local).AddTicks(4165),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 921, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtpAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 54, DateTimeKind.Local).AddTicks(56),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 921, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Orders",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 53, DateTimeKind.Local).AddTicks(3103),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 921, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailComfirmCodes",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 52, DateTimeKind.Local).AddTicks(3190),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 920, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "MailAuthentications",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 51, DateTimeKind.Local).AddTicks(3997),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 919, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 45, DateTimeKind.Local).AddTicks(873),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 918, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Files",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 44, DateTimeKind.Local).AddTicks(8183),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 918, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Comments",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 44, DateTimeKind.Local).AddTicks(357),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "CommentRatings",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 44, DateTimeKind.Local).AddTicks(5561),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 918, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Claims",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 43, DateTimeKind.Local).AddTicks(176),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 42, DateTimeKind.Local).AddTicks(7949),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 917, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Books",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 41, DateTimeKind.Local).AddTicks(7848),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 916, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BookPictures",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 42, DateTimeKind.Local).AddTicks(4572),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 916, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Baskets",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 40, DateTimeKind.Local).AddTicks(8811),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 915, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "BasketItems",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 41, DateTimeKind.Local).AddTicks(3357),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 915, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Authors",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 40, DateTimeKind.Local).AddTicks(4844),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 914, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 13, 17, 42, 44, 39, DateTimeKind.Local).AddTicks(9134),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 10, 3, 34, 914, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 13, 17, 42, 44, 43, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Claims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 13, 17, 42, 44, 43, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 13, 17, 42, 44, 45, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 13, 17, 42, 44, 45, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 13, 17, 42, 44, 58, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 9, 13, 17, 42, 44, 58, DateTimeKind.Local).AddTicks(2797), new byte[] { 75, 19, 208, 224, 10, 197, 65, 186, 249, 173, 136, 39, 19, 141, 211, 166, 249, 157, 20, 82, 63, 149, 250, 144, 243, 95, 58, 8, 255, 108, 50, 160, 203, 164, 122, 104, 255, 167, 50, 253, 185, 228, 135, 21, 246, 206, 87, 168, 23, 207, 88, 28, 87, 223, 225, 194, 127, 112, 224, 21, 237, 158, 206, 252 }, new byte[] { 54, 165, 227, 243, 187, 2, 198, 25, 112, 200, 134, 145, 85, 79, 199, 53, 85, 215, 173, 139, 136, 113, 185, 230, 127, 197, 171, 242, 254, 56, 181, 176, 89, 219, 104, 16, 2, 133, 213, 241, 223, 127, 5, 65, 138, 104, 58, 25, 29, 15, 108, 73, 78, 196, 171, 130, 21, 238, 197, 43, 135, 234, 128, 151, 97, 42, 197, 156, 216, 122, 131, 158, 244, 153, 7, 118, 84, 220, 202, 184, 164, 176, 9, 117, 200, 72, 148, 85, 152, 219, 41, 54, 116, 0, 82, 158, 47, 163, 57, 10, 100, 11, 170, 108, 25, 114, 96, 225, 8, 7, 242, 7, 96, 177, 102, 228, 195, 113, 101, 224, 189, 23, 40, 237, 203, 252, 92, 116 } });
        }
    }
}
