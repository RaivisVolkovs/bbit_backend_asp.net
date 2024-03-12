using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Requests.Maja
{
    public class DeleteMajaRequest
    {
        [Required]
        public Guid Id { get; set; }
    }
}
