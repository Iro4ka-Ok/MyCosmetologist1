using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCosmetologist.Context;
using MyCosmetologist.Models;

namespace MyCosmetologist.Controllers
{
    public class CustomerController : Controller
    {
        private DatabaseContext db;
        public CustomerController(DatabaseContext context)
        {
            db = context;
        }
        /*public IActionResult Index()
        {
           return View();
        }*/
        public async Task<IActionResult> Index()
        {
            return View(await db.Customers.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            db.Customers.Add(customer);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

       /* public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Customer customer = await db.Customers.FirstOrDefaultAsync(c => c.Id == id);
                if (customer != null)
                    return View(customer);
            }
            return NotFound();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Customer customer = await db.Customers.FirstOrDefaultAsync(p => p.Id == id);
                if (customer != null)
                    return View(customer);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Customer customer)
        {
            db.Customers.Update(customer);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Customer customer = await db.Customers.FirstOrDefaultAsync(p => p.Id == id);
                if (customer != null)
                    return View(customer);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Customer customer = new Customer { Id = id.Value };
                db.Entry(customer).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }*/
    }
}