using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CotoviaSite2.Data;
using CotoviaSite2.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace CotoviaSite2.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class FotografiasAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _path;

        public FotografiasAPIController(ApplicationDbContext context, IWebHostEnvironment path)
        {
            _context = context;
            _path = path;
        }

        // GET: api/FotografiasAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FotografiasApiViewModel>>> GetFotografias()
        {
            return await _context.Fotografias
                                 .Select(f => new FotografiasApiViewModel
                                 {
                                     IdFoto = f.ID,
                                     Foto = f.Foto,
                                     DataFoto = f.DataFoto.ToShortDateString(),
                                     LocalFoto = f.LocalFoto,
                                     NomeFotografo = f.Fotografo
                                 }).ToListAsync();
        }

        // GET: api/FotografiasAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fotografias>> GetFotografias(int id)
        {
            var fotografias = await _context.Fotografias.FindAsync(id);

            if (fotografias == null)
            {
                return NotFound();
            }

            return fotografias;
        }

        // PUT: api/FotografiasAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFotografias(int id, Fotografias fotografias)
        {
            if (id != fotografias.ID)
            {
                return BadRequest();
            }

            _context.Entry(fotografias).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FotografiasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FotografiasAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Fotografias>> PostFotografias([FromForm]Fotografias fotografias, IFormFile Foto)
        {
            Guid g;
            g = Guid.NewGuid();

            string extension = Path.GetExtension(Foto.FileName).ToLower();

            string nameOfFile = "" + g.ToString() + extension;
            fotografias.Foto = nameOfFile;
            string whereToStoreTheFile = _path.WebRootPath;
            nameOfFile = Path.Combine(whereToStoreTheFile, "fotos", nameOfFile);

            using var stream = new FileStream(nameOfFile, FileMode.Create);
            await Foto.CopyToAsync(stream);

            _context.Add(fotografias);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            _context.Fotografias.Add(fotografias);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFotografias", new { id = fotografias.ID }, fotografias);
        }

        // DELETE: api/FotografiasAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFotografias(int id)
        {
            var fotografias = await _context.Fotografias.FindAsync(id);
            if (fotografias == null)
            {
                return NotFound();
            }

            _context.Fotografias.Remove(fotografias);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FotografiasExists(int id)
        {
            return _context.Fotografias.Any(e => e.ID == id);
        }
    }
}
