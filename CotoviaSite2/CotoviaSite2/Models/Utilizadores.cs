using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CotoviaSite2.Models
{
    public class Utilizadores
    {
        public Utilizadores()
        {
            ListaNoticiasEscritas = new HashSet<Noticias>();
            ListaNoticiasRevistas = new HashSet<Noticias>();
        }

        [Key]
        public int ID { set; get; }

        [Required(ErrorMessage = "O Nome é de preenchimento obrigatório")]
        [RegularExpression("[A-ZÁÍÓÚÉÂ][a-zãõáéíóúàèìòùäëïöüçâêîôû]+" +
           "(( | e |-|'| d'| de | d[ao](s)? )[A-ZÁÍÓÚÉÂ][a-zãõáéíóúàèìòùäëïöüçâêîôû]+)",
           ErrorMessage = "Só são aceites letras. Cada palavra deve começar por uma maiúscula, separadas por um espaço em branco.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O E-mail é de preenchimento obrigatório")]
        //[RegularExpression("[a-z0-9_.+-]@[a-z]([.][a-z])+", ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

        //[Required]
        public string Foto { get; set; }

        [Required]
        public Cargo Cargo { get; set; }

        public virtual ICollection<Noticias> ListaNoticiasEscritas { get; set; }
        public virtual ICollection<Noticias> ListaNoticiasRevistas { get; set; }
    }

    public enum Cargo
    {
        Autor,
        Revisor
    }
}
