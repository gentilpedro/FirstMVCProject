using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstMVCProject.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO \"Categorias\" (\"CategoriaNome\", \"Descricao\") " +
                "VALUES ('Do Dia', 'Lanche especial do dia')");
            migrationBuilder.Sql("INSERT INTO \"Categorias\" (\"CategoriaNome\", \"Descricao\") " +
                "VALUES ('Natural', 'Lanche com ingredientes naturais')");
            migrationBuilder.Sql("INSERT INTO \"Categorias\" (\"CategoriaNome\", \"Descricao\") " +
                "VALUES ('Vegano', 'Lanche com ingredientes veganos')");
            migrationBuilder.Sql("INSERT INTO \"Categorias\" (\"CategoriaNome\", \"Descricao\") " +
                "VALUES ('Light', 'Lanche com ingredientes lights')");
            migrationBuilder.Sql("INSERT INTO \"Categorias\" (\"CategoriaNome\", \"Descricao\") " +
                "VALUES ('Especiais', 'Lanche com ingredientes selecionados e super saborosos')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence("Categorias");
        }
    }
}
