using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CotoviaSite2.Models
{
    public class Fotografias
    {
        public Fotografias()
        {
            //inicializar a lista de noticias
            ListaNoticias = new HashSet<FotosNoticias>();
        }

        [Key]
        public int ID { set; get; }
        public string Foto { get; set; }
        [Display(Name ="Data")]
        public DateTime DataFoto { get; set; }
        [Display(Name = "Local")]
        public string LocalFoto { get; set; }
        [Display(Name = "Fotógrafo")]
        public string Fotografo { get; set; }

        public virtual ICollection<FotosNoticias> ListaNoticias { get; set; }
    }
}
