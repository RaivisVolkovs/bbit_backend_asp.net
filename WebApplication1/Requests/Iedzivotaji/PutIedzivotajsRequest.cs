using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Requests.Iedzivotaji
{
    public class PutIedzivotajsRequest
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Vards { get; set; }
        [Required]
        public string Uzvards { get; set; }
        [Required]
        public string PersonasKods { get; set; }
        [Required]
        public DateTime DzimsanasDatums { get; set; }
        [Required]
        public string Telefons { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
