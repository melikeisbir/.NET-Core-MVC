using Example.MVC.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MVC.Core.Entities
{
    
    public class Ogrenciler: BaseEntity
    {
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [ForeignKey("Bolum")]
        public int BolumId { get; set; }
        
        public Bolumler Bolum { get; set; }
        public ICollection<Notlar> Notlars { get; set; }
    }
}
