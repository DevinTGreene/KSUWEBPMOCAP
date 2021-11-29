using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.PDFFiles
{
    public class DeleteModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public DeleteModel(KSUWEBPMOCAPContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PDFFILE = await _context.PDFFILE.FindAsync(id);

            if (PDFFILE != null)
            {
                _context.PDFFILE.Remove(PDFFILE);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
