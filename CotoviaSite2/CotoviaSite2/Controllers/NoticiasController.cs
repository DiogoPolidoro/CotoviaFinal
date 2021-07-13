using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CotoviaSite2.Data;
using CotoviaSite2.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;

namespace CotoviaSite2.Controllers
{
    public class NoticiasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public NoticiasController(ApplicationDbContext context, ILogger<HomeController> logger, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
        }

        // GET: Noticias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Noticias.Include(m => m.ListaFotografias).ToListAsync());
        }
        public async Task<IActionResult> AmbienteAsync()
        {
            return View(await _context.Noticias.Where(m => m.Estado == Estado.Publicada).Where(m => m.Tema == Tema.Ambiente).Include(m => m.ListaFotografias).OrderByDescending(m => m.Data).ToListAsync());
        }
        public async Task<IActionResult> CienciaAsync()
        {
            return View(await _context.Noticias.Where(m => m.Estado == Estado.Publicada).Where(m => m.Tema == Tema.Ciencia).Include(m => m.ListaFotografias).OrderByDescending(m => m.Data).ToListAsync());
        }
        public async Task<IActionResult> CulturaAsync()
        {
            return View(await _context.Noticias.Where(m => m.Estado == Estado.Publicada).Where(m => m.Tema == Tema.Cultura).Include(m => m.ListaFotografias).OrderByDescending(m => m.Data).ToListAsync());
        }
        public async Task<IActionResult> DesportoAsync()
        {
            return View(await _context.Noticias.Where(m => m.Estado == Estado.Publicada).Where(m => m.Tema == Tema.Desporto).Include(m => m.ListaFotografias).OrderByDescending(m => m.Data).ToListAsync());
        }
        public async Task<IActionResult> EconomiaAsync()
        {
            return View(await _context.Noticias.Where(m => m.Estado == Estado.Publicada).Where(m => m.Tema == Tema.Economia).Include(m => m.ListaFotografias).OrderByDescending(m => m.Data).ToListAsync());
        }
        public async Task<IActionResult> OpiniaoAsync()
        {
            return View(await _context.Noticias.Where(m => m.Estado == Estado.Publicada).Where(m => m.Tema == Tema.Opiniao).Include(m => m.ListaFotografias).OrderByDescending(m => m.Data).ToListAsync());
        }
        public async Task<IActionResult> PoliticaAsync()
        {
            return View(await _context.Noticias.Where(m => m.Estado == Estado.Publicada).Where(m => m.Tema == Tema.Politica).Include(m => m.ListaFotografias).OrderByDescending(m => m.Data).ToListAsync());
        }
        public async Task<IActionResult> SaudeAsync()
        {
            return View(await _context.Noticias.Where(m => m.Estado == Estado.Publicada).Where(m => m.Tema == Tema.Saude).Include(m => m.ListaFotografias).OrderByDescending(m => m.Data).ToListAsync());
        }
        public async Task<IActionResult> TecnologiaAsync()
        {
            return View(await _context.Noticias.Where(m => m.Estado == Estado.Publicada).Where(m => m.Tema == Tema.Tecnologia).Include(m => m.ListaFotografias).OrderByDescending(m => m.Data).ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> CorpoNot(int id)
        {
            ViewData["Noticia"] = await _context.Noticias.Include(m => m.ListaFotografias).Include(m => m.Autor).Where(n => n.ID == id).ToListAsync();
            return View();
        }

        // GET: Noticias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticias = await _context.Noticias
                .FirstOrDefaultAsync(m => m.ID == id);
            if (noticias == null)
            {
                return NotFound();
            }

            return View(noticias);
        }

        // GET: Noticias/Create
        public async Task<IActionResult> CreateAsync()
        {
            ViewData["fotos"] = await _context.Fotografias.Select(f => new SelectListItem() { Text = f.NomeFoto, Value = f.ID.ToString() }).ToListAsync();
            return View();
        }
        

        // POST: Noticias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Data,Titulo,Resumo,Conteudo,Tema")] Noticias noticias, int[] ListaFotografias)
        {
            if (ModelState.IsValid)
            {
                var utilizador = await _context.Utilizadores.FirstOrDefaultAsync(u => u.UserID == _userManager.GetUserId(User));
                noticias.AutorFK = utilizador.ID;
                //Estado por default é "Pendente" que é equivalente ao 0
                noticias.Estado = 0;
                _context.Add(noticias);
                await _context.SaveChangesAsync();
                foreach(var fotoID in ListaFotografias)
                {
                    _context.FotosNoticias.Add(new FotosNoticias { NoticiaFK = noticias.ID, FotoFK = fotoID });
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(noticias);
        }

        // GET: Noticias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticias = await _context.Noticias.FindAsync(id);
            if (noticias == null)
            {
                return NotFound();
            }
            ViewData["fotos"] = new SelectList(await _context.Fotografias.ToListAsync());
            return View(noticias);
        }

        // POST: Noticias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Data,Titulo,Resumo,Conteudo,Estado,Tema")] Noticias noticias)
        {
            if (id != noticias.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var utilizador = await _context.Utilizadores.FirstOrDefaultAsync(u => u.UserID == _userManager.GetUserId(User));
                    noticias.AutorFK = utilizador.ID;
                    _context.Update(noticias);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NoticiasExists(noticias.ID))
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
            return View(noticias);
        }

        // GET: Noticias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticias = await _context.Noticias
                .FirstOrDefaultAsync(m => m.ID == id);
            if (noticias == null)
            {
                return NotFound();
            }

            return View(noticias);
        }

        // POST: Noticias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var noticias = await _context.Noticias.FindAsync(id);
            _context.Noticias.Remove(noticias);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NoticiasExists(int id)
        {
            return _context.Noticias.Any(e => e.ID == id);
        }
    }
}
