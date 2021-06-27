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
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace CotoviaSite2.Controllers
{
    public class FotografiasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _path;

        public FotografiasController(ApplicationDbContext context, IWebHostEnvironment path)
        {
            _context = context;
            _path = path;
        }

        // GET: Fotografias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Fotografias.ToListAsync());
        }

        // GET: Fotografias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fotografias = await _context.Fotografias
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fotografias == null)
            {
                return NotFound();
            }

            return View(fotografias);
        }

        // GET: Fotografias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fotografias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,DataFoto,LocalFoto,Fotografo,AutorFK")] Fotografias fotografias, IFormFile Foto)
        {
            if (Foto == null)
            {

                ModelState.AddModelError("", "you haven't choose a file. Please, pick one...");
                // send the control to Browser
                ViewData["Fotografias"] = new SelectList(_context.Fotografias.OrderBy(d => d.Fotografo), "Id", "Fotografo");
                return View();
            }

            if (Foto.ContentType != "image/jpeg" && Foto.ContentType != "image/png")
            {

                ModelState.AddModelError("", "Your file is not of correct type. Please, choose PNG or JPG image...");

                ViewData["Fotografias"] = new SelectList(_context.Fotografias.OrderBy(d => d.Fotografo), "Id", "Fotografo");
                return View();
            }

            Guid g;
            g = Guid.NewGuid();

            string extension = Path.GetExtension(Foto.FileName).ToLower();

            string nameOfFile = "" + g.ToString() + extension;

            if (ModelState.IsValid)
            {
                fotografias.Foto = nameOfFile;
                string whereToStoreTheFile = _path.WebRootPath;
                nameOfFile = Path.Combine(whereToStoreTheFile, "fotos", nameOfFile);

                using var stream = new FileStream(nameOfFile, FileMode.Create);
                await Foto.CopyToAsync(stream);

                _context.Add(fotografias);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fotografias);
        }

        // GET: Fotografias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fotografias = await _context.Fotografias.FindAsync(id);
            if (fotografias == null)
            {
                return NotFound();
            }
            return View(fotografias);
        }

        // POST: Fotografias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Foto,DataFoto,LocalFoto,Fotografo,AutorFK")] Fotografias fotografias)
        {
            if (id != fotografias.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fotografias);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FotografiasExists(fotografias.ID))
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
            return View(fotografias);
        }

        // GET: Fotografias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fotografias = await _context.Fotografias
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fotografias == null)
            {
                return NotFound();
            }

            return View(fotografias);
        }

        // POST: Fotografias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fotografias = await _context.Fotografias.FindAsync(id);
            _context.Fotografias.Remove(fotografias);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FotografiasExists(int id)
        {
            return _context.Fotografias.Any(e => e.ID == id);
        }
    }
}
