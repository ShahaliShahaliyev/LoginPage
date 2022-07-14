using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage
{
    public class User
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public DateTime DogumTarixi { get; set; }
        public string? Telefon { get; set; }
        public string? Cins { get; set; }
        public string? IstifadeciAdi { get; set; }
        public string? Sifre { get; set; }
    }
}
