using EntityTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using System.Linq;

namespace EntityTest.Controllers
{
    public class HomeController : Controller
    {
        MSContext db=new MSContext();
        public IActionResult Index()
        {
            ViewBag.Telebe = db.Telebes.ToList();
           
            return View();
        }
        public IActionResult NewStudents(Telebe t)
        {
            db.Telebes.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteStudents(int id)
        {
            Telebe tlb=db.Telebes.Find(id);
            db.Telebes.Remove(tlb);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateStudents(int id, Telebe t)
        {
            Telebe tlb = db.Telebes.Find(id);
            tlb.TelebeAd = t.TelebeAd;
            tlb.TelebeSoyad = t.TelebeSoyad;
            db.Telebes.Remove(tlb);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
