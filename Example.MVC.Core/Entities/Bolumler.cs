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
    public class Bolumler: BaseEntity
    {
       
        [Required]

        public string BolumAdi { get; set; }
        public ICollection<Ogrenciler> Ogrencilers { get; set; }

    }
}
