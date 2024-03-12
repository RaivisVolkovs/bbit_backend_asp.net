using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Requests.Dzivokli
{
    public class GetDzivoklisRequest
    {
        [Required]
        public Guid Id { get; set; }
    }
}
