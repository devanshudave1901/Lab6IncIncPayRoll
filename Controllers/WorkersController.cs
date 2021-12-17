using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab6IncIncPayRoll.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Lab6IncIncPayRoll.Contexts;

namespace Lab6IncIncPayRoll.Controllers
{
   
    public class WorkersController : Controller
    {
        private readonly WorkerContext _context;

        public WorkersController(WorkerContext context)
        {
            _context = context;
        }

        // GET: Workers
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Workers.ToListAsync());

        }

        public async Task<IActionResult> Summary()
        {
            return View(await _context.Workers.ToListAsync());
        }

        // GET: Workers/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pieceworkWorkerModel = await _context.Workers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pieceworkWorkerModel == null)
            {
                return NotFound();
            }

            return View(pieceworkWorkerModel);
        }

        // GET: Workers/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Workers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Messages,IsSenior,Date")] PieceworkWorkerModel pieceworkWorkerModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pieceworkWorkerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pieceworkWorkerModel);
        }

        // GET: Workers/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pieceworkWorkerModel = await _context.Workers.FindAsync(id);
            if (pieceworkWorkerModel == null)
            {
                return NotFound();
            }
            return View(pieceworkWorkerModel);
        }

        // POST: Workers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Messages,IsSenior,Date")] PieceworkWorkerModel pieceworkWorkerModel)
        {
            if (id != pieceworkWorkerModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pieceworkWorkerModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PieceworkWorkerModelExists(pieceworkWorkerModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pieceworkWorkerModel);
        }

        // GET: Workers/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pieceworkWorkerModel = await _context.Workers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pieceworkWorkerModel == null)
            {
                return NotFound();
            }

            return View(pieceworkWorkerModel);
        }

        // POST: Workers/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pieceworkWorkerModel = await _context.Workers.FindAsync(id);
            _context.Workers.Remove(pieceworkWorkerModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        private bool PieceworkWorkerModelExists(int id)
        {
            return _context.Workers.Any(e => e.Id == id);
        }
    }
}
