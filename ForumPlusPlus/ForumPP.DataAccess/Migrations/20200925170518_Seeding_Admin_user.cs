using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ForumPP.DataAccess.Migrations
{
    public partial class Seeding_Admin_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "538fd7ca-d851-4b6c-a32f-774b717ffe57", "e9ef2f8b-2080-4ab6-9966-1a57aa06e359", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IsActive", "LockoutEnabled", "LockoutEnd", "MemberSince", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "Rating", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1afe9b22-eb1e-4eef-b7d8-ebe3467dd52e", 0, "040814e6-f70e-41fe-b12a-30a4c1afcf00", "admin@mail.com", true, false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@mail.com", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEAYS/Xff8StMSSojdXTQdZBh9SocQfliQPpdQi677C2IQWtO0tRTrwtugK/xBH2jTA==", null, false, null, 0, "", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "1afe9b22-eb1e-4eef-b7d8-ebe3467dd52e", "538fd7ca-d851-4b6c-a32f-774b717ffe57" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1afe9b22-eb1e-4eef-b7d8-ebe3467dd52e", "538fd7ca-d851-4b6c-a32f-774b717ffe57" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "538fd7ca-d851-4b6c-a32f-774b717ffe57", "e9ef2f8b-2080-4ab6-9966-1a57aa06e359" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1afe9b22-eb1e-4eef-b7d8-ebe3467dd52e", "040814e6-f70e-41fe-b12a-30a4c1afcf00" });
        }
    }
}
