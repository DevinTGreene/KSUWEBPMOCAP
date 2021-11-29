using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KSUWEBPMOCAP.Models;

namespace KSUWEBPMOCAP.Pages
{
    public class FacultyPortalModel : PageModel
    {
        [BindProperty]

        public AdminAccount account { get; set; }
        public string Msg;

        private DatabaseContext db;

        public FacultyPortalModel(DatabaseContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            account = new AdminAccount();
        }
        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("Net_ID");
            return RedirectToPage("FacultyPortal");
        }
        public IActionResult OnPost()
        {
            var acc = login(account.Net_Id, account.Faculty_Password);
            if (acc == null)
            {
                Msg = "Invalid Net ID or Password";
                return Page();
            }
            else
            {
                HttpContext.Session.SetString("Faculty_Name", acc.Faculty_Name);
                return RedirectToPage("/Faculties/Index");
            }

        }
        private AdminAccount login(string Net_ID, string Faculty_Password)
        {
            var account = db.AdminAccounts.SingleOrDefault(a => a.Net_Id.Equals(Net_ID));
            if (account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(Faculty_Password, account.Faculty_Password))
                {
                    return account;
                }
            }
            return null;
        }
    }
}