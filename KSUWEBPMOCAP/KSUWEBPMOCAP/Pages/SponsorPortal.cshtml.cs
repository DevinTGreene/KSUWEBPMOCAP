using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KSUWEBPMOCAP.Models;

namespace KSUWEBPMOCAP.Pages
{
    public class SponsorPortalModel : PageModel
    {
        [BindProperty]

        public ViewerAccount account { get; set; }
        public string Msg;

        private DatabaseContext db;

        public SponsorPortalModel(DatabaseContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            account = new ViewerAccount();
        }
        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("Sponsor_ID");
            return RedirectToPage("SponsorPortal");
        }
        public IActionResult OnPost()
        {
            var acc = login(account.Sponsor_ID, account.Sponsor_Password);
            if (acc == null)
            {
                Msg = "Invalid Sponsor ID or Password";
                return Page();
            }
            else
            {
                HttpContext.Session.SetString("Sponsor_Name", acc.Sponsor_Name);
                return RedirectToPage("/Sponsors/Index");
            }

        }
        private ViewerAccount login(string Sponsor_ID, string Sponsor_Password)
        {
            var account = db.ViewerAccounts.SingleOrDefault(a => a.Sponsor_ID.Equals(Sponsor_ID));
            if (account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(Sponsor_Password, account.Sponsor_Password))
                {
                    return account;
                }
            }
            return null;
        }
    }
}