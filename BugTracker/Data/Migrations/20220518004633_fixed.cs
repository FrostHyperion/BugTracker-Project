using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Data.Migrations
{
    public partial class @fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUsers_AspNetUsers_UsersId",
                table: "ProjectUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectUsers_Projects_ProjectId",
                table: "ProjectUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketAttachments_AspNetUsers_usersId",
                table: "TicketAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketAttachments_Tickets_ticketsId",
                table: "TicketAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketComments_AspNetUsers_usersId",
                table: "TicketComments");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketComments_Tickets_ticketsId",
                table: "TicketComments");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketHistories_AspNetUsers_UsersId",
                table: "TicketHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketHistories_Tickets_ticketsId",
                table: "TicketHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketNotifications_AspNetUsers_UsersId",
                table: "TicketNotifications");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketNotifications_Tickets_ticketsId",
                table: "TicketNotifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_UsersId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Projects_ProjectId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_TicketPriorities_ticketprioritiesId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_TicketStatuses_ticketstatusesId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_TicketTypes_tickettypeId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketTypes",
                table: "TicketTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketStatuses",
                table: "TicketStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketNotifications",
                table: "TicketNotifications");

            migrationBuilder.DropIndex(
                name: "IX_TicketNotifications_UsersId",
                table: "TicketNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketHistories",
                table: "TicketHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketComments",
                table: "TicketComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketAttachments",
                table: "TicketAttachments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectUsers",
                table: "ProjectUsers");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "TicketNotifications");

            migrationBuilder.RenameTable(
                name: "TicketTypes",
                newName: "tickettypes");

            migrationBuilder.RenameTable(
                name: "TicketStatuses",
                newName: "ticketstatuses");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "tickets");

            migrationBuilder.RenameTable(
                name: "TicketNotifications",
                newName: "ticketnotifications");

            migrationBuilder.RenameTable(
                name: "TicketHistories",
                newName: "tickethistories");

            migrationBuilder.RenameTable(
                name: "TicketComments",
                newName: "ticketcomments");

            migrationBuilder.RenameTable(
                name: "TicketAttachments",
                newName: "Ticketattachments");

            migrationBuilder.RenameTable(
                name: "ProjectUsers",
                newName: "Projectsusers");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "tickets",
                newName: "AssignedToUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_tickettypeId",
                table: "tickets",
                newName: "IX_tickets_tickettypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ticketstatusesId",
                table: "tickets",
                newName: "IX_tickets_ticketstatusesId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ticketprioritiesId",
                table: "tickets",
                newName: "IX_tickets_ticketprioritiesId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ProjectId",
                table: "tickets",
                newName: "IX_tickets_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_UsersId",
                table: "tickets",
                newName: "IX_tickets_AssignedToUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_TicketNotifications_ticketsId",
                table: "ticketnotifications",
                newName: "IX_ticketnotifications_ticketsId");

            migrationBuilder.RenameIndex(
                name: "IX_TicketHistories_UsersId",
                table: "tickethistories",
                newName: "IX_tickethistories_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_TicketHistories_ticketsId",
                table: "tickethistories",
                newName: "IX_tickethistories_ticketsId");

            migrationBuilder.RenameIndex(
                name: "IX_TicketComments_usersId",
                table: "ticketcomments",
                newName: "IX_ticketcomments_usersId");

            migrationBuilder.RenameIndex(
                name: "IX_TicketComments_ticketsId",
                table: "ticketcomments",
                newName: "IX_ticketcomments_ticketsId");

            migrationBuilder.RenameIndex(
                name: "IX_TicketAttachments_usersId",
                table: "Ticketattachments",
                newName: "IX_Ticketattachments_usersId");

            migrationBuilder.RenameIndex(
                name: "IX_TicketAttachments_ticketsId",
                table: "Ticketattachments",
                newName: "IX_Ticketattachments_ticketsId");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "Projectsusers",
                newName: "usersId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectUsers_UsersId",
                table: "Projectsusers",
                newName: "IX_Projectsusers_usersId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectUsers_ProjectId",
                table: "Projectsusers",
                newName: "IX_Projectsusers_ProjectId");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerUserId",
                table: "tickets",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "ticketnotifications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ticketsId",
                table: "tickethistories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "tickethistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "tickethistories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "usersId",
                table: "ticketcomments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "ticketsId",
                table: "ticketcomments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ticketcomments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "ticketcomments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "usersId",
                table: "Ticketattachments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "ticketsId",
                table: "Ticketattachments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Ticketattachments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "Ticketattachments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Projectsusers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Projectsusers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tickettypes",
                table: "tickettypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ticketstatuses",
                table: "ticketstatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tickets",
                table: "tickets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ticketnotifications",
                table: "ticketnotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tickethistories",
                table: "tickethistories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ticketcomments",
                table: "ticketcomments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ticketattachments",
                table: "Ticketattachments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projectsusers",
                table: "Projectsusers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_OwnerUserId",
                table: "tickets",
                column: "OwnerUserId");

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
                name: "FK_Projectsusers_Projects_ProjectId",
                table: "Projectsusers",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticketattachments_AspNetUsers_usersId",
                table: "Ticketattachments",
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
                name: "FK_ticketcomments_AspNetUsers_usersId",
                table: "ticketcomments",
                column: "usersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ticketcomments_tickets_ticketsId",
                table: "ticketcomments",
                column: "ticketsId",
                principalTable: "tickets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tickethistories_AspNetUsers_UsersId",
                table: "tickethistories",
                column: "UsersId",
                principalTable: "AspNetUsers",
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
                name: "FK_tickets_AspNetUsers_AssignedToUsersId",
                table: "tickets",
                column: "AssignedToUsersId",
                principalTable: "AspNetUsers",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projectsusers_AspNetUsers_usersId",
                table: "Projectsusers");

            migrationBuilder.DropForeignKey(
                name: "FK_Projectsusers_Projects_ProjectId",
                table: "Projectsusers");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticketattachments_AspNetUsers_usersId",
                table: "Ticketattachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticketattachments_tickets_ticketsId",
                table: "Ticketattachments");

            migrationBuilder.DropForeignKey(
                name: "FK_ticketcomments_AspNetUsers_usersId",
                table: "ticketcomments");

            migrationBuilder.DropForeignKey(
                name: "FK_ticketcomments_tickets_ticketsId",
                table: "ticketcomments");

            migrationBuilder.DropForeignKey(
                name: "FK_tickethistories_AspNetUsers_UsersId",
                table: "tickethistories");

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
                name: "FK_tickets_AspNetUsers_AssignedToUsersId",
                table: "tickets");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_tickettypes",
                table: "tickettypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ticketstatuses",
                table: "ticketstatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tickets",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_OwnerUserId",
                table: "tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ticketnotifications",
                table: "ticketnotifications");

            migrationBuilder.DropIndex(
                name: "IX_ticketnotifications_UserId",
                table: "ticketnotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tickethistories",
                table: "tickethistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ticketcomments",
                table: "ticketcomments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ticketattachments",
                table: "Ticketattachments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projectsusers",
                table: "Projectsusers");

            migrationBuilder.RenameTable(
                name: "tickettypes",
                newName: "TicketTypes");

            migrationBuilder.RenameTable(
                name: "ticketstatuses",
                newName: "TicketStatuses");

            migrationBuilder.RenameTable(
                name: "tickets",
                newName: "Tickets");

            migrationBuilder.RenameTable(
                name: "ticketnotifications",
                newName: "TicketNotifications");

            migrationBuilder.RenameTable(
                name: "tickethistories",
                newName: "TicketHistories");

            migrationBuilder.RenameTable(
                name: "ticketcomments",
                newName: "TicketComments");

            migrationBuilder.RenameTable(
                name: "Ticketattachments",
                newName: "TicketAttachments");

            migrationBuilder.RenameTable(
                name: "Projectsusers",
                newName: "ProjectUsers");

            migrationBuilder.RenameColumn(
                name: "AssignedToUsersId",
                table: "Tickets",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_tickettypeId",
                table: "Tickets",
                newName: "IX_Tickets_tickettypeId");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_ticketstatusesId",
                table: "Tickets",
                newName: "IX_Tickets_ticketstatusesId");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_ticketprioritiesId",
                table: "Tickets",
                newName: "IX_Tickets_ticketprioritiesId");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_ProjectId",
                table: "Tickets",
                newName: "IX_Tickets_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_AssignedToUsersId",
                table: "Tickets",
                newName: "IX_Tickets_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_ticketnotifications_ticketsId",
                table: "TicketNotifications",
                newName: "IX_TicketNotifications_ticketsId");

            migrationBuilder.RenameIndex(
                name: "IX_tickethistories_UsersId",
                table: "TicketHistories",
                newName: "IX_TicketHistories_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_tickethistories_ticketsId",
                table: "TicketHistories",
                newName: "IX_TicketHistories_ticketsId");

            migrationBuilder.RenameIndex(
                name: "IX_ticketcomments_usersId",
                table: "TicketComments",
                newName: "IX_TicketComments_usersId");

            migrationBuilder.RenameIndex(
                name: "IX_ticketcomments_ticketsId",
                table: "TicketComments",
                newName: "IX_TicketComments_ticketsId");

            migrationBuilder.RenameIndex(
                name: "IX_Ticketattachments_usersId",
                table: "TicketAttachments",
                newName: "IX_TicketAttachments_usersId");

            migrationBuilder.RenameIndex(
                name: "IX_Ticketattachments_ticketsId",
                table: "TicketAttachments",
                newName: "IX_TicketAttachments_ticketsId");

            migrationBuilder.RenameColumn(
                name: "usersId",
                table: "ProjectUsers",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Projectsusers_usersId",
                table: "ProjectUsers",
                newName: "IX_ProjectUsers_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Projectsusers_ProjectId",
                table: "ProjectUsers",
                newName: "IX_ProjectUsers_ProjectId");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerUserId",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ticketsId",
                table: "TicketNotifications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "TicketNotifications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "TicketNotifications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "TicketNotifications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ticketsId",
                table: "TicketHistories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "TicketHistories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "TicketHistories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "usersId",
                table: "TicketComments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ticketsId",
                table: "TicketComments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "TicketComments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "TicketComments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "usersId",
                table: "TicketAttachments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ticketsId",
                table: "TicketAttachments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "TicketAttachments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "TicketAttachments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ProjectUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "ProjectUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketTypes",
                table: "TicketTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketStatuses",
                table: "TicketStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketNotifications",
                table: "TicketNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketHistories",
                table: "TicketHistories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketComments",
                table: "TicketComments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketAttachments",
                table: "TicketAttachments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectUsers",
                table: "ProjectUsers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TicketNotifications_UsersId",
                table: "TicketNotifications",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUsers_AspNetUsers_UsersId",
                table: "ProjectUsers",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectUsers_Projects_ProjectId",
                table: "ProjectUsers",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketAttachments_AspNetUsers_usersId",
                table: "TicketAttachments",
                column: "usersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketAttachments_Tickets_ticketsId",
                table: "TicketAttachments",
                column: "ticketsId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketComments_AspNetUsers_usersId",
                table: "TicketComments",
                column: "usersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketComments_Tickets_ticketsId",
                table: "TicketComments",
                column: "ticketsId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketHistories_AspNetUsers_UsersId",
                table: "TicketHistories",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketHistories_Tickets_ticketsId",
                table: "TicketHistories",
                column: "ticketsId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketNotifications_AspNetUsers_UsersId",
                table: "TicketNotifications",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketNotifications_Tickets_ticketsId",
                table: "TicketNotifications",
                column: "ticketsId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_UsersId",
                table: "Tickets",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Projects_ProjectId",
                table: "Tickets",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_TicketPriorities_ticketprioritiesId",
                table: "Tickets",
                column: "ticketprioritiesId",
                principalTable: "TicketPriorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_TicketStatuses_ticketstatusesId",
                table: "Tickets",
                column: "ticketstatusesId",
                principalTable: "TicketStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_TicketTypes_tickettypeId",
                table: "Tickets",
                column: "tickettypeId",
                principalTable: "TicketTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
