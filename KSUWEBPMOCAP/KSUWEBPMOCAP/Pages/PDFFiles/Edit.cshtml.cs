using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.PDFFiles
{
    public class EditModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public EditModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PDFFILE PDFFILE { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PDFFILE = await _context.PDFFILE.FirstOrDefaultAsync(m => m.ID == id);

            if (PDFFILE == null)
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

            _context.Attach(PDFFILE).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PDFFILEExists(PDFFILE.ID))
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

        private bool PDFFILEExists(int id)
        {
            return _context.PDFFILE.Any(e => e.ID == id);
        }
    }
}
