using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class DzivoklisIedzivotajs
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [ForeignKey("Dzivoklis")]
        public Guid DzivoklisId { get; set; }
        public virtual Dzivoklis Dzivoklis { get; set; }

        [ForeignKey("Iedzivotajs")]
        public Guid IedzivotajsId { get; set; }
        public virtual Iedzivotajs Iedzivotajs { get; set; }

        public bool IsOwner { get; set; }
    }
}
