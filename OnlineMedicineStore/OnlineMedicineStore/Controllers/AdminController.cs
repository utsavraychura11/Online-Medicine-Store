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
using OnlineMedicineStore.Repository;


namespace OnlineMedicineStore.Controllers
{
    public class AdminController : Controller
    {
        // GET: AdminController
        private readonly AppDbContext Context;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IAdminRepository _adminRepository;

        public AdminController(AppDbContext context, 
            IWebHostEnvironment _webHostEnvironment,
            IAdminRepository adminRepository)
        {
            Context = context;
            webHostEnvironment = _webHostEnvironment;
            _adminRepository = adminRepository;
        }

        //Admin Login

        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(AdminModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Email.Equals("admin@gmail.com") && model.Password.Equals("admin"))
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Credintials");
                    return View();
                }
            }
            return View();
        }

        //Home Page of Admin
        public ActionResult Index()
        {
            return View();
        }

        //Add Medicine

        [HttpGet]
        public IActionResult Medicineregister()
        {
            return View();
        }
                
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  ActionResult Medicineregister(Medicine med)
        {
            if (ModelState.IsValid)
            {
               
                var medicine1 = new Medicine
                {
                    
                    MedicineName = med.MedicineName,
                    Description = med.Description,
                    Category = med.Category,
                    Price = med.Price,
                    IsPrescriptionRequired = med.IsPrescriptionRequired
                      
                };
                Context.Medicine.Add(medicine1);
                Context.SaveChangesAsync();               
                ModelState.Clear();
                ViewBag.IsMedicineRegistered = true;
                return View();
                
            }
            return View(med);
        }

        //View Medicine
        public IActionResult ViewMedicine()
        {
            var items = Context.Medicine.ToList();
            return View(items);
        }

        //Get Medicine
        [Route("/Admin/MedicineDetails/{id}")]
        public IActionResult GetMedicineDetails(int id)
        {
            var details = _adminRepository.GetMedicine(id);
            return View(details);
        }

        //Edit Medicine

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

        //Delete Medicine
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

        //View All Users

        [HttpGet]
        [Route("/view-users")]
        public ViewResult ViewUsers()
        {
            var allUsers = _adminRepository.GetAllUsers();
            return View(allUsers);
        }        

        //Delete User

        [HttpGet]
        public IActionResult DeleteUser(string id)
        {
            var user = _adminRepository.GetUser(id);
            if(user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ActionName("DeleteUser")]
        public IActionResult DeleteUserConfirmed(string id)
        {
            var user = _adminRepository.GetUser(id);
            _adminRepository.DeleteUser(user.Id);
            return RedirectToAction("ViewUsers","Admin");
        }

        //Admin Logout
        public IActionResult Logout()
        {
            return RedirectToAction("index", "Home");
        }

    }
}
