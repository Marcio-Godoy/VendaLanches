using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanches.Models
{
    [Table("Snacks")]
    public class Snack
    {
        [Key]
        public int SnackId { get; set; }

        [Required(ErrorMessage = "Informe o Nome do Lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "Permitido somente 80 caracteres no campo Nome")]
        [Display(Name = "Nome")]
        public string SnackName { get; set; }

        [Required(ErrorMessage = "Informe a Descrição do Lanche")]
        [MinLength(20, ErrorMessage = "Campo Descrição Lanche permitido no mínimo somente {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Campo Descrição Lanche não pode exceder {1} caracteres")]
        [Display(Name = "Descrição do Lanche")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "Informe a Descrição do Lanche")]
        [MinLength(20, ErrorMessage = "Campo Descrição Lanche permitido no mínimo somente {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Campo Descrição Lanche não pode exceder {1} caracteres")]
        [Display(Name = "Descrição do Lanche")]
        public string DetailedDescription { get; set; }

        [Required(ErrorMessage = "Informe o valor do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O valor do lanche deve estar entre 1 e 999,99")]
        public decimal Price { get; set; }

        [Display(Name = "Url da Imagem Normal")]
        [StringLength(200, ErrorMessage = "0 {0} deve ter no máximo {1} caracteres")]
        public string ImageUrl { get; set; }

        [Display(Name = "Url da Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "0 {0} deve ter no máximo {1} caracteres")]
        public string ImageThumbnailUrl { get; set; }

        [Display(Name = "Esse lanche é o seu preferido?")]
        public bool IsFavoriteSnack { get; set; }

        [Display(Name = "Estoque")]
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
