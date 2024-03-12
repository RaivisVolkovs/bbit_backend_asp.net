using WebApplication1.Models;
using WebApplication1.Requests.Dzivokli;
using WebApplication1.Responses;

namespace WebApplication1.Interface
{
    public interface IDzivoklisService
    {
        public IEnumerable<DzivoklisViewModel> GetAll();
        public DzivoklisViewModel GetById(Guid id);
        public IEnumerable<DzivoklisIedzivotajsViewModel> GetDzivoklisIedzivotajiByDzivoklisId(Guid dzivoklisId);
        public void PostDzivoklis(PostDzivoklisRequest request);
        public void PutDzivoklis(PutDzivoklisRequest request);
        public void DeleteDzivoklis(DeleteDzivoklisRequest request);
    }
}
