using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Requests.Iedzivotaji
{
    public class DeleteIedzivotajsRequest
    {
        [Required]
        public Guid Id { get; set; }
    }
}
