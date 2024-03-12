using WebApplication1.Models;
using WebApplication1.Requests.Maja;

namespace WebApplication1.Interface
{
    public interface IMajaRepository
    {

        public IQueryable<Maja> GetMajas();

        public Maja GetMaja(Guid Id);

        public void PostMaja(Maja maja);

        public void PutMaja(PutMajaRequest request);

        public void Delete(DeleteMajaRequest request);
    }
}
