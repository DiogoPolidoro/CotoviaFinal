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
using Microsoft.AspNetCore.Authorization;

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
        [Authorize]
        // GET: Noticias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Noticias.Include(m => m.ListaFotografias).ToListAsync());
        }
        public async Task<IActionResult> AmbienteAsync()
        {
            var dados = await (from n in _context.Noticias
                               join nf in _context.FotosNoticias on n.ID equals nf.NoticiaFK
                               join f in _context.Fotografias on nf.FotoFK equals f.ID
                               where n.Estado == Estado.Publicada && nf.Default == 1 && n.Tema == Tema.Ambiente
                               select new NoticiasViewModel
                               {
                                   ID = n.ID,
                                   Data = n.Data,
                                   Titulo = n.Titulo,
                                   Resumo = n.Resumo,
                                   Foto = f.Foto
                               }
                         ).OrderByDescending(m => m.Data).Take(3).ToListAsync();
            return View(dados);
        }
        public async Task<IActionResult> CienciaAsync()
        {
            var dados = await (from n in _context.Noticias
                               join nf in _context.FotosNoticias on n.ID equals nf.NoticiaFK
                               join f in _context.Fotografias on nf.FotoFK equals f.ID
                               where n.Estado == Estado.Publicada && nf.Default == 1 && n.Tema == Tema.Ciencia
                               select new NoticiasViewModel
                               {
                                   ID = n.ID,
                                   Data = n.Data,
                                   Titulo = n.Titulo,
                                   Resumo = n.Resumo,
                                   Foto = f.Foto
                               }
                                     ).OrderByDescending(m => m.Data).Take(3).ToListAsync();
            return View(dados);
        }
        public async Task<IActionResult> CulturaAsync()
        {
            var dados = await (from n in _context.Noticias
                               join nf in _context.FotosNoticias on n.ID equals nf.NoticiaFK
                               join f in _context.Fotografias on nf.FotoFK equals f.ID
                               where n.Estado == Estado.Publicada && nf.Default == 1 && n.Tema == Tema.Cultura
                               select new NoticiasViewModel
                               {
                                   ID = n.ID,
                                   Data = n.Data,
                                   Titulo = n.Titulo,
                                   Resumo = n.Resumo,
                                   Foto = f.Foto
                               }
                                     ).OrderByDescending(m => m.Data).Take(3).ToListAsync();
            return View(dados);
        }
        public async Task<IActionResult> DesportoAsync()
        {
            var dados = await (from n in _context.Noticias
                               join nf in _context.FotosNoticias on n.ID equals nf.NoticiaFK
                               join f in _context.Fotografias on nf.FotoFK equals f.ID
                               where n.Estado == Estado.Publicada && nf.Default == 1 && n.Tema == Tema.Desporto
                               select new NoticiasViewModel
                               {
                                   ID = n.ID,
                                   Data = n.Data,
                                   Titulo = n.Titulo,
                                   Resumo = n.Resumo,
                                   Foto = f.Foto
                               }
                                     ).OrderByDescending(m => m.Data).Take(3).ToListAsync();
            return View(dados);
        }
        public async Task<IActionResult> EconomiaAsync()
        {
            var dados = await (from n in _context.Noticias
                               join nf in _context.FotosNoticias on n.ID equals nf.NoticiaFK
                               join f in _context.Fotografias on nf.FotoFK equals f.ID
                               where n.Estado == Estado.Publicada && nf.Default == 1 && n.Tema == Tema.Economia
                               select new NoticiasViewModel
                               {
                                   ID = n.ID,
                                   Data = n.Data,
                                   Titulo = n.Titulo,
                                   Resumo = n.Resumo,
                                   Foto = f.Foto
                               }
                                     ).OrderByDescending(m => m.Data).Take(3).ToListAsync();
            return View(dados);
        }
        public async Task<IActionResult> OpiniaoAsync()
        {
            var dados = await (from n in _context.Noticias
                               join nf in _context.FotosNoticias on n.ID equals nf.NoticiaFK
                               join f in _context.Fotografias on nf.FotoFK equals f.ID
                               where n.Estado == Estado.Publicada && nf.Default == 1 && n.Tema == Tema.Opiniao
                               select new NoticiasViewModel
                               {
                                   ID = n.ID,
                                   Data = n.Data,
                                   Titulo = n.Titulo,
                                   Resumo = n.Resumo,
                                   Foto = f.Foto
                               }
                                     ).OrderByDescending(m => m.Data).Take(3).ToListAsync();
            return View(dados);
        }
        public async Task<IActionResult> PoliticaAsync()
        {
            var dados = await (from n in _context.Noticias
                               join nf in _context.FotosNoticias on n.ID equals nf.NoticiaFK
                               join f in _context.Fotografias on nf.FotoFK equals f.ID
                               where n.Estado == Estado.Publicada && nf.Default == 1 && n.Tema == Tema.Politica
                               select new NoticiasViewModel
                               {
                                   ID = n.ID,
                                   Data = n.Data,
                                   Titulo = n.Titulo,
                                   Resumo = n.Resumo,
                                   Foto = f.Foto
                               }
                                     ).OrderByDescending(m => m.Data).Take(3).ToListAsync();
            return View(dados);
        }
        public async Task<IActionResult> SaudeAsync()
        {
            var dados = await (from n in _context.Noticias
                               join nf in _context.FotosNoticias on n.ID equals nf.NoticiaFK
                               join f in _context.Fotografias on nf.FotoFK equals f.ID
                               where n.Estado == Estado.Publicada && nf.Default == 1 && n.Tema == Tema.Saude
                               select new NoticiasViewModel
                               {
                                   ID = n.ID,
                                   Data = n.Data,
                                   Titulo = n.Titulo,
                                   Resumo = n.Resumo,
                                   Foto = f.Foto
                               }
                                     ).OrderByDescending(m => m.Data).Take(3).ToListAsync();
            return View(dados);
        }
        public async Task<IActionResult> TecnologiaAsync()
        {
            var dados = await (from n in _context.Noticias
                               join nf in _context.FotosNoticias on n.ID equals nf.NoticiaFK
                               join f in _context.Fotografias on nf.FotoFK equals f.ID
                               where n.Estado == Estado.Publicada && nf.Default == 1 && n.Tema == Tema.Tecnologia
                               select new NoticiasViewModel
                               {
                                   ID = n.ID,
                                   Data = n.Data,
                                   Titulo = n.Titulo,
                                   Resumo = n.Resumo,
                                   Foto = f.Foto
                               }
                                     ).OrderByDescending(m => m.Data).Take(3).ToListAsync();
            return View(dados);
        }
        [HttpGet]
        public async Task<IActionResult> CorpoNot(int id)
        {
            ViewData["Noticia"] = await _context.Noticias.Include(m => m.ListaFotografias).Include(m => m.Autor).Where(n => n.ID == id).ToListAsync();
            ViewData["fotos"] = await (from n in _context.Noticias
                                       join nf in _context.FotosNoticias on n.ID equals nf.NoticiaFK
                                       join f in _context.Fotografias on nf.FotoFK equals f.ID
                                       where n.ID == id
                                       select f.Foto
                        ).ToListAsync();
            return View();
        }

        [Authorize(Roles = "revisor")]
        // GET: Noticias/Aprovar/5
        [HttpGet]
        public async Task<IActionResult> Aprovar(int? id)
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
            ViewData["fotos"] = await (from n in _context.Noticias
                                       join nf in _context.FotosNoticias on n.ID equals nf.NoticiaFK
                                       join f in _context.Fotografias on nf.FotoFK equals f.ID
                                       where n.ID == id
                                       select f.Foto
                        ).ToListAsync();
            return View(noticias);
        }
        [Authorize(Roles = "revisor")]
        [HttpPost]
        public async Task<IActionResult> Aprovar(int? id, [Bind("ID,Data,Titulo,Resumo,Conteudo,Tema,Estado")] Noticias estadoNoticia)
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
            ViewData["fotos"] = await (from n in _context.Noticias
                                       join nf in _context.FotosNoticias on n.ID equals nf.NoticiaFK
                                       join f in _context.Fotografias on nf.FotoFK equals f.ID
                                       where n.ID == id
                                       select f.Foto
                        ).ToListAsync();
            noticias.Estado = estadoNoticia.Estado;
            _context.Update(noticias);
            await _context.SaveChangesAsync();
            return View(noticias);
        }
        [Authorize(Roles = "autor")]
        // GET: Noticias/Create
        public async Task<IActionResult> CreateAsync()
        {
            ViewData["fotos"] = await _context.Fotografias.Select(f => new SelectListItem() { Text = f.NomeFoto, Value = f.ID.ToString() }).ToListAsync();
            return View();
        }


        // POST: Noticias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more Aprovar, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "autor")]
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
                var i = 0;
                foreach(var fotoID in ListaFotografias)
                {
                    var associadas = new FotosNoticias
                    {
                        NoticiaFK = noticias.ID,
                        FotoFK = fotoID
                    };
                    if (i == 0)
                        associadas.Default = 1;
                    else
                        associadas.Default = 0;
                    _context.FotosNoticias.Add(associadas);
                    noticias.ListaFotografias.Add(associadas);
                    i++;
                }
                _context.Noticias.Update(noticias);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(noticias);
        }

        [Authorize(Roles = "autor")]
        // GET: Noticias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticias = await _context.Noticias.Include(n => n.ListaFotografias).Where(n => n.ID == id).FirstAsync();
            if (noticias == null)
            {
                return NotFound();
            }
            var fotosId = await (from n in _context.Noticias
                                 join nf in _context.FotosNoticias on n.ID equals nf.NoticiaFK
                                 join f in _context.Fotografias on nf.FotoFK equals f.ID
                                 where n.ID == id
                                 select f.ID
                        ).ToListAsync();
            ViewData["fotos"] = await _context.Fotografias.Select(f => (fotosId.Contains(f.ID) == true) ? new SelectListItem() { Text = f.NomeFoto, Value = f.ID.ToString(), Selected = true }: new SelectListItem() { Text = f.NomeFoto, Value = f.ID.ToString() }).ToListAsync();
            ViewData["fotografias"] = await (from n in _context.Noticias
                                       join nf in _context.FotosNoticias on n.ID equals nf.NoticiaFK
                                       join f in _context.Fotografias on nf.FotoFK equals f.ID
                                       where n.ID == id
                                       select f.Foto
                        ).ToListAsync();
            
            return View(noticias);
        }

        // POST: Noticias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more Aprovar, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "autor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Data,Titulo,Resumo,Conteudo,Estado,Tema")] Noticias noticias, int[] ListaFotografias)
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
                    if(ListaFotografias.Length != 0) { 
                        var associadas = await _context.FotosNoticias.Where(fn => fn.NoticiaFK == id).ToListAsync();
                        foreach (var fn in associadas)
                        {
                            _context.FotosNoticias.Remove(fn);
                        }
                        await _context.SaveChangesAsync();
                        var i = 0;
                        foreach (var fotoID in ListaFotografias)
                        {
                            if (i == 0)
                                _context.FotosNoticias.Add(new FotosNoticias { NoticiaFK = noticias.ID, FotoFK = fotoID, Default = 1 });
                            else
                                _context.FotosNoticias.Add(new FotosNoticias { NoticiaFK = noticias.ID, FotoFK = fotoID, Default = 0 });
                            i++;
                        }
                        await _context.SaveChangesAsync();
                    }
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
        [Authorize]
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
        [Authorize]
        // POST: Noticias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var associadas = await _context.FotosNoticias.Where(fn => fn.NoticiaFK == id).ToListAsync();        
            foreach(var fn in associadas)
            {
                _context.FotosNoticias.Remove(fn);
            }
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
