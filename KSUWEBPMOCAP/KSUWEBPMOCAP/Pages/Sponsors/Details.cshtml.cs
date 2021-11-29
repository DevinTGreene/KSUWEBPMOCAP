using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.Sponsors
{
    public class DetailsModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public DetailsModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }

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
    }
}
