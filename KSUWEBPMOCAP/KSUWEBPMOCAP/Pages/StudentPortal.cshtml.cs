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
    public class StudentPortalModel : PageModel
    {
        [BindProperty]

        public UserAccount account { get; set; }
        public string Msg;

        private DatabaseContext db;



        public StudentPortalModel(DatabaseContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            account = new UserAccount();
        }
        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("Student_Net_ID");
            return RedirectToPage("StudentPortal");
        }
        public IActionResult OnPost()
        {
            var acc = login(account.Student_Net_Id, account.Student_Password);
            if (acc == null)
            {
                Msg = "Invalid Net ID or Password";
                return Page();
            }
            else
            {
                HttpContext.Session.SetString("Student_Name", acc.Student_Name);
                return RedirectToPage("/Students/Index");
            }

        }
        private UserAccount login(string Student_Net_ID, string Student_Password)
        {
            var account = db.UserAccounts.SingleOrDefault(a => a.Student_Net_Id.Equals(Student_Net_ID));
            if (account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(Student_Password, account.Student_Password))
                {
                    return account;
                }
            }
            return null;
        }
    }
}