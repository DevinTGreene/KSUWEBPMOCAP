using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.Sponsors
{
    public class EditModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public EditModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sponsor Sponsor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sponsor = await _context.Sponsor.FirstOrDefaultAsync(m => m.Sponsor_ID == id);

            if (Sponsor == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Sponsor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SponsorExists(Sponsor.Sponsor_ID))
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

        private bool SponsorExists(int id)
        {
            return _context.Sponsor.Any(e => e.Sponsor_ID == id);
        }
    }
}
