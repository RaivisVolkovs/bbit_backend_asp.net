using WebApplication1.Models;

namespace WebApplication1.Responses
{
    public class DzivoklisViewModel
    {
        public Guid Id { get; set; }
        public string Numurs { get; set; }
        public int Stavs { get; set; }
        public int IstabuSkaits { get; set; }
        public int IedzivotajuSkaits { get; set; }
        public double PilnaPlatiba { get; set; }
        public double DzivojamaPlatiba { get; set; }
        public Guid MajaId { get; set; }
    }
}
