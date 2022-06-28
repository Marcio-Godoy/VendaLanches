using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanches.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Informe o da Nome Categoria")]
        [StringLength(100,ErrorMessage = "Permitido somente 100 caracteres no campo Nome Categoria")]
        [Display(Name ="Nome")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Informe a Descrição")]
        [StringLength(200, ErrorMessage = "Permitido somente 200 caracteres no campo Descrição")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }
        public List<Snack> Snacks { get; set; }
    }
}
