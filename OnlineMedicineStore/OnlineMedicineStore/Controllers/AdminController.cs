using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineMedicineStore.Data;
using OnlineMedicineStore.Models;

namespace OnlineMedicineStore.Controllers
{
    public class AdminController : Controller
    {
        // GET: AdminController
        private readonly AppDbContext Context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public AdminController(AppDbContext context, IWebHostEnvironment _webHostEnvironment)
        {
            Context = context;
            webHostEnvironment = _webHostEnvironment;
        }


        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Medicineregister()
        {
            return View();
        }
        
        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Medicineregister(Medicine med)
        {
            if (ModelState.IsValid)
            {
                //Write Your Code
             

                var medicine1 = new Medicine
                {
                    
                    MedicineName = med.MedicineName,
                    Description = med.Description,
                    Category = med.Category,
                    Price = med.Price,
                    IsPrescriptionRequired = med.IsPrescriptionRequired
                 
                      
                };
                Context.Medicine.Add(medicine1);
                Context.SaveChanges();

                ViewBag.message = "succefuullyy registered!!!!";


                /* var result = await _accountRepository.CreateUserAsync(med);
                 if (!result.Succeeded)
                 {
                     foreach (var errorMessage in result.Errors)
                     {
                         ModelState.AddModelError("", errorMessage.Description);
                     }
                     return View();
                 }
                */
                ModelState.Clear();
                return View();
            }

            return View(med);
        }

        public IActionResult AdminLogin()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return RedirectToAction("index","Home");
        }


        [HttpPost]
        public ViewResult AdminLogin(string email1 , string password1)
        {

            if (password1 == "admin" && email1 == "admin@gmail.com")
                return View("/Admin/index/");
            else
                ViewBag.message = "invalid credentials !!";
            return View();
            
            
        }
        public IActionResult ViewMedicine()
        {
            var items = Context.Medicine.ToList();
            return View(items);
        }

        public ActionResult Edit(int id)
        {

            return View(Context.Medicine.Where(x => x.Id == id).FirstOrDefault());
            


        }
        [HttpPost]
        public  ActionResult Edit(int id, Medicine med1)
        {
            try {
                Context.Entry(med1).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                Context.SaveChanges();
                return RedirectToAction("ViewMedicine");
            }
            catch  {
                return View();
            }

        }
        public ActionResult Delete(int id)
        {

            return View(Context.Medicine.Where(x => x.Id == id).FirstOrDefault());



        }
        [HttpPost]
        public ActionResult Delete(int id, Medicine med1)
        {
            try
            {
                Medicine med2 = Context.Medicine.Where(x => x.Id == id).FirstOrDefault();
                Context.Medicine.Remove(med2);
                Context.SaveChanges();
                return RedirectToAction("ViewMedicine");
            }
            catch
            {
                return View();
            }

        }



    }
    }
