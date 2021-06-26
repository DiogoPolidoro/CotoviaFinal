using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CotoviaSite2.Data;
using CotoviaSite2.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace CotoviaSite2.Controllers
{
    public class UtilizadoresController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _path;


        public UtilizadoresController(ApplicationDbContext context, IWebHostEnvironment path)
        {
            _context = context;
            _path = path;
        }

        // GET: Utilizadores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Utilizadores.ToListAsync());
        }

        // GET: Utilizadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilizadores = await _context.Utilizadores
                .FirstOrDefaultAsync(m => m.ID == id);
            if (utilizadores == null)
            {
                return NotFound();
            }

            return View(utilizadores);
        }

        // GET: Utilizadores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Utilizadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nome,Email")] Utilizadores utilizador, IFormFile Foto)
        {
            if (Foto == null)
            {

                ModelState.AddModelError("", "you haven't choose a file. Please, pick one...");
                // send the control to Browser
                ViewData["Utilizadores"] = new SelectList(_context.Utilizadores.OrderBy(d => d.Nome), "Id", "Name");
                return View();
            }

            if (Foto.ContentType != "image/jpeg" && Foto.ContentType != "image/png")
            {

                ModelState.AddModelError("", "Your file is not of correct type. Please, choose PNG or JPG image...");

                ViewData["Utilizadores"] = new SelectList(_context.Utilizadores.OrderBy(d => d.Nome), "Id", "Name");
                return View();
            }

            Guid g;
            g = Guid.NewGuid();

            string extension = Path.GetExtension(Foto.FileName).ToLower();

            string nameOfFile = "" + g.ToString() + extension;


            if (ModelState.IsValid)
            {
                utilizador.Foto = nameOfFile;
                string whereToStoreTheFile = _path.WebRootPath;
                nameOfFile = Path.Combine(whereToStoreTheFile, "fotos", nameOfFile);

                using var stream = new FileStream(nameOfFile, FileMode.Create);
                await Foto.CopyToAsync(stream);

                
                _context.Add(utilizador);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(utilizador);
        }

        // GET: Utilizadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilizadores = await _context.Utilizadores.FindAsync(id);
            if (utilizadores == null)
            {
                return NotFound();
            }
            return View(utilizadores);
        }

        // POST: Utilizadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nome,Email,Foto")] Utilizadores utilizadores)
        {
            if (id != utilizadores.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(utilizadores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UtilizadoresExists(utilizadores.ID))
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
            return View(utilizadores);
        }

        // GET: Utilizadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilizadores = await _context.Utilizadores
                .FirstOrDefaultAsync(m => m.ID == id);
            if (utilizadores == null)
            {
                return NotFound();
            }

            return View(utilizadores);
        }

        // POST: Utilizadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var utilizadores = await _context.Utilizadores.FindAsync(id);
            _context.Utilizadores.Remove(utilizadores);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UtilizadoresExists(int id)
        {
            return _context.Utilizadores.Any(e => e.ID == id);
        }
    }
}
