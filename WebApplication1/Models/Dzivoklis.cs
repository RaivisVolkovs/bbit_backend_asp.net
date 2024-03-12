using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Dzivoklis
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Numurs { get; set; }
        public int Stavs { get; set; }
        public int IstabuSkaits { get; set; }
        public int IedzivotajuSkaits { get; set; }
        public double PilnaPlatiba { get; set; }
        public double DzivojamaPlatiba { get; set; }

        [ForeignKey("Maja")]
        public Guid MajaId { get; set; }
        public virtual Maja Maja { get; set; }

        public List<Iedzivotajs> Iedzivotaji { get; } = [];
    }
}