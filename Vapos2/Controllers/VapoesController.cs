using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vapos2.Context;
using Vapos2.Models;

namespace Vapos2.Controllers
{
    public class VapoesController : Controller
    {
        private readonly RegistrosContext _context;

        public VapoesController(RegistrosContext context)
        {
            _context = context;
        }

        // GET: Vapoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vapos.ToListAsync());
        }

        // GET: Vapoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vapo = await _context.Vapos
                .FirstOrDefaultAsync(m => m.IdVapo == id);
            if (vapo == null)
            {
                return NotFound();
            }

            return View(vapo);
        }

        // GET: Vapoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vapoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVapo,Intecambiador_Izq,Intecambiador_Der")] Vapo vapo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vapo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vapo);
        }

        // GET: Vapoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vapo = await _context.Vapos.FindAsync(id);
            if (vapo == null)
            {
                return NotFound();
            }
            return View(vapo);
        }

        // POST: Vapoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdVapo,Intecambiador_Izq,Intecambiador_Der")] Vapo vapo)
        {
            if (id != vapo.IdVapo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vapo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VapoExists(vapo.IdVapo))
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
            return View(vapo);
        }

        // GET: Vapoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vapo = await _context.Vapos
                .FirstOrDefaultAsync(m => m.IdVapo == id);
            if (vapo == null)
            {
                return NotFound();
            }

            return View(vapo);
        }

        // POST: Vapoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var vapo = await _context.Vapos.FindAsync(id);
            _context.Vapos.Remove(vapo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VapoExists(string id)
        {
            return _context.Vapos.Any(e => e.IdVapo == id);
        }
    }
}
