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
    public class RegistroesController : Controller
    {
        private readonly RegistrosContext _context;
        private List<Registro> records;
        private PaginadorGenerico<Registro> _PaginadorCustomers;

        public RegistroesController(RegistrosContext context)
        {
            _context = context;
        }

        // GET: Registroes
        public async Task<IActionResult> Index(String vapo)
        {
            var records = _context.Registos.ToList();
            if((vapo=="") || (vapo==null))
            {
                return View(records);
            }
            else {
                return View(records.Where(x => x.IdVapo.Equals(vapo)));
            }
        }

        // GET: Registroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registro = await _context.Registos
                .Include(r => r.responsable)
                .Include(r => r.vaporizator)
                .FirstOrDefaultAsync(m => m.IdRegistro == id);
            if (registro == null)
            {
                return NotFound();
            }

            return View(registro);
        }

        // GET: Registroes/Create
        public IActionResult Create()
        {
            ViewData["nombreApe"] = new SelectList(_context.Personas, "nombreApe", "nombreApe");
            ViewData["IdVapo"] = new SelectList(_context.Vapos, "IdVapo", "IdVapo");
            return View();
        }

        // POST: Registroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRegistro,fecha,IdVapo,nombreApe,Prueba_Hidráulica,Prueba_Estanqueidad,Prueba_Funcionamiento,Detalles")] Registro registro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["nombreApe"] = new SelectList(_context.Personas, "nombreApe", "nombreApe", registro.nombreApe);
            ViewData["IdVapo"] = new SelectList(_context.Vapos, "IdVapo", "IdVapo", registro.IdVapo);
            return View(registro);
        }

        // GET: Registroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registro = await _context.Registos.FindAsync(id);
            if (registro == null)
            {
                return NotFound();
            }
            ViewData["nombreApe"] = new SelectList(_context.Personas, "nombreApe", "nombreApe", registro.nombreApe);
            ViewData["IdVapo"] = new SelectList(_context.Vapos, "IdVapo", "IdVapo", registro.IdVapo);
            return View(registro);
        }

        // POST: Registroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdRegistro,fecha,IdVapo,nombreApe,Prueba_Hidráulica,Prueba_Estanqueidad,Prueba_Funcionamiento,Detalles")] Registro registro)
        {
            if (id != registro.IdRegistro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistroExists(registro.IdRegistro))
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
            ViewData["nombreApe"] = new SelectList(_context.Personas, "nombreApe", "nombreApe", registro.nombreApe);
            ViewData["IdVapo"] = new SelectList(_context.Vapos, "IdVapo", "IdVapo", registro.IdVapo);
            return View(registro);
        }

        // GET: Registroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registro = await _context.Registos
                .Include(r => r.responsable)
                .Include(r => r.vaporizator)
                .FirstOrDefaultAsync(m => m.IdRegistro == id);
            if (registro == null)
            {
                return NotFound();
            }

            return View(registro);
        }

        // POST: Registroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registro = await _context.Registos.FindAsync(id);
            _context.Registos.Remove(registro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistroExists(int id)
        {
            return _context.Registos.Any(e => e.IdRegistro == id);
        }
    }
}
