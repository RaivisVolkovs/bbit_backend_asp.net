using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Requests.Iedzivotaji
{
    public class GetIedzivotajsRequest
    {
        [Required]
        public Guid Id { get; set; }
    }
}
