using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstMVCProject.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [StringLength(80,MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")] //define o tamanho máximo e mínimo do campo
        [Required(ErrorMessage = "O nome do lanche deve ser informado")]
        [Display(Name = "Nome do Lanche")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição resumida do lanche deve ser informada")]
        [Display(Name = "Descrição Resumida do Lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")] //define o tamanho mínimo do campo
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")] //define o tamanho máximo do campo
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição detalhada do lanche deve ser informada")]
        [Display(Name = "Descrição Detalhada do Lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no máximo {1} caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "O preço do lanche deve ser informado")] //define que o campo é obrigatório
        [Display(Name = "Preço do Lanche")] //define o nome do campo na view
        [Column(TypeName = "decimal(10,2)")] //define o tipo decimal com 10 digitos no total e 2 digitos decimais
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")] //define o preço minimo 1 e máximo 999.99
        public decimal Preco { get; set; }

        [Display(Name = "Caminho da Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho da Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Em Estoque?")]
        public bool EmEstoque { get; set; }


        public int CategoriaId { get; set; }
        
        public virtual Categoria Categoria { get; set; }
    }
}