using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering; //For SelectList
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;



namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController (HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients.ToList();
      return View(model);
    }

    public ActionResult Details(int id)
    {
      Client model = _db.Clients.FirstOrDefault(cust => cust.ClientId == id);
      ViewBag.Stylist = _db.Stylists.FirstOrDefault(emp => emp.StylistId == model.StylistId);
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Specialty" );
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client cust)
    {
      _db.Clients.Add(cust);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}