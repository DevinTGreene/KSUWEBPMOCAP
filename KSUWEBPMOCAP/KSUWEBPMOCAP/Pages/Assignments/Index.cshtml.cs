using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.Assignments
{
    public class IndexModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public IndexModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }

        public IList<Assignment> Assignment { get;set; }

        public async Task OnGetAsync()
        {
            Assignment = await _context.Assignment.ToListAsync();
        }
    }
}
