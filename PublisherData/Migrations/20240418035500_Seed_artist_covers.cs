using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PublisherData.Migrations
{
    /// <inheritdoc />
    public partial class Seed_artist_covers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Omar", "Ahmad" },
                    { 2, "Mariam", "Ahmad" },
                    { 3, "Yosuf", "Ahmad" }
                });

            migrationBuilder.InsertData(
                table: "Covers",
                columns: new[] { "Id", "DesignIdeas", "DigitalOnly" },
                values: new object[,]
                {
                    { 1, "How is?", false },
                    { 2, "How are?", true },
                    { 3, "How am?", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Covers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Covers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Covers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Rhoda", "Lerman" },
                    { 2, "Ruth", "Ozeki" },
                    { 3, "Sofia", "Segovia" },
                    { 4, "Ursula K.", "LeGuin" },
                    { 5, "Hugh", "Howey" },
                    { 6, "Isabelle", "Allende" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, 0m, new DateOnly(1989, 3, 1), "In God's Ear" },
                    { 2, 2, 0m, new DateOnly(2013, 12, 31), "A Tale For the Time Being" },
                    { 3, 3, 0m, new DateOnly(1969, 3, 1), "The Left Hand of Darkness" }
                });
        }
    }
}
