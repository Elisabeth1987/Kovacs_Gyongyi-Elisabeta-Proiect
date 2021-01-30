using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Kovacs_Gyongyi_Elisabeta_Proiect.Data;
using Kovacs_Gyongyi_Elisabeta_Proiect.Models;

namespace Kovacs_Gyongyi_Elisabeta_Proiect.Pages.Cicluri
{
    public class CreateModel : PageModel
    {
        private readonly Kovacs_Gyongyi_Elisabeta_Proiect.Data.Kovacs_Gyongyi_Elisabeta_ProiectContext _context;

        public CreateModel(Kovacs_Gyongyi_Elisabeta_Proiect.Data.Kovacs_Gyongyi_Elisabeta_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Ciclu Ciclu { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Ciclu.Add(Ciclu);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
