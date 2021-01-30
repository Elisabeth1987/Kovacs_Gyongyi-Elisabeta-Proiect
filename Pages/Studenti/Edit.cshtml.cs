using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kovacs_Gyongyi_Elisabeta_Proiect.Data;
using Kovacs_Gyongyi_Elisabeta_Proiect.Models;

namespace Kovacs_Gyongyi_Elisabeta_Proiect.Pages.Studenti
{
    public class EditModel : PageModel
    {
        private readonly Kovacs_Gyongyi_Elisabeta_Proiect.Data.Kovacs_Gyongyi_Elisabeta_ProiectContext _context;

        public EditModel(Kovacs_Gyongyi_Elisabeta_Proiect.Data.Kovacs_Gyongyi_Elisabeta_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.ID == id);

            if (Student == null)
            {
                return NotFound();
            }
            ViewData["SpecializareID"] = new SelectList(_context.Set<Specializare>(), "ID", "Nume_Specializare");
            ViewData["CicluID"] = new SelectList(_context.Set<Ciclu>(), "ID", "Nume_Ciclu");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(Student.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.ID == id);
        }
    }
}
