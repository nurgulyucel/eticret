using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Kullanicis : IEntity
    {
      
        public int Id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string kullaniciAdi { get; set; }
        public string mail { get; set; }
        public string telefon { get; set; }

    }
}
