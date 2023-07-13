using Example.MVC.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MVC.Core.Entities
{
    public class Dersler : BaseEntity
    {
        [Column(TypeName ="varchar(256)")]

        public string DersAdi { get; set; }
        public ICollection<Notlar> Notlars { get; set; }

    }
}
