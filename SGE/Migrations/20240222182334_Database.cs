using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SGE.Migrations
{
    /// <inheritdoc />
    public partial class Database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AlunoNome",
                table: "Aluno",
                type: "nvarchar(130)",
                maxLength: 130,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AlunoNome",
                table: "Aluno",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(130)",
                oldMaxLength: 130);
        }
    }
}
