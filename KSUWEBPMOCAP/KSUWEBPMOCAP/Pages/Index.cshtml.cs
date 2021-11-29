using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KSUWEBPMOCAP.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }
        public IActionResult OnPostAdminlgn()
        {
            return RedirectToPage("FacultyPortal");
        }
        public IActionResult OnPostUserlgn()
        {
            return RedirectToPage("StudentPortal");
        }
        public IActionResult OnPostViewerlgn()
        {
            return RedirectToPage("SponsorPortal");
        }
    }
}
