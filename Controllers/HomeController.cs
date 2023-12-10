using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Survey_System.Models;

namespace Survey_System.Controllers
{
    public class HomeController : Controller
    {
        TaskContext DataBa = new TaskContext();
        public IActionResult Index()
        {
            return View(DataBa.Tb1Kbis.ToList());
        }
        public IActionResult New()
        {
            return View(new Tb1Kbi());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(Tb1Kbi tbK)
        {
            //   if(!ModelState.IsValid)
            //       return View("New", tbK);
            tbK.MeasurementUnit = true;
            tbK.Kpidnum = 1003;

            DataBa.Tb1Kbis.Add(tbK);
            DataBa.SaveChanges();

            return RedirectToAction("Index");
        }
        public bool DeleteItem(int id)
        {
            try
            {
                var item = GetById(id);
                DataBa.Tb1Kbis.Remove(item);
                DataBa.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public IActionResult Delete(int id)
        {
            DeleteItem(id);
            return RedirectToAction("Index");
        }

        // For Delete SPECIFIC ITEM
        public Tb1Kbi GetById(int id)
        {
            try
            {
                var tbK = DataBa.Tb1Kbis.FirstOrDefault(a => a.DepNo == id);
                return tbK;
            }
            catch
            {
                return new Tb1Kbi();
            }
        }





    }
}
