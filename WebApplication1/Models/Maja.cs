using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Maja
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public int? Numurs { get; set; }
        public string Iela { get; set; }
        public string Pilseta { get; set; }
        public string Valsts { get; set; }
        public string PastaIndekss { get; set; }
    }
}