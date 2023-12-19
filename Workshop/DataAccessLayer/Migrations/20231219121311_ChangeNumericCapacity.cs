using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNumericCapacity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChristmasBalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    x = table.Column<decimal>(type: "numeric(5,2)", nullable: false),
                    y = table.Column<decimal>(type: "numeric(5,2)", nullable: false),
                    radius = table.Column<decimal>(type: "numeric(4,2)", nullable: false),
                    color = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    effects = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Christma__3214EC07A11BBCE2", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChristmasBalls");
        }
    }
}
