using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bakery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly BakeryContext _db;

    public FlavorsController(BakeryContext db)
    {
      _db = db;
    }

    [HttpGet("/flavors")]
    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavors.ToList();
      return View(model);
    }

    // public ActionResult Create()
    // {
    //   return View();
    // }

    // [HttpPost]
    // public ActionResult Create(Cuisine cuisine)
    // {
    //   _db.Cuisines.Add(cuisine);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Details(int id)
    // {
    //   var thisCuisine = _db.Cuisines
    //     .Include(cuisine => cuisine.Restaurants)
    //     .ThenInclude(join => join.Restaurant)
    //     .FirstOrDefault(cuisine => cuisine.CuisineId == id);
    //   return View(thisCuisine);
    // }

    // public ActionResult Edit(int id)
    // {
    //   var thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
    //   return View(thisCuisine);
    // }

    // [HttpPost]
    // public ActionResult Update(Cuisine cuisine)
    // {
    //   _db.Entry(cuisine).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   var thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
    //   return View(thisCuisine);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
    //   _db.Cuisines.Remove(thisCuisine);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}