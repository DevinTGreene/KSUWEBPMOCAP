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
    public class IndexModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public IndexModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }

        public IList<Proposal> Proposal { get;set; }

        public async Task OnGetAsync()
        {
            Proposal = await _context.Proposal.ToListAsync();
        }
    }
}
