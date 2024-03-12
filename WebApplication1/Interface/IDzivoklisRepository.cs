using WebApplication1.Models;
using WebApplication1.Requests.Dzivokli;

namespace WebApplication1.Interface
{
    public interface IDzivoklisRepository
    {

        public IQueryable<Dzivoklis> GetDzivokli();

        public Dzivoklis GetDzivoklis(Guid Id);

        public void PostDzivoklis(Dzivoklis dzivoklis);

        public void PutDzivoklis(PutDzivoklisRequest request);

        public void Delete(DeleteDzivoklisRequest request);

        public List<DzivoklisIedzivotajs> GetDzivoklisIedzivotajiByDzivoklisId(Guid Id);
    }
}
