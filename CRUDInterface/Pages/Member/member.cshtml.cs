using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDInterface.Pages.Member
{
    public class memberModel : PageModel
    {
        public void OnGet()
        {
        }
        [HttpPost]
        public ActionResult Index(FormCollection post)
        {
            string account = post["account"];
            string password1 = post["password1"];
            string password2 = post["password2"];
            string email = post["email"];
            string city = post["city"];
            string village = post["village"];
            string address = post["address"];

            if(password1 != password2)
            {
                ModelState.AddModelError("Member.Password", "密碼不相同");
            }
            if (string.IsNullOrWhiteSpace(account) )
            {
                ModelState.AddModelError("Member.Account", "該帳戶已存在");
               
                return  Page(); ;
            }
            else
            {
                Response.Redirect("Login");
                return new EmptyResult();
            }
        }
    }
}
