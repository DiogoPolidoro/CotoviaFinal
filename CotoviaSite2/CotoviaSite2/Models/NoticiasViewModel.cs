using System;

namespace CotoviaSite2.Models
{
    public class NoticiasViewModel
    {
        public int ID { set; get; }
        public DateTime Data { get; set; }
        public string Titulo { get; set; }
        public string Resumo { get; set; }
        public string Foto { get; set; }
    }
}
