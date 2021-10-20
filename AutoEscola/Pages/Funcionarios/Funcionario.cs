using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoEscola.Pages.Funcionarios
{
    public class Funcionario
    {
        public int ID { get; set; }
        [Required]
        [StringLength(30)]
        [MinLength(3)]
        public string Nome { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string Cargo { get; set; }
        [Required]
        public decimal Salario { get; set; }
    }
}
