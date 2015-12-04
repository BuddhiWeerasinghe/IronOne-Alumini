using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Alumini_Assignment.Models;

namespace Alumini_Assignment.Controllers
{
    public class ProposalController : Controller
    {
        private ProposalDBContext db = new ProposalDBContext();

        // GET: /Proposal/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Proposal/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proposal proposal = db.Proposals.Find(id);
            if (proposal == null)
            {
                return HttpNotFound();
            }
            return View(proposal);
        }

        // GET: /Proposal/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: /Proposal/DataTable
        public ActionResult DataTable()
        {
            return View(db.Proposals.ToList());
        }
               

        // POST: /Proposal/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="proposalID,memberID,title,overview,deadline")] Proposal proposal)
        {
            if (ModelState.IsValid)
            {
                db.Proposals.Add(proposal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(proposal);
        }

        // GET: /Proposal/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proposal proposal = db.Proposals.Find(id);
            if (proposal == null)
            {
                return HttpNotFound();
            }
            return View(proposal);
        }

        // POST: /Proposal/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="proposalID,memberID,title,overview,deadline")] Proposal proposal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proposal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(proposal);
        }

        // GET: /Proposal/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proposal proposal = db.Proposals.Find(id);
            if (proposal == null)
            {
                return HttpNotFound();
            }
            return View(proposal);
        }

        // POST: /Proposal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Proposal proposal = db.Proposals.Find(id);
            db.Proposals.Remove(proposal);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
