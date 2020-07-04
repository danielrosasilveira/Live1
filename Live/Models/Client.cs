using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Live.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [MinLength(3, ErrorMessage ="Mínimo 3 caracteres")]
        [Display(Name ="Nome:")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Obrigatório")]
        [EmailAddress(ErrorMessage ="E-mail Inválido")]
        [Display(Name ="E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [Display(Name ="Data de Nascimento")]
        public DateTime DtNasc { get; set; }

        [Display(Name ="Ativo")]
        public bool Status { get; set; }

    }
}
