using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kovacs_Gyongyi_Elisabeta_Proiect.Data;
using Kovacs_Gyongyi_Elisabeta_Proiect.Models;

namespace Kovacs_Gyongyi_Elisabeta_Proiect.Pages.Studenti
{
    public class IndexModel : PageModel
    {
        private readonly Kovacs_Gyongyi_Elisabeta_Proiect.Data.Kovacs_Gyongyi_Elisabeta_ProiectContext _context;

        public IndexModel(Kovacs_Gyongyi_Elisabeta_Proiect.Data.Kovacs_Gyongyi_Elisabeta_ProiectContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.Include(b => b.Specializare).ToListAsync();
            Student = await _context.Student.Include(b => b.Ciclu).ToListAsync();
        }
    }
}
