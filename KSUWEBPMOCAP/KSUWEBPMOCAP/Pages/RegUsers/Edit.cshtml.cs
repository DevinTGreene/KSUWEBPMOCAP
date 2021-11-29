using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.RegUsers
{
    public class EditModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public EditModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RegUser RegUser { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RegUser = await _context.RegUser.FirstOrDefaultAsync(m => m.ID == id);

            if (RegUser == null)
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

            _context.Attach(RegUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegUserExists(RegUser.ID))
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

        private bool RegUserExists(int id)
        {
            return _context.RegUser.Any(e => e.ID == id);
        }
    }
}
