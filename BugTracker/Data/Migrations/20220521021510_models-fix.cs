using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Data.Migrations
{
    public partial class modelsfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projectsusers_AspNetUsers_usersId",
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
                name: "FK_ticketnotifications_tickets_ticketsId",
                table: "ticketnotifications");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_AspNetUsers_AssignedToUsersId",
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
                name: "IX_tickets_ticketprioritiesId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_ticketstatusesId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_ticketnotifications_ticketsId",
                table: "ticketnotifications");

            migrationBuilder.DropIndex(
                name: "IX_tickethistories_ticketsId",
                table: "tickethistories");

            migrationBuilder.DropIndex(
                name: "IX_tickethistories_UsersId",
                table: "tickethistories");

            migrationBuilder.DropIndex(
                name: "IX_ticketcomments_ticketsId",
                table: "ticketcomments");

            migrationBuilder.DropIndex(
                name: "IX_ticketcomments_usersId",
                table: "ticketcomments");

            migrationBuilder.DropIndex(
                name: "IX_Ticketattachments_ticketsId",
                table: "Ticketattachments");

            migrationBuilder.DropIndex(
                name: "IX_Ticketattachments_usersId",
                table: "Ticketattachments");

            migrationBuilder.DropIndex(
                name: "IX_Projectsusers_usersId",
                table: "Projectsusers");

            migrationBuilder.DropColumn(
                name: "TickedTypeId",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "ticketprioritiesId",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "ticketstatusesId",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "ticketsId",
                table: "ticketnotifications");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "tickethistories");

            migrationBuilder.DropColumn(
                name: "ticketsId",
                table: "tickethistories");

            migrationBuilder.DropColumn(
                name: "ticketsId",
                table: "ticketcomments");

            migrationBuilder.DropColumn(
                name: "usersId",
                table: "ticketcomments");

            migrationBuilder.DropColumn(
                name: "ticketsId",
                table: "Ticketattachments");

            migrationBuilder.DropColumn(
                name: "usersId",
                table: "Ticketattachments");

            migrationBuilder.DropColumn(
                name: "usersId",
                table: "Projectsusers");

            migrationBuilder.RenameColumn(
                name: "tickettypeId",
                table: "tickets",
                newName: "TicketTypeId");

            migrationBuilder.RenameColumn(
                name: "Descripiton",
                table: "tickets",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "AssignedToUsersId",
                table: "tickets",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_tickettypeId",
                table: "tickets",
                newName: "IX_tickets_TicketTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_AssignedToUsersId",
                table: "tickets",
                newName: "IX_tickets_UserId");

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
                name: "AssignedToUserId",
                table: "tickets",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "tickethistories",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ticketcomments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Ticketattachments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Projectsusers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_AssignedToUserId",
                table: "tickets",
                column: "AssignedToUserId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_TicketPriorityId",
                table: "tickets",
                column: "TicketPriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_TicketStatusId",
                table: "tickets",
                column: "TicketStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ticketnotifications_TicketId",
                table: "ticketnotifications",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_tickethistories_TicketId",
                table: "tickethistories",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_tickethistories_UserId",
                table: "tickethistories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ticketcomments_TicketId",
                table: "ticketcomments",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_ticketcomments_UserId",
                table: "ticketcomments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticketattachments_TicketId",
                table: "Ticketattachments",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticketattachments_UserId",
                table: "Ticketattachments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Projectsusers_UserId",
                table: "Projectsusers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projectsusers_AspNetUsers_UserId",
                table: "Projectsusers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticketattachments_AspNetUsers_UserId",
                table: "Ticketattachments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticketattachments_tickets_TicketId",
                table: "Ticketattachments",
                column: "TicketId",
                principalTable: "tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ticketcomments_AspNetUsers_UserId",
                table: "ticketcomments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ticketcomments_tickets_TicketId",
                table: "ticketcomments",
                column: "TicketId",
                principalTable: "tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickethistories_AspNetUsers_UserId",
                table: "tickethistories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickethistories_tickets_TicketId",
                table: "tickethistories",
                column: "TicketId",
                principalTable: "tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ticketnotifications_tickets_TicketId",
                table: "ticketnotifications",
                column: "TicketId",
                principalTable: "tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_AspNetUsers_AssignedToUserId",
                table: "tickets",
                column: "AssignedToUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_AspNetUsers_UserId",
                table: "tickets",
                column: "UserId",
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
                name: "FK_tickets_TicketPriorities_TicketPriorityId",
                table: "tickets",
                column: "TicketPriorityId",
                principalTable: "TicketPriorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_ticketstatuses_TicketStatusId",
                table: "tickets",
                column: "TicketStatusId",
                principalTable: "ticketstatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_tickettypes_TicketTypeId",
                table: "tickets",
                column: "TicketTypeId",
                principalTable: "tickettypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projectsusers_AspNetUsers_UserId",
                table: "Projectsusers");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticketattachments_AspNetUsers_UserId",
                table: "Ticketattachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticketattachments_tickets_TicketId",
                table: "Ticketattachments");

            migrationBuilder.DropForeignKey(
                name: "FK_ticketcomments_AspNetUsers_UserId",
                table: "ticketcomments");

            migrationBuilder.DropForeignKey(
                name: "FK_ticketcomments_tickets_TicketId",
                table: "ticketcomments");

            migrationBuilder.DropForeignKey(
                name: "FK_tickethistories_AspNetUsers_UserId",
                table: "tickethistories");

            migrationBuilder.DropForeignKey(
                name: "FK_tickethistories_tickets_TicketId",
                table: "tickethistories");

            migrationBuilder.DropForeignKey(
                name: "FK_ticketnotifications_tickets_TicketId",
                table: "ticketnotifications");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_AspNetUsers_AssignedToUserId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_AspNetUsers_UserId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_Projects_ProjectId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_TicketPriorities_TicketPriorityId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_ticketstatuses_TicketStatusId",
                table: "tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_tickettypes_TicketTypeId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_AssignedToUserId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_TicketPriorityId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_TicketStatusId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_ticketnotifications_TicketId",
                table: "ticketnotifications");

            migrationBuilder.DropIndex(
                name: "IX_tickethistories_TicketId",
                table: "tickethistories");

            migrationBuilder.DropIndex(
                name: "IX_tickethistories_UserId",
                table: "tickethistories");

            migrationBuilder.DropIndex(
                name: "IX_ticketcomments_TicketId",
                table: "ticketcomments");

            migrationBuilder.DropIndex(
                name: "IX_ticketcomments_UserId",
                table: "ticketcomments");

            migrationBuilder.DropIndex(
                name: "IX_Ticketattachments_TicketId",
                table: "Ticketattachments");

            migrationBuilder.DropIndex(
                name: "IX_Ticketattachments_UserId",
                table: "Ticketattachments");

            migrationBuilder.DropIndex(
                name: "IX_Projectsusers_UserId",
                table: "Projectsusers");

            migrationBuilder.RenameColumn(
                name: "TicketTypeId",
                table: "tickets",
                newName: "tickettypeId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "tickets",
                newName: "AssignedToUsersId");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "tickets",
                newName: "Descripiton");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_TicketTypeId",
                table: "tickets",
                newName: "IX_tickets_tickettypeId");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_UserId",
                table: "tickets",
                newName: "IX_tickets_AssignedToUsersId");

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
                name: "AssignedToUserId",
                table: "tickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TickedTypeId",
                table: "tickets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ticketprioritiesId",
                table: "tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ticketstatusesId",
                table: "tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ticketsId",
                table: "ticketnotifications",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "tickethistories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "tickethistories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ticketsId",
                table: "tickethistories",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ticketcomments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ticketsId",
                table: "ticketcomments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "usersId",
                table: "ticketcomments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Ticketattachments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ticketsId",
                table: "Ticketattachments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "usersId",
                table: "Ticketattachments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Projectsusers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "usersId",
                table: "Projectsusers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tickets_ticketprioritiesId",
                table: "tickets",
                column: "ticketprioritiesId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_ticketstatusesId",
                table: "tickets",
                column: "ticketstatusesId");

            migrationBuilder.CreateIndex(
                name: "IX_ticketnotifications_ticketsId",
                table: "ticketnotifications",
                column: "ticketsId");

            migrationBuilder.CreateIndex(
                name: "IX_tickethistories_ticketsId",
                table: "tickethistories",
                column: "ticketsId");

            migrationBuilder.CreateIndex(
                name: "IX_tickethistories_UsersId",
                table: "tickethistories",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_ticketcomments_ticketsId",
                table: "ticketcomments",
                column: "ticketsId");

            migrationBuilder.CreateIndex(
                name: "IX_ticketcomments_usersId",
                table: "ticketcomments",
                column: "usersId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticketattachments_ticketsId",
                table: "Ticketattachments",
                column: "ticketsId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticketattachments_usersId",
                table: "Ticketattachments",
                column: "usersId");

            migrationBuilder.CreateIndex(
                name: "IX_Projectsusers_usersId",
                table: "Projectsusers",
                column: "usersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projectsusers_AspNetUsers_usersId",
                table: "Projectsusers",
                column: "usersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

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
