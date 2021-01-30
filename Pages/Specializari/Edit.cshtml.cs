﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kovacs_Gyongyi_Elisabeta_Proiect.Data;
using Kovacs_Gyongyi_Elisabeta_Proiect.Models;

namespace Kovacs_Gyongyi_Elisabeta_Proiect.Pages.Specializari
{
    public class EditModel : PageModel
    {
        private readonly Kovacs_Gyongyi_Elisabeta_Proiect.Data.Kovacs_Gyongyi_Elisabeta_ProiectContext _context;

        public EditModel(Kovacs_Gyongyi_Elisabeta_Proiect.Data.Kovacs_Gyongyi_Elisabeta_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Specializare Specializare { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Specializare = await _context.Specializare.FirstOrDefaultAsync(m => m.ID == id);

            if (Specializare == null)
            {
                return NotFound();
            }
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

            _context.Attach(Specializare).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpecializareExists(Specializare.ID))
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

        private bool SpecializareExists(int id)
        {
            return _context.Specializare.Any(e => e.ID == id);
        }
    }
}