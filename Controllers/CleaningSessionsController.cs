using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CleanTrack.Data;
using CleanTrack.Entities;

namespace CleanTrack.Controllers
{
    public class CleaningSessionsController : Controller
    {
        private readonly AdminContext _context;

        public CleaningSessionsController(AdminContext context)
        {
            _context = context;
        }

        // GET: CleaningSessions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sessions.ToListAsync());
        }

        // GET: CleaningSessions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cleaningSession = await _context.Sessions
                .FirstOrDefaultAsync(m => m.CleaningSessionId == id);
            if (cleaningSession == null)
            {
                return NotFound();
            }

            return View(cleaningSession);
        }

        // GET: CleaningSessions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CleaningSessions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CleaningSessionId,StartTime,EndTime,IsBigMop")] CleaningSession cleaningSession)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cleaningSession);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cleaningSession);
        }

        // GET: CleaningSessions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cleaningSession = await _context.Sessions.FindAsync(id);
            if (cleaningSession == null)
            {
                return NotFound();
            }
            return View(cleaningSession);
        }

        // POST: CleaningSessions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CleaningSessionId,StartTime,EndTime,IsBigMop")] CleaningSession cleaningSession)
        {
            if (id != cleaningSession.CleaningId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cleaningSession);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CleaningSessionExists(cleaningSession.CleaningId))
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
            return View(cleaningSession);
        }

        // GET: CleaningSessions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cleaningSession = await _context.Sessions
                .FirstOrDefaultAsync(m => m.CleaningSessionId == id);
            if (cleaningSession == null)
            {
                return NotFound();
            }

            return View(cleaningSession);
        }

        // POST: CleaningSessions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cleaningSession = await _context.Sessions.FindAsync(id);
            _context.Sessions.Remove(cleaningSession);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CleaningSessionExists(int id)
        {
            return _context.Sessions.Any(e => e.CleaningSessionId == id);
        }
    }
}
