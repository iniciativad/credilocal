
using System.ComponentModel.DataAnnotations;

namespace CrediLocal.Mvc.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required(ErrorMessage="Preencha o campo nome")]
        public string Nome { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","9999")]
        [Required(ErrorMessage="Preencha um valor")]
        public decimal Valor { get; set; }
        [Display(Name="Disponivel?")]
        public bool Disponivel { get; set; }
        public int ClienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}