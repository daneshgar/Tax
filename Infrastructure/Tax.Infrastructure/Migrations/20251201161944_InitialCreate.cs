using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tax.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaxItems");

            migrationBuilder.CreateTable(
                name: "InvoiceHeader",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Taxid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Indatim = table.Column<long>(type: "bigint", nullable: true),
                    Indati2m = table.Column<long>(type: "bigint", nullable: true),
                    Inty = table.Column<int>(type: "int", nullable: true),
                    Inno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Irtaxid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inp = table.Column<int>(type: "int", nullable: true),
                    Ins = table.Column<int>(type: "int", nullable: true),
                    Tins = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tob = table.Column<int>(type: "int", nullable: true),
                    Bid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tinb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sbc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bpc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bbc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ft = table.Column<int>(type: "int", nullable: true),
                    Bpn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Scln = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Scc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cdcn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cdcd = table.Column<int>(type: "int", nullable: true),
                    Crn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Billid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tonw = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Setm = table.Column<int>(type: "int", nullable: true),
                    Tinc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lrno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ocu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Sn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Did = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ba = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Btel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Semail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bemail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sccode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bccode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Scocode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bcocode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Refno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Refdt = table.Column<long>(type: "bigint", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceHeader", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceBody",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceHeaderId = table.Column<int>(type: "int", nullable: false),
                    Sstid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sstt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Am = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Mu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nw = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Cut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Vra = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Odt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Odr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Olt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Olr = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Bsrn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceBody", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceBody_InvoiceHeader_InvoiceHeaderId",
                        column: x => x.InvoiceHeaderId,
                        principalTable: "InvoiceHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoicePayment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceHeaderId = table.Column<int>(type: "int", nullable: false),
                    Iinn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trmn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pmt = table.Column<int>(type: "int", nullable: true),
                    Trn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pcn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pdt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoicePayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoicePayment_InvoiceHeader_InvoiceHeaderId",
                        column: x => x.InvoiceHeaderId,
                        principalTable: "InvoiceHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceBody_InvoiceHeaderId",
                table: "InvoiceBody",
                column: "InvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicePayment_InvoiceHeaderId",
                table: "InvoicePayment",
                column: "InvoiceHeaderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceBody");

            migrationBuilder.DropTable(
                name: "InvoicePayment");

            migrationBuilder.DropTable(
                name: "InvoiceHeader");

            migrationBuilder.CreateTable(
                name: "TaxItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsConfirm = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxItems", x => x.Id);
                });
        }
    }
}
