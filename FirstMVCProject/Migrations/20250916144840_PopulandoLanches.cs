using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstMVCProject.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO \"Lanches\" (\"Nome\", \"DescricaoCurta\", \"DescricaoDetalhada\", \"Preco\", \"ImagemUrl\", \"ImagemThumbnailUrl\", \"IsLanchePreferido\", \"EmEstoque\", \"CategoriaId\") " +
                "VALUES ('X-Salada', 'Hambúrguer com queijo, alface, tomate e maionese', 'Delicioso hambúrguer com queijo derretido, alface fresca, tomate suculento e maionese caseira.', 12.50, 'https://example.com/images/x-salada.jpg', 'https://example.com/images/x-salada-thumb.jpg', true, true, 1)");
           
            migrationBuilder.Sql("INSERT INTO \"Lanches\" (\"Nome\", \"DescricaoCurta\", \"DescricaoDetalhada\", \"Preco\", \"ImagemUrl\", \"ImagemThumbnailUrl\", \"IsLanchePreferido\", \"EmEstoque\", \"CategoriaId\") " +
                "VALUES ('X-Bacon', 'Hambúrguer com queijo, bacon crocante e molho especial', 'Saboroso hambúrguer com queijo derretido, bacon crocante e um molho especial que vai te conquistar.', 14.00, 'https://example.com/images/x-bacon.jpg', 'https://example.com/images/x-bacon-thumb.jpg', false, true, 1)");
         
            migrationBuilder.Sql("INSERT INTO \"Lanches\" (\"Nome\", \"DescricaoCurta\", \"DescricaoDetalhada\", \"Preco\", \"ImagemUrl\", \"ImagemThumbnailUrl\", \"IsLanchePreferido\", \"EmEstoque\", \"CategoriaId\") " +
                "VALUES ('X-Egg', 'Hambúrguer com ovo, queijo e maionese', 'Delicioso hambúrguer com ovo frito, queijo derretido e maionese caseira.', 13.50, 'https://example.com/images/x-egg.jpg', 'https://example.com/images/x-egg-thumb.jpg', true, true, 1)");

            migrationBuilder.Sql("INSERT INTO \"Lanches\" (\"Nome\", \"DescricaoCurta\", \"DescricaoDetalhada\", \"Preco\", \"ImagemUrl\", \"ImagemThumbnailUrl\", \"IsLanchePreferido\", \"EmEstoque\", \"CategoriaId\") " +
                "VALUES ('Salada Natural', 'Lanche com pão integral, peito de peru, alface, tomate e maionese', 'Lanche saudável com pão integral, peito de peru, alface fresca, tomate suculento e maionese caseira.', 11.00, 'https://example.com/images/salada-natural.jpg', 'https://example.com/images/salada-natural-thumb.jpg', true, true, 2)");
           
            migrationBuilder.Sql("INSERT INTO \"Lanches\" (\"Nome\", \"DescricaoCurta\", \"DescricaoDetalhada\", \"Preco\", \"ImagemUrl\", \"ImagemThumbnailUrl\", \"IsLanchePreferido\", \"EmEstoque\", \"CategoriaId\") " +
                "VALUES ('Wrap Vegano', 'Wrap com homus, alface, tomate, cenoura ralada e molho de iogurte vegano', 'Delicioso wrap recheado com homus cremoso, alface fresca, tomate suculento, cenoura ralada e um molho de iogurte vegano.', 13.00, 'https://example.com/images/wrap-vegano.jpg', 'https://example.com/images/wrap-vegano-thumb.jpg', false, true, 3)");
           
            migrationBuilder.Sql("INSERT INTO \"Lanches\" (\"Nome\", \"DescricaoCurta\", \"DescricaoDetalhada\", \"Preco\", \"ImagemUrl\", \"ImagemThumbnailUrl\", \"IsLanchePreferido\", \"EmEstoque\", \"CategoriaId\") " +
                "VALUES ('Lanche Light', 'Lanche com pão integral, peito de frango grelhado, alface, tomate e molho light', 'Lanche leve com pão integral, peito de frango grelhado, alface fresca, tomate suculento e um molho light.', 12.00, 'https://example.com/images/lanche-light.jpg', 'https://example.com/images/lanche-light-thumb.jpg', true, true, 4)");
           
            migrationBuilder.Sql("INSERT INTO \"Lanches\" (\"Nome\", \"DescricaoCurta\", \"DescricaoDetalhada\", \"Preco\", \"ImagemUrl\", \"ImagemThumbnailUrl\", \"IsLanchePreferido\", \"EmEstoque\", \"CategoriaId\") " +
                "VALUES ('Lanche Especial', 'Lanche com pão brioche, hambúrguer gourmet, queijo cheddar, bacon, alface, tomate e molho especial', 'Lanche sofisticado com pão brioche macio, hambúrguer gourmet suculento, queijo cheddar derretido, bacon crocante, alface fresca, tomate suculento e um molho especial que vai te conquistar.', 18.00, 'https://example.com/images/lanche-especial.jpg', 'https://example.com/images/lanche-especial-thumb.jpg', false, true, 5)");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence("Lanches");
        }
    }
}
