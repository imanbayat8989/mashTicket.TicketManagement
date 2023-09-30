﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mashTicket.TicketManagementPersistence.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderTotal = table.Column<int>(type: "int", nullable: false),
                    OrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderPaid = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"), "Musicals" },
                    { new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"), "Concerts" },
                    { new Guid("bf3f3002-7e53-441e-8b76-f6282be284aa"), "Plays" },
                    { new Guid("fe98f549-3790-4e9f-aa16-18c2292a2ee9"), "Conferences" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "OrderPaid", "OrderPlaced", "OrderTotal", "UserId" },
                values: new object[,]
                {
                    { new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2023, 9, 30, 12, 20, 21, 832, DateTimeKind.Local).AddTicks(2592), 245, new Guid("4ad901be-f447-46dd-bcf7-dbe401afa203") },
                    { new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2023, 9, 30, 12, 20, 21, 832, DateTimeKind.Local).AddTicks(2579), 85, new Guid("d97a15fc-0d32-41c6-9ddf-62f0735c4c1c") },
                    { new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2023, 9, 30, 12, 20, 21, 832, DateTimeKind.Local).AddTicks(2544), 400, new Guid("a441eb40-9636-4ee6-be49-a66c5ec1330b") },
                    { new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2023, 9, 30, 12, 20, 21, 832, DateTimeKind.Local).AddTicks(2566), 135, new Guid("ac3cfaf5-34fd-4e4d-bc04-ad1083ddc340") },
                    { new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2023, 9, 30, 12, 20, 21, 832, DateTimeKind.Local).AddTicks(2672), 116, new Guid("7aeb2c01-fe8e-4b84-a5ba-330bdf950f5c") },
                    { new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2023, 9, 30, 12, 20, 21, 832, DateTimeKind.Local).AddTicks(2645), 142, new Guid("7aeb2c01-fe8e-4b84-a5ba-330bdf950f5c") },
                    { new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2023, 9, 30, 12, 20, 21, 832, DateTimeKind.Local).AddTicks(2660), 40, new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923") }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Artist", "CategoryId", "Date", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"), "Jonbesh azady bakhsh Iran", new Guid("fe98f549-3790-4e9f-aa16-18c2292a2ee9"), new DateTime(2023, 9, 30, 12, 30, 21, 832, DateTimeKind.Local).AddTicks(2492), "baraye bade azady chegone ba hamkary hamdigar iran azad besazim", "https://i.pinimg.com/originals/f2/59/82/f2598292d4229b644442cc532f3f88c7.jpg", "Sakht Iran 2024 Bad Azadi", 0 },
                    { new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"), "Hichkas[Sourosh Lashkari]", new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"), new DateTime(2024, 6, 30, 12, 20, 21, 832, DateTimeKind.Local).AddTicks(2451), "Hichkas Live dar shahre mashhad", "https://wallpapercave.com/dwp1x/wp4648281.jpg", "Hichkas", 85 },
                    { new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"), "Ho3in Eblis", new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"), new DateTime(2024, 8, 30, 12, 20, 21, 832, DateTimeKind.Local).AddTicks(2479), "Ho3in back in the city", "https://i.pinimg.com/550x/4a/53/f5/4a53f54af90268b764cb54cd749de3dc.jpg", "Ho3in", 100 },
                    { new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"), "Nick Sailor", new Guid("6313179f-7837-473a-a4d5-a5571b43e6a6"), new DateTime(2024, 5, 30, 12, 20, 21, 832, DateTimeKind.Local).AddTicks(2524), "The critics are over the moon and so will you after you've watched this sing and dance extravaganza written by Nick Sailor, the man from 'My dad and sister'.", "https://gillcleerenpluralsight.blob.core.windows.net/files/GloboTicket/musical.jpg", "To the Moon and Back", 135 },
                    { new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"), "Yaser", new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"), new DateTime(2024, 7, 30, 12, 20, 21, 832, DateTimeKind.Local).AddTicks(2466), "Yas Live dar shahre mashhad", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a8/Yas%2C_Iranian_rapper_live_in_2018_03.jpg/1200px-Yas%2C_Iranian_rapper_live_in_2018_03.jpg?20200909164528", "Yas", 55 },
                    { new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"), "Bahram", new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"), new DateTime(2024, 3, 30, 12, 20, 21, 832, DateTimeKind.Local).AddTicks(2378), "Bahram concert baraye avalin bar dar shahr mashhad", "https://wallpapercave.com/dwp1x/wp3470498.jpg", "Bahram Live", 65 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoryId",
                table: "Events",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
