using FiscoPortal.Data;
using FiscoPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FiscoPortal.Controllers
{
    public class DashboardController : Controller
    {
        private ApplicationDbContext _db;

        public DashboardController(ApplicationDbContext db)
        {
            _db = db;
            
        }

        public IActionResult Index()
        {
            return View(_db.FiscalPrinter.ToList());
        }

        //Get Create method
        public IActionResult Create()
        {
      
            return View();
        }

        //Post Create method
        [HttpPost]
        public async Task<IActionResult> Create(FiscalPrinter fiscalPrinter)
        {
            if (ModelState.IsValid)
            {
                _db.FiscalPrinter.Add(fiscalPrinter);
                await _db.SaveChangesAsync();
                TempData["save"] = "Продуктът е успешно създаден!";
                return RedirectToAction(nameof(Index));
            }

            return View(fiscalPrinter);
        }

        //GET Edit Action Method
        public ActionResult Edit(int? id)
        {
             if (id == null)
            {
                return NotFound();
            }

            var product = _db.FiscalPrinter.FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        //POST Edit Action Method
        [HttpPost]
        public async Task<IActionResult> Edit(FiscalPrinter fiscalPrinter)
        {
            if (ModelState.IsValid)
            {

                _db.FiscalPrinter.Update(fiscalPrinter);
                await _db.SaveChangesAsync();
                TempData["edit"] = "Продуктът е успешно редактиран!";
                return RedirectToAction(nameof(Index));
            }

            return View(fiscalPrinter);
        }

        //GET Details Action Method
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var product = _db.FiscalPrinter.FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        //GET Delete Action Method

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _db.FiscalPrinter.Where(c => c.Id == id).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        //POST Delete Action Method

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _db.FiscalPrinter.FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            _db.FiscalPrinter.Remove(product);
            await _db.SaveChangesAsync();
            TempData["delete"] = "Продуктът е успешно изтрит!";
            return RedirectToAction(nameof(Index));
        }

    }
}
