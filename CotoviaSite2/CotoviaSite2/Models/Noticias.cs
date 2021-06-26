using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CotoviaSite2.Models
{
    public class Noticias
    {
        /// <summary>
        /// Informações sobre as noticias
        /// </summary>

        public Noticias()
        {
            //inicializar a lista de fotografias
            ListaFotografias = new HashSet<FotosNoticias>();
        }

        [Key]
        public int ID { set; get; }

        [Required]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "É necessário um título para a notícia")]
        public string Titulo { get; set; }

        [Required]
        public string Resumo { get; set; }

        [Required]
        public string Conteudo { get; set; }

        [Required]
        public Estado Estado { get; set; }

        [Required]
        public Tema Tema { get; set; }

        public virtual ICollection<FotosNoticias> ListaFotografias { get; set; }

        
        [ForeignKey(nameof(Autor))]
        public int AutorFK { get; set; }
        [NotMapped]
        public virtual Utilizadores Autor { get; set; }

        
        [ForeignKey(nameof(Revisor))]
        public int RevisorFK { get; set; }
        [NotMapped]
        public virtual Utilizadores Revisor { get; set; }
    }

    public enum Estado
    {
        Pendente,
        Publicada
    }
    public enum Tema
    {
        Ambiente,
        Ciencia,
        Cultura,
        Desporto,
        Economia,
        Opiniao,
        Politica,
        Saude,
        Tecnologia
    }

}
