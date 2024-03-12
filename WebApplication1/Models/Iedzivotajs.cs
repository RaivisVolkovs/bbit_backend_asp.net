using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Iedzivotajs
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Vards { get; set; }
        public string Uzvards { get; set; }
        public string PersonasKods { get; set; }
        public DateTime DzimsanasDatums { get; set; }
        public string Telefons { get; set; }
        public string Email { get; set; }
        public List<Dzivoklis> Dzivokli { get; } = [];
    }

}