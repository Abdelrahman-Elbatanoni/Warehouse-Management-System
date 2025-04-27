using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeasurementUnit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Secretaries",
                columns: table => new
                {
                    Secretary_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secretaries", x => x.Secretary_Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockReleaseVouchers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockReleaseVouchers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockReleaseVouchers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecretaryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warehouses_Secretaries_SecretaryId",
                        column: x => x.SecretaryId,
                        principalTable: "Secretaries",
                        principalColumn: "Secretary_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplyVouchers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    VoucherDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyVouchers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupplyVouchers_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockReleaseVoucherItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockReleaseVoucherId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockReleaseVoucherItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockReleaseVoucherItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockReleaseVoucherItems_StockReleaseVouchers_StockReleaseVoucherId",
                        column: x => x.StockReleaseVoucherId,
                        principalTable: "StockReleaseVouchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransferVouchers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SourceWarehouseId = table.Column<int>(type: "int", nullable: true),
                    TargetWarehouseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferVouchers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransferVouchers_Warehouses_SourceWarehouseId",
                        column: x => x.SourceWarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransferVouchers_Warehouses_TargetWarehouseId",
                        column: x => x.TargetWarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SupplyVoucherItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplyVoucherId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyVoucherItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupplyVoucherItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyVoucherItems_SupplyVouchers_SupplyVoucherId",
                        column: x => x.SupplyVoucherId,
                        principalTable: "SupplyVouchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseItems",
                columns: table => new
                {
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    SupplyVoucherId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseItems", x => new { x.ItemId, x.WarehouseId, x.SupplyVoucherId });
                    table.ForeignKey(
                        name: "FK_WarehouseItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WarehouseItems_SupplyVouchers_SupplyVoucherId",
                        column: x => x.SupplyVoucherId,
                        principalTable: "SupplyVouchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WarehouseItems_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockReleaseVoucherItemWarehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockReleaseVoucherItemId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockReleaseVoucherItemWarehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockReleaseVoucherItemWarehouses_StockReleaseVoucherItems_StockReleaseVoucherItemId",
                        column: x => x.StockReleaseVoucherItemId,
                        principalTable: "StockReleaseVoucherItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockReleaseVoucherItemWarehouses_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransferVoucherItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferVoucherId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferVoucherItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransferVoucherItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransferVoucherItems_TransferVouchers_TransferVoucherId",
                        column: x => x.TransferVoucherId,
                        principalTable: "TransferVouchers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplyVoucherItemWarehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplyVoucherItemId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyVoucherItemWarehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupplyVoucherItemWarehouses_SupplyVoucherItems_SupplyVoucherItemId",
                        column: x => x.SupplyVoucherItemId,
                        principalTable: "SupplyVoucherItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplyVoucherItemWarehouses_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockReleaseVoucherItems_ItemId",
                table: "StockReleaseVoucherItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StockReleaseVoucherItems_StockReleaseVoucherId",
                table: "StockReleaseVoucherItems",
                column: "StockReleaseVoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_StockReleaseVoucherItemWarehouses_StockReleaseVoucherItemId",
                table: "StockReleaseVoucherItemWarehouses",
                column: "StockReleaseVoucherItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StockReleaseVoucherItemWarehouses_WarehouseId",
                table: "StockReleaseVoucherItemWarehouses",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_StockReleaseVouchers_CustomerId",
                table: "StockReleaseVouchers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyVoucherItems_ItemId",
                table: "SupplyVoucherItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyVoucherItems_SupplyVoucherId",
                table: "SupplyVoucherItems",
                column: "SupplyVoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyVoucherItemWarehouses_SupplyVoucherItemId",
                table: "SupplyVoucherItemWarehouses",
                column: "SupplyVoucherItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyVoucherItemWarehouses_WarehouseId",
                table: "SupplyVoucherItemWarehouses",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyVouchers_SupplierId",
                table: "SupplyVouchers",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferVoucherItems_ItemId",
                table: "TransferVoucherItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferVoucherItems_TransferVoucherId",
                table: "TransferVoucherItems",
                column: "TransferVoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferVouchers_SourceWarehouseId",
                table: "TransferVouchers",
                column: "SourceWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferVouchers_TargetWarehouseId",
                table: "TransferVouchers",
                column: "TargetWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseItems_SupplyVoucherId",
                table: "WarehouseItems",
                column: "SupplyVoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_WarehouseItems_WarehouseId",
                table: "WarehouseItems",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_SecretaryId",
                table: "Warehouses",
                column: "SecretaryId",
                unique: true,
                filter: "[SecretaryId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockReleaseVoucherItemWarehouses");

            migrationBuilder.DropTable(
                name: "SupplyVoucherItemWarehouses");

            migrationBuilder.DropTable(
                name: "TransferVoucherItems");

            migrationBuilder.DropTable(
                name: "WarehouseItems");

            migrationBuilder.DropTable(
                name: "StockReleaseVoucherItems");

            migrationBuilder.DropTable(
                name: "SupplyVoucherItems");

            migrationBuilder.DropTable(
                name: "TransferVouchers");

            migrationBuilder.DropTable(
                name: "StockReleaseVouchers");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "SupplyVouchers");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Secretaries");
        }
    }
}
