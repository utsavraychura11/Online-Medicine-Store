using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineMedicineStore.Service;
using OnlineMedicineStore.Models;
using Microsoft.AspNetCore.Identity;
using System.Windows.Input;

namespace OnlineMedicineStore.Controllers
{
   
    public class HomeController: Controller
    {
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(IUserService userService,
            IEmailService emailService,
            UserManager<ApplicationUser> userManager)
        {
            _userService = userService;
            _emailService = emailService;
            _userManager = userManager;
        }
        public ViewResult Index()
        {

            /*UserEmailOptions options = new UserEmailOptions
            {
                ToEmails = new List<string>() {"test@gmail.com"},
                PlaceHolders = new List<KeyValuePair<string,string>>()
                {
                    new KeyValuePair<string, string>("{{UserName}}","Utsav & Vedant")
                }
            };

            await _emailService.SendTestEmail(options);*/
            var userId = _userService.GetUserId();
            var isLoggedIn = _userService.IsAuthenticated();

            return View();
        }

        [Authorize]
        public ViewResult AboutUs()
        {
            return View();
        }

        [Authorize]
        public ViewResult ContactUs()
        {
            return View();
        }

        /*[Authorize]
        [HttpGet]
        [Route("update-profile")]
        public async Task<IActionResult> UpdateProfile()
        {
            var userId = _userService.GetUserId();
            var user = await _userManager.FindByIdAsync(userId);
           // var isLoggedIn = _userService.IsAuthenticated();
            return View();
        }*/

       /* [Authorize]
        [HttpPost]
        [Route("update-profile")]
        public async Task<IActionResult> UpdateProfile()
        {
            if(ModelState.IsValid)
            {
                var result = await _userManager.UpdateAsync(user);
                if(!result.Succeeded)
                {
                    foreach (var errorMessage in result.Errors)
                    {
                        ModelState.AddModelError("", errorMessage.Description);
                        return View();
                    }
                }
                if (result.Succeeded)
                {
                    ViewBag.IsUpdated = true;
                    ModelState.Clear();
                    return View();
                }
            }
            

            return View(user);
        }*/
    }
}
