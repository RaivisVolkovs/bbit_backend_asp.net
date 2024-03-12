using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Requests.Dzivokli
{
    public class DeleteDzivoklisRequest
    {
        [Required]
        public Guid Id { get; set; }
    }
}
