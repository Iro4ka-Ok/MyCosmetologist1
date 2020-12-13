using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCosmetologist.Web.Context;
using MyCosmetologist.Web.Models;
using MyCosmetologist.Web.ViewModel;

namespace MyCosmetologist.Web.Controllers
{
    public class ClientController : Controller
    {
        private DatabaseContext db;
        public ClientController(DatabaseContext context)
        {
            db = context;
        }
        public ActionResult Index()
        {
            //var client = db?.Clients?.AsEnumerable().Select(s => new ClientViewModel(s)).ToList() ?? new List<ClientViewModel>();
            //return View(client);
            return View();
        }

        // GET: Clients/Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return NotFound();
            }
            Client client = db.Clients.Find(id);
            if (client == null)
            {
                return NotFound();
            }
            ClientViewModel viewModel = new ClientViewModel()
            {
                Id = client.Id,
                Name = client.Name,
                SurName = client.SurName,
                Email = client.Email,
                Phone = client.Phone,
                BirthDate = client.BirthDate,
                Gender = client.Gender,
                PhotoFirst = client.PhotoFirst,
                PhotoLast = client.PhotoLast
            };
            return View(viewModel);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            ClientViewModel viewModel = new ClientViewModel();
            return View(viewModel);
        }

        // POST: Clients/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientViewModel clientViewModel)
        {
            if (ModelState.IsValid)
            {
                Client client = new Client()
                {
                    Id = clientViewModel.Id,
                    Name = clientViewModel.Name,
                    SurName = clientViewModel.SurName,
                    Email = clientViewModel.Email,
                    Phone = clientViewModel.Phone,
                    BirthDate = clientViewModel.BirthDate,
                    Gender = clientViewModel.Gender,
                    PhotoFirst = clientViewModel.PhotoFirst,
                    PhotoLast = clientViewModel.PhotoLast
                };

                db.Clients.Add(client);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clientViewModel);
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return NotFound();
            }
            Client client = db.Clients.Find(id);
            if (client == null)
            {
                return NotFound();
            }
            ClientViewModel viewModel = new ClientViewModel()
            {
                Id = client.Id,
                Name = client.Name,
                SurName = client.SurName,
                Email = client.Email,
                Phone = client.Phone,
                BirthDate = client.BirthDate,
                Gender = client.Gender,
                PhotoFirst = client.PhotoFirst,
                PhotoLast = client.PhotoLast
            };

            return View(viewModel);
        }

        // POST: Clients/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClientViewModel clientViewModel)
        {
            if (ModelState.IsValid)
            {
                Client client = new Client()
                {
                    Id = clientViewModel.Id,
                    Name = clientViewModel.Name,
                    SurName = clientViewModel.SurName,
                    Email = clientViewModel.Email,
                    Phone = clientViewModel.Phone,
                    BirthDate = clientViewModel.BirthDate,
                    Gender = clientViewModel.Gender,
                    PhotoFirst = clientViewModel.PhotoFirst,
                    PhotoLast = clientViewModel.PhotoLast
                };

                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clientViewModel);
        }

        // GET: Clients/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //        return NotFound();
        //    }
        //    Client client = db.Clients.Find(id);
        //    if (client == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(client);
        //}

        // POST: Clients/Delete/5

        [HttpDelete]
        public void Delete(int id)
        {
            Client client = db.Clients.Find(id);
            db.Clients.Remove(client);
            db.SaveChanges();
            return;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult GetItems(string search)
        {
            var model = new ClientsViewModel();
            var query = (IQueryable<Client>)db?.Clients;

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(g => g.Name.ToUpper().Contains(search.ToUpper()));
            }
            var clients = query.Select(s => new ClientViewModel(s)).ToList() ?? new List<ClientViewModel>();

            model.Items = clients;

            return PartialView("_Items", model);
        }
    }
}