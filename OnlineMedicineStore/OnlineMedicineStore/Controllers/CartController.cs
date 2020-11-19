using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OnlineMedicineStore.Helpers;
using OnlineMedicineStore.Data;
using OnlineMedicineStore.Models;
using OnlineMedicineStore.Service;
using Microsoft.AspNetCore.Identity;

namespace OnlineMedicineStore.Controllers
{
    public class CartController : Controller
    {
        private readonly IUserService _userService;
        private readonly UserManager<ApplicationUser> _userManager;


        private readonly AppDbContext Context;

        private readonly AppDbContext Context1;

        public CartController(IUserService userService,
            UserManager<ApplicationUser> userManager, AppDbContext context)
        {
            _userService = userService;
            _userManager = userManager;
            Context = context;
            Context1 = context;

        }

        public IActionResult Index()
        {
            ViewBag.val = false;
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(Item => Item.Medicines.Price * Item.Quantity);

            return View();
        }
        private int isExist(int id)
        {

            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {




                for (int i = 0; i < cart.Count; i++)
                {
                    if (cart[i].Medicines.Id == id)
                    {
                        return i;

                    }

                }
            }

            return -1;

        }
        public IActionResult Buy(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");

            if (cart == null)
            {

                List<Item> cart1 = new List<Item>();
                cart1.Add(new Item { Medicines = Context.Medicine.Where(x => x.Id == id).FirstOrDefault(), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart1);

            }
            else
            {
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {

                    cart.Add(new Item { Medicines = Context.Medicine.Where(x => x.Id == id).FirstOrDefault(), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            }
            return RedirectToAction("Index");
        }
        public IActionResult Remove(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");

            int index = isExist(id);

            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            return RedirectToAction("index");

        }
        public async System.Threading.Tasks.Task<IActionResult> CheckoutAsync(int id)
        {
           /* var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(Item => Item.Medicines.Price * Item.Quantity);
            var userId = _userService.GetUserId();
            if (userId == null)
            {
                return NotFound();
            }

            var user = _userManager.FindByIdAsync(userId).Result;
            
            Order1 o1 = new Order1();
            o1.ApplicationUserId = userId;
            o1.user = user;
            Context.Order1.Add(o1);
            await   Context.SaveChangesAsync();
            
            /* System.Threading.Thread.Sleep(4000);
             List<Order> o3 = Context1.Order.Where(x => x.ApplicationUserId == userId).ToList();
          4
            Order1 o2 = Context1.Order1.Where(x => x.ApplicationUserId == userId).FirstOrDefault();
            foreach (var c1 in cart)
            {
                OrderMedicine1 om1 = new OrderMedicine1();
                om1.ApplicationUserId = userId;
                om1.user = user;
                om1.OrderId = o2.Id;
                om1.Order = o2;
                om1.Medicines = c1.Medicines;
                om1.Quantity = c1.Quantity;
                om1.Price_total = (c1.Quantity * c1.Medicines.Price);
                Context.OrderMedicine1.Add(om1);
               await  Context.SaveChangesAsync();



            }






            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            */
            return View();


        }
    }
   }
