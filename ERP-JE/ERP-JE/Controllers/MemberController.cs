using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_JE.Controllers
{
    public class MemberController : Controller
    {
        // GET: MemberController
        public ActionResult Index()
        {
            Models.DataManagement.DataAcces db = new Models.DataManagement.DataAcces();
            List<Models.Member> L = db.GetMembers();
            /*List<Models.Member> list = new List<Models.Member>();
            list.Add(new Models.Member(1,"Arnaud","SCHWARTZ"));
            list.Add(new Models.Member(2, "Anaïs", "ZANZUCCHI"));
            list.Add(new Models.Member(3, "Timothe", "FOCONE"));*/
            return View(L);
        }

        // GET: MemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemberController/Create
        public ActionResult New()
        {
            return View();
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult New(Models.Member m)
        {
            try
            {
                Models.DataManagement.DataAcces db = new Models.DataManagement.DataAcces();
                db.AddMember(m);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            
        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
