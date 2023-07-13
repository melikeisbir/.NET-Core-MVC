using System.ComponentModel.DataAnnotations;

namespace Example.MVC.Core.Common
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
