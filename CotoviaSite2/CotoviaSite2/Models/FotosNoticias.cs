using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CotoviaSite2.Models
{
    public class FotosNoticias
    {
        //[Key, Column(Order =0)]
        [ForeignKey(nameof(Fotografias))]
        public int FotoFK { get; set; }
        public Fotografias Fotografias { get; set; }

        //[Key, Column(Order = 1)]
        [ForeignKey(nameof(Noticia))]
        public int NoticiaFK { get; set; }
        public Noticias Noticia { get; set; }
    }
}
