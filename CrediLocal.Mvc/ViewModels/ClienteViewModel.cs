using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrediLocal.Mvc.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage="Preencha o campo Nome")]
        [MaxLength(75)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha o campo Sobrenome")]
        [MaxLength(75)]
        public string Sobrenome { get; set; }
        [EmailAddress(ErrorMessage="Preencha um e-mail válido")]
        [Display(Name="E-mail")]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}