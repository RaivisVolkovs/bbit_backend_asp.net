namespace WebApplication1.Responses
{
    public class PostDzivoklisResponse
    {
        public Guid Id { get; set; }

        public string Numurs { get; set; }
        public int Stavs { get; set; }
        public int IstabuSkaits { get; set; }
        public int IedzivotajuSkaits { get; set; }
        public double PilnaPlatiba { get; set; }
        public double DzivojamaPlatiba { get; set; }
    }
}
