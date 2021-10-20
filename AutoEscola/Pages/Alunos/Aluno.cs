using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoEscola.Pages
{
    public class Aluno
    {
        public int ID { get; set; }
        [Required]
        [StringLength(30)]
        [MinLength(3)]
        public string Nome { get; set; }
        [Required]
        [StringLength(12)]
        [MinLength(12)]
        public string Telefone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
