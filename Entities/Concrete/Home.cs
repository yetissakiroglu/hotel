using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    [Table("Home")]
    public class Home
    {
        [Key]
        public int homeId { get; set; }
        public string favicon { get; set; }
        public string logoUrl { get; set; }
        public string logofooterUrl { get; set; }
        public string logomobilUrl { get; set; }
        public string logomobilfooterUrl { get; set; }
        public ICollection<HomeLang> HomeLangs { get; set; }

    }
}
