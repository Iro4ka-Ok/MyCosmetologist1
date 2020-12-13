using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyCosmetologist.Context;
using MyCosmetologist.Models;
using MyCosmetologist.ViewModel;

namespace MyCosmetologist.Controllers
{
    public class RecordController : Controller
    {
        private DatabaseContext db;
        public RecordController(DatabaseContext context)
        {
            db = context;
        }
        public ActionResult Index()
        {
            var record = db?.Records?.AsEnumerable().Select(s => new RecordViewModel(s)).ToList() ?? new List<RecordViewModel>();
            return View(record);
            //return View();
        }

        // GET: Records/Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return NotFound();
            }
            Record record = db.Records.Find(id);
            if (record == null)
            {
                return NotFound();
            }
            RecordViewModel viewModel = new RecordViewModel()
            {
                Id = record.Id,
                ClientId = record.ClientId,
                ProcedureId = record.ProcedureId,
                DayRecord = record.DayRecord,
                TimeRecord = record.TimeRecord,
                Comment = record.Comment,
                Client = record.Client,
                Procedure = record.Procedure
            };
            return View(viewModel);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            RecordViewModel viewModel = new RecordViewModel();
            return View(viewModel);
        }

        // POST: Records/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RecordViewModel recordViewModel)
        {
            
            if (ModelState.IsValid)
            {
                Record record = new Record()
                {
                    Id = recordViewModel.Id,
                    ClientId = recordViewModel.ClientId,
                    ProcedureId = recordViewModel.ProcedureId,
                    DayRecord = recordViewModel.DayRecord,
                    TimeRecord = recordViewModel.TimeRecord,
                    Comment = recordViewModel.Comment,
                    Client = recordViewModel.Client,
                    Procedure = recordViewModel.Procedure
                };

                db.Records.Add(record);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recordViewModel);
        }
    }
}