using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNameOfIDInShoppingCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCarts_ShoppingCarts_AddedShoppingCartMyProperty",
                table: "ProductInShoppingCarts");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "ShoppingCarts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AddedShoppingCartMyProperty",
                table: "ProductInShoppingCarts",
                newName: "AddedShoppingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInShoppingCarts_AddedShoppingCartMyProperty",
                table: "ProductInShoppingCarts",
                newName: "IX_ProductInShoppingCarts_AddedShoppingCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCarts_ShoppingCarts_AddedShoppingCartId",
                table: "ProductInShoppingCarts",
                column: "AddedShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCarts_ShoppingCarts_AddedShoppingCartId",
                table: "ProductInShoppingCarts");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ShoppingCarts",
                newName: "MyProperty");

            migrationBuilder.RenameColumn(
                name: "AddedShoppingCartId",
                table: "ProductInShoppingCarts",
                newName: "AddedShoppingCartMyProperty");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInShoppingCarts_AddedShoppingCartId",
                table: "ProductInShoppingCarts",
                newName: "IX_ProductInShoppingCarts_AddedShoppingCartMyProperty");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCarts_ShoppingCarts_AddedShoppingCartMyProperty",
                table: "ProductInShoppingCarts",
                column: "AddedShoppingCartMyProperty",
                principalTable: "ShoppingCarts",
                principalColumn: "MyProperty");
        }
    }
}
