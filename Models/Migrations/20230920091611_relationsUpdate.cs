//using Microsoft.EntityFrameworkCore.Migrations;

//#nullable disable

//namespace Data.Migrations
//{
//    /// <inheritdoc />
//    public partial class relationsUpdate : Migration
//    {
//        /// <inheritdoc />
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropForeignKey(
//                name: "FK_Contracts_Properties_Id",
//                table: "Contracts");

//            migrationBuilder.DropForeignKey(
//                name: "FK_Contracts_Properties_PropertyId",
//                table: "Contracts");

//            migrationBuilder.DropForeignKey(
//                name: "FK_Contracts_Users_Id",
//                table: "Contracts");

//            migrationBuilder.DropForeignKey(
//                name: "FK_Contracts_Users_UserId",
//                table: "Contracts");

//            migrationBuilder.AlterColumn<int>(
//                name: "Id",
//                table: "Contracts",
//                type: "int",
//                nullable: false,
//                oldClrType: typeof(int),
//                oldType: "int")
//                .Annotation("SqlServer:Identity", "1, 1");

//            migrationBuilder.AddColumn<int>(
//                name: "PropertyId1",
//                table: "Contracts",
//                type: "int",
//                nullable: true);

//            migrationBuilder.AddColumn<int>(
//                name: "UserId1",
//                table: "Contracts",
//                type: "int",
//                nullable: true);

//            migrationBuilder.CreateIndex(
//                name: "IX_Contracts_PropertyId1",
//                table: "Contracts",
//                column: "PropertyId1");

//            migrationBuilder.CreateIndex(
//                name: "IX_Contracts_UserId1",
//                table: "Contracts",
//                column: "UserId1");

//            migrationBuilder.AddForeignKey(
//                name: "FK_Contracts_Properties_PropertyId",
//                table: "Contracts",
//                column: "PropertyId",
//                principalTable: "Properties",
//                principalColumn: "Id");

//            migrationBuilder.AddForeignKey(
//                name: "FK_Contracts_Properties_PropertyId1",
//                table: "Contracts",
//                column: "PropertyId1",
//                principalTable: "Properties",
//                principalColumn: "Id");

//            migrationBuilder.AddForeignKey(
//                name: "FK_Contracts_Users_UserId",
//                table: "Contracts",
//                column: "UserId",
//                principalTable: "Users",
//                principalColumn: "Id");

//            migrationBuilder.AddForeignKey(
//                name: "FK_Contracts_Users_UserId1",
//                table: "Contracts",
//                column: "UserId1",
//                principalTable: "Users",
//                principalColumn: "Id");
//        }

//        /// <inheritdoc />
//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropForeignKey(
//                name: "FK_Contracts_Properties_PropertyId",
//                table: "Contracts");

//            migrationBuilder.DropForeignKey(
//                name: "FK_Contracts_Properties_PropertyId1",
//                table: "Contracts");

//            migrationBuilder.DropForeignKey(
//                name: "FK_Contracts_Users_UserId",
//                table: "Contracts");

//            migrationBuilder.DropForeignKey(
//                name: "FK_Contracts_Users_UserId1",
//                table: "Contracts");

//            migrationBuilder.DropIndex(
//                name: "IX_Contracts_PropertyId1",
//                table: "Contracts");

//            migrationBuilder.DropIndex(
//                name: "IX_Contracts_UserId1",
//                table: "Contracts");

//            migrationBuilder.DropColumn(
//                name: "PropertyId1",
//                table: "Contracts");

//            migrationBuilder.DropColumn(
//                name: "UserId1",
//                table: "Contracts");

//            migrationBuilder.AlterColumn<int>(
//                name: "Id",
//                table: "Contracts",
//                type: "int",
//                nullable: false,
//                oldClrType: typeof(int),
//                oldType: "int")
//                .OldAnnotation("SqlServer:Identity", "1, 1");

//            migrationBuilder.AddForeignKey(
//                name: "FK_Contracts_Properties_Id",
//                table: "Contracts",
//                column: "Id",
//                principalTable: "Properties",
//                principalColumn: "Id");

//            migrationBuilder.AddForeignKey(
//                name: "FK_Contracts_Properties_PropertyId",
//                table: "Contracts",
//                column: "PropertyId",
//                principalTable: "Properties",
//                principalColumn: "Id",
//                onDelete: ReferentialAction.Cascade);

//            migrationBuilder.AddForeignKey(
//                name: "FK_Contracts_Users_Id",
//                table: "Contracts",
//                column: "Id",
//                principalTable: "Users",
//                principalColumn: "Id");

//            migrationBuilder.AddForeignKey(
//                name: "FK_Contracts_Users_UserId",
//                table: "Contracts",
//                column: "UserId",
//                principalTable: "Users",
//                principalColumn: "Id",
//                onDelete: ReferentialAction.Cascade);
//        }
//    }
//}
