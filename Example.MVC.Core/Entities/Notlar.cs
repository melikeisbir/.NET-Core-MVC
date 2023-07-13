using Example.MVC.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MVC.Core.Entities
{
    public class Notlar : BaseEntity
    {
        public int VizeNotu { get; set; }
        public int FinalNotu { get; set; }
        public double Ortalama { get; set; }
        [Required]
        public int DersId { get; set; }
        [Required]
        public int OgrenciId { get; set; }
        public Ogrenciler Ogrenci { get; set; }
        public Dersler Ders { get; set; }
        
    }
}
