using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Requests.Maja
{
    public class PostMajaRequest
    {
        [Required]
        public int? Numurs { get; set; }
        [Required]
        public string Iela { get; set; }
        [Required]
        public string Pilseta { get; set; }
        [Required]
        public string Valsts { get; set; }
        [Required]
        public string PastaIndekss { get; set; }
    }
}
