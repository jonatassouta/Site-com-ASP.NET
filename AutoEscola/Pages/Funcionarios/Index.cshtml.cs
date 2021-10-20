using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AutoEscola.Data;

namespace AutoEscola.Pages.Funcionarios
{
    public class IndexModel : PageModel
    {
        private readonly AutoEscola.Data.AutoEscolaContext _context;

        public IndexModel(AutoEscola.Data.AutoEscolaContext context)
        {
            _context = context;
        }

        public IList<Funcionario> Funcionario { get;set; }

        public async Task OnGetAsync()
        {
            Funcionario = await _context.Funcionario.ToListAsync();
        }
    }
}
