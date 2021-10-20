using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AutoEscola.Data;
using AutoEscola.Pages;

namespace AutoEscola.Pages.Alunos
{
    public class IndexModel : PageModel
    {
        private readonly AutoEscola.Data.AutoEscolaContext _context;

        public IndexModel(AutoEscola.Data.AutoEscolaContext context)
        {
            _context = context;
        }

        public IList<Aluno> Aluno { get;set; }

        public async Task OnGetAsync()
        {
            Aluno = await _context.Aluno.ToListAsync();
        }
    }
}
