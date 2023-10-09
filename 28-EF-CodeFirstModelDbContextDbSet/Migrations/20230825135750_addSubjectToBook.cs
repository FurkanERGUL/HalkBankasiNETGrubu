using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _28_EF_CodeFirstModelDbContextDbSet.Migrations
{
    public partial class addSubjectToBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookSubject",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookSubject",
                table: "Books");
        }
    }
}
