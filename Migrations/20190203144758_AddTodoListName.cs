using Microsoft.EntityFrameworkCore.Migrations;

namespace todo_app.Migrations
{
    public partial class AddTodoListName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TodoListName",
                table: "TodoLists",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TodoListName",
                table: "TodoLists");
        }
    }
}
