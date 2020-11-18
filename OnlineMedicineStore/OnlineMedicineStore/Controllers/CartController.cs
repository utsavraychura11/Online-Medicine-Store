using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineMedicineStore.Helpers;
using OnlineMedicineStore.Data;
using OnlineMedicineStore.Models;

namespace OnlineMedicineStore.Controllers
{
    public class CartController : Controller
    {

        private readonly AppDbContext Context;

        public CartController(AppDbContext context)
        {
            Context = context;
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
        public IActionResult Checkout(int id)
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(Item => Item.Medicines.Price * Item.Quantity);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            return View();


        }
    }
   }
