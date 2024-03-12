using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Models;

namespace WebApplication1.Responses
{
    public class DzivoklisIedzivotajsViewModel
    {
        public Guid Id { get; set; }

        public Guid DzivoklisId { get; set; }

        public Guid IedzivotajsId { get; set; }

        public bool IsOwner { get; set; }
    }
}
