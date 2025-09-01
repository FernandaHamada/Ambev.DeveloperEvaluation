using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    /// <inheritdoc />
    public partial class AlterColumnType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE \"Products\" ALTER COLUMN \"Rate\" TYPE numeric(18,2) USING \"Rate\"::numeric;");
            migrationBuilder.Sql("ALTER TABLE \"Products\" ALTER COLUMN \"Count\" TYPE integer USING \"Count\"::integer;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE \"Products\" ALTER COLUMN \"Rate\" TYPE text USING \"Rate\"::text;");
            migrationBuilder.Sql("ALTER TABLE \"Products\" ALTER COLUMN \"Count\" TYPE text USING \"Count\"::text;");
        }
    }
}
