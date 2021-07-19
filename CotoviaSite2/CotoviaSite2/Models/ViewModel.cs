using System;

namespace CotoviaSite2.Models
{
    public class FotografiasApiViewModel
    {
        public int IdFoto { get; set; }
        public string Foto { get; set; }
        public string LocalFoto { get; set; }
        public string DataFoto { get; set; }
        public string NomeFotografo { get; set; }
    }



    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
