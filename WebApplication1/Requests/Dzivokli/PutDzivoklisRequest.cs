using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Requests.Dzivokli
{
    public class PutDzivoklisRequest
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Numurs { get; set; }
        [Required]
        public int Stavs { get; set; }
        [Required]
        public int IstabuSkaits { get; set; }
        [Required]
        public int IedzivotajuSkaits { get; set; }
        [Required]
        public double PilnaPlatiba { get; set; }
        [Required]
        public double DzivojamaPlatiba { get; set; }
    }
}
