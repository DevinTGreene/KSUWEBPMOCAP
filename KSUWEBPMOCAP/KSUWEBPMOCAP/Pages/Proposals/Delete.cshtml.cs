using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.Proposals
{
    public class DeleteModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public DeleteModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Proposal Proposal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Proposal = await _context.Proposal.FirstOrDefaultAsync(m => m.Propasal_ID == id);

            if (Proposal == null)
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

            Proposal = await _context.Proposal.FindAsync(id);

            if (Proposal != null)
            {
                _context.Proposal.Remove(Proposal);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
