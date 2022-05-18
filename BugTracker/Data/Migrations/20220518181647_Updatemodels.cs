using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Data.Migrations
{
    public partial class Updatemodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projectsusers_AspNetUsers_usersId",
                table: "Projectsusers");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticketattachments_tickets_ticketsId",
                table: "Ticketattachments");

            migrationBuilder.DropForeignKey(
                name: "FK_ticketcomments_tickets_ticketsId",
                table: "ticketcomments");

            migrationBuilder.DropForeignKey(
                name: "FK_tickethistories_tickets_ticketsId",
                table: "tickethistories");

            migrationBuilder.DropForeignKey(
                name: "FK_ticketnotifications_AspNetUsers_UserId",
                table: "ticketnotifications");

            migrationBuilder.DropForeignKey(
                name: "FK_ticketnotifications_tickets_ticketsId",
                table: "ticketnotifications");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_AspNetUsers_OwnerUserId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_Projects_ProjectId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_TicketPriorities_ticketprioritiesId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_ticketstatuses_ticketstatusesId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_tickettypes_tickettypeId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_tickettypeId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_ticketnotifications_UserId",
                table: "ticketnotifications");

            migrationBuilder.DropColumn(
                name: "TickedTypeId",
                table: "tickets");

            migrationBuilder.RenameColumn(
                name: "tickettypeId",
                table: "tickets",
                newName: "TicketTypeId");

            migrationBuilder.RenameColumn(
                name: "ticketstatusesId",
                table: "tickets",
                newName: "TicketStatusesId");

            migrationBuilder.RenameColumn(
                name: "ticketprioritiesId",
                table: "tickets",
                newName: "TicketPrioritiesId");

            migrationBuilder.RenameColumn(
                name: "Descripiton",
                table: "tickets",
                newName: "Description");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_ticketstatusesId",
                table: "tickets",
                newName: "IX_tickets_TicketStatusesId");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_ticketprioritiesId",
                table: "tickets",
                newName: "IX_tickets_TicketPrioritiesId");

            migrationBuilder.RenameColumn(
                name: "usersId",
                table: "Projectsusers",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Projectsusers_usersId",
                table: "Projectsusers",
                newName: "IX_Projectsusers_UsersId");

            migrationBuilder.AlterColumn<int>(
                name: "TicketStatusId",
                table: "tickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TicketPriorityId",
                table: "tickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "tickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OwnerUserId",
                table: "tickets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssignedToUserId",
                table: "tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TicketTypesId",
                table: "tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "tickets",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ticketsId",
                table: "ticketnotifications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ticketnotifications",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "ticketnotifications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ticketsId",
                table: "tickethistories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ticketsId",
                table: "ticketcomments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ticketsId",
                table: "Ticketattachments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tickets_TicketTypesId",
                table: "tickets",
                column: "TicketTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_UsersId",
                table: "tickets",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_ticketnotifications_UsersId",
                table: "ticketnotifications",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projectsusers_AspNetUsers_UsersId",
                table: "Projectsusers",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticketattachments_tickets_ticketsId",
                table: "Ticketattachments",
                column: "ticketsId",
                principalTable: "tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ticketcomments_tickets_ticketsId",
                table: "ticketcomments",
                column: "ticketsId",
                principalTable: "tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickethistories_tickets_ticketsId",
                table: "tickethistories",
                column: "ticketsId",
                principalTable: "tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ticketnotifications_AspNetUsers_UsersId",
                table: "ticketnotifications",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ticketnotifications_tickets_ticketsId",
                table: "ticketnotifications",
                column: "ticketsId",
                principalTable: "tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_AspNetUsers_OwnerUserId",
                table: "tickets",
                column: "OwnerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_AspNetUsers_UsersId",
                table: "tickets",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_Projects_ProjectId",
                table: "tickets",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_TicketPriorities_TicketPrioritiesId",
                table: "tickets",
                column: "TicketPrioritiesId",
                principalTable: "TicketPriorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_ticketstatuses_TicketStatusesId",
                table: "tickets",
                column: "TicketStatusesId",
                principalTable: "ticketstatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_tickettypes_TicketTypesId",
                table: "tickets",
                column: "TicketTypesId",
                principalTable: "tickettypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projectsusers_AspNetUsers_UsersId",
                table: "Projectsusers");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticketattachments_tickets_ticketsId",
                table: "Ticketattachments");

            migrationBuilder.DropForeignKey(
                name: "FK_ticketcomments_tickets_ticketsId",
                table: "ticketcomments");

            migrationBuilder.DropForeignKey(
                name: "FK_tickethistories_tickets_ticketsId",
                table: "tickethistories");

            migrationBuilder.DropForeignKey(
                name: "FK_ticketnotifications_AspNetUsers_UsersId",
                table: "ticketnotifications");

            migrationBuilder.DropForeignKey(
                name: "FK_ticketnotifications_tickets_ticketsId",
                table: "ticketnotifications");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_AspNetUsers_OwnerUserId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_AspNetUsers_UsersId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_Projects_ProjectId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_TicketPriorities_TicketPrioritiesId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_ticketstatuses_TicketStatusesId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_tickettypes_TicketTypesId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_TicketTypesId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_UsersId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_ticketnotifications_UsersId",
                table: "ticketnotifications");

            migrationBuilder.DropColumn(
                name: "TicketTypesId",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "ticketnotifications");

            migrationBuilder.RenameColumn(
                name: "TicketTypeId",
                table: "tickets",
                newName: "tickettypeId");

            migrationBuilder.RenameColumn(
                name: "TicketStatusesId",
                table: "tickets",
                newName: "ticketstatusesId");

            migrationBuilder.RenameColumn(
                name: "TicketPrioritiesId",
                table: "tickets",
                newName: "ticketprioritiesId");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "tickets",
                newName: "Descripiton");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_TicketStatusesId",
                table: "tickets",
                newName: "IX_tickets_ticketstatusesId");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_TicketPrioritiesId",
                table: "tickets",
                newName: "IX_tickets_ticketprioritiesId");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "Projectsusers",
                newName: "usersId");

            migrationBuilder.RenameIndex(
                name: "IX_Projectsusers_UsersId",
                table: "Projectsusers",
                newName: "IX_Projectsusers_usersId");

            migrationBuilder.AlterColumn<int>(
                name: "TicketStatusId",
                table: "tickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TicketPriorityId",
                table: "tickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "tickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerUserId",
                table: "tickets",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "AssignedToUserId",
                table: "tickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "TickedTypeId",
                table: "tickets",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ticketsId",
                table: "ticketnotifications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ticketnotifications",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ticketsId",
                table: "tickethistories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ticketsId",
                table: "ticketcomments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ticketsId",
                table: "Ticketattachments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_tickettypeId",
                table: "tickets",
                column: "tickettypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ticketnotifications_UserId",
                table: "ticketnotifications",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projectsusers_AspNetUsers_usersId",
                table: "Projectsusers",
                column: "usersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticketattachments_tickets_ticketsId",
                table: "Ticketattachments",
                column: "ticketsId",
                principalTable: "tickets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ticketcomments_tickets_ticketsId",
                table: "ticketcomments",
                column: "ticketsId",
                principalTable: "tickets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tickethistories_tickets_ticketsId",
                table: "tickethistories",
                column: "ticketsId",
                principalTable: "tickets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ticketnotifications_AspNetUsers_UserId",
                table: "ticketnotifications",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ticketnotifications_tickets_ticketsId",
                table: "ticketnotifications",
                column: "ticketsId",
                principalTable: "tickets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_AspNetUsers_OwnerUserId",
                table: "tickets",
                column: "OwnerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_Projects_ProjectId",
                table: "tickets",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_TicketPriorities_ticketprioritiesId",
                table: "tickets",
                column: "ticketprioritiesId",
                principalTable: "TicketPriorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_ticketstatuses_ticketstatusesId",
                table: "tickets",
                column: "ticketstatusesId",
                principalTable: "ticketstatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_tickettypes_tickettypeId",
                table: "tickets",
                column: "tickettypeId",
                principalTable: "tickettypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
