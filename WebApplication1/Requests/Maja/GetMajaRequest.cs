using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Requests.Maja
{
    public class GetMajaRequest
    {
        [Required]
        public Guid Id { get; set; }
    }
}
