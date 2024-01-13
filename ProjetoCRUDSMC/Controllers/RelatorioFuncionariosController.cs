using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoCRUDSMC.Data;
using ProjetoCRUDSMC.Models;

namespace ProjetoCRUDSMC.Controllers
{
    public class RelatorioFuncionariosController : Controller
    {
        private readonly RelatorioFuncionarioContext _context;

        public RelatorioFuncionariosController(RelatorioFuncionarioContext context)
        {
            _context = context;
        }

        // GET: RelatorioFuncionarios
        public async Task<IActionResult> Index()
        {
              return _context.RelatorioFuncionarios != null ? 
                          View(await _context.RelatorioFuncionarios.ToListAsync()) :
                          Problem("Entity set 'RelatorioFuncionarioContext.RelatorioFuncionarios'  is null.");
        }

        // GET: RelatorioFuncionarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RelatorioFuncionarios == null)
            {
                return NotFound();
            }

            var relatorioFuncionario = await _context.RelatorioFuncionarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (relatorioFuncionario == null)
            {
                return NotFound();
            }

            return View(relatorioFuncionario);
        }

        // GET: RelatorioFuncionarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RelatorioFuncionarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FuncionarioId,DataRelatorio,Relatorio")] RelatorioFuncionario relatorioFuncionario)
        {
            if (ModelState.IsValid)
            {
                relatorioFuncionario.DataRelatorio = DateTime.Now;
                _context.Add(relatorioFuncionario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(relatorioFuncionario);
        }

        // GET: RelatorioFuncionarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RelatorioFuncionarios == null)
            {
                return NotFound();
            }

            var relatorioFuncionario = await _context.RelatorioFuncionarios.FindAsync(id);
            if (relatorioFuncionario == null)
            {
                return NotFound();
            }
            return View(relatorioFuncionario);
        }

        // POST: RelatorioFuncionarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FuncionarioId,DataRelatorio,Relatorio")] RelatorioFuncionario relatorioFuncionario)
        {
            if (id != relatorioFuncionario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    relatorioFuncionario.DataRelatorio = DateTime.Now;
                    _context.Update(relatorioFuncionario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RelatorioFuncionarioExists(relatorioFuncionario.Id))
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
            return View(relatorioFuncionario);
        }

        // GET: RelatorioFuncionarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RelatorioFuncionarios == null)
            {
                return NotFound();
            }

            var relatorioFuncionario = await _context.RelatorioFuncionarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (relatorioFuncionario == null)
            {
                return NotFound();
            }

            return View(relatorioFuncionario);
        }

        // POST: RelatorioFuncionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RelatorioFuncionarios == null)
            {
                return Problem("Entity set 'RelatorioFuncionarioContext.RelatorioFuncionarios'  is null.");
            }
            var relatorioFuncionario = await _context.RelatorioFuncionarios.FindAsync(id);
            if (relatorioFuncionario != null)
            {
                _context.RelatorioFuncionarios.Remove(relatorioFuncionario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RelatorioFuncionarioExists(int id)
        {
          return (_context.RelatorioFuncionarios?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
