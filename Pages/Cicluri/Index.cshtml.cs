using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kovacs_Gyongyi_Elisabeta_Proiect.Data;
using Kovacs_Gyongyi_Elisabeta_Proiect.Models;

namespace Kovacs_Gyongyi_Elisabeta_Proiect.Pages.Cicluri
{
    public class IndexModel : PageModel
    {
        private readonly Kovacs_Gyongyi_Elisabeta_Proiect.Data.Kovacs_Gyongyi_Elisabeta_ProiectContext _context;

        public IndexModel(Kovacs_Gyongyi_Elisabeta_Proiect.Data.Kovacs_Gyongyi_Elisabeta_ProiectContext context)
        {
            _context = context;
        }

        public IList<Ciclu> Ciclu { get;set; }

        public async Task OnGetAsync()
        {
            Ciclu = await _context.Ciclu.ToListAsync();
        }
    }
}
