using CotoviaSite2.Data;
using CotoviaSite2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CotoviaSite2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var dados = await (from n in _context.Noticias
                         join nf in _context.FotosNoticias on n.ID equals nf.NoticiaFK
                         join f in _context.Fotografias on nf.FotoFK equals f.ID
                         where n.Estado == Estado.Publicada
                         select new NoticiasViewModel { 
                         ID = n.ID, Data = n.Data, Titulo=n.Titulo, Resumo=n.Resumo, Foto=f.Foto
                         }
                         ).OrderByDescending(m => m.Data).Take(3).ToListAsync();
            //return View(await _context.Noticias.Where(m => m.Estado == Estado.Publicada).Include(m => m.ListaFotografias).OrderByDescending(m => m.Data).Take(3).ToListAsync());
            return View(dados);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
