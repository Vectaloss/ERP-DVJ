using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_JE.Controllers
{
    public class ProspectionsController : Controller
    {
        public ActionResult Index()
        {
            Models.DataManagement.DataAcces db = new Models.DataManagement.DataAcces();
            return View(db.GetProspections());
        }
        public ActionResult CustomerChoice()
        {
            Models.DataManagement.DataAcces db = new Models.DataManagement.DataAcces();
            return View(db.GetCustomers());
        }
        public ActionResult PersonContacted(int IdCustomer)
        {
            Models.DataManagement.DataAcces db = new Models.DataManagement.DataAcces();
            ViewBag.IdCustomer = IdCustomer; //sert a passer a la vue de création de contacts l'id de client
            ViewBag.Customer = db.GetCustomer(IdCustomer).Name;
            return View(db.GetContacts(IdCustomer));
        }
        
        public ActionResult NewCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewCustomer(Models.Customers C)
        {
            try
            {
                Models.DataManagement.DataAcces db = new Models.DataManagement.DataAcces();
                db.AddCustomer(C);
                C = db.GetCustomerBySIREN(C.SIREN);
                return RedirectToAction(nameof(PersonContacted),new { IdCustomer= C.IdCustomer});
            }
            catch
            {
                return RedirectToAction(nameof(PersonContacted), new { IdCustomer = C.IdCustomer });
            }
        }
        public ActionResult NewContact(int IdCustomer)
        {
            ViewBag.IdCustomer = IdCustomer;
            return View();
        }

        [HttpPost]
        public ActionResult NewContact(Models.Contacts C)
        {
            try
            {
                Models.DataManagement.DataAcces db = new Models.DataManagement.DataAcces();
                db.AddContact(C);
                return RedirectToAction(nameof(CustomerChoice));
            }
            catch
            {
                return View();
            }
                
        }
        public ActionResult NewProspection(int IdContact)
        {
            ViewBag.IdContact = IdContact;
            return View();
        }
        [HttpPost]
        public ActionResult NewProspection(Models.Prospections P)
        {
            
                Models.DataManagement.DataAcces db = new Models.DataManagement.DataAcces();
                db.AddProspection(P);
                return RedirectToAction(nameof(Index));
        }
        
    }
}
