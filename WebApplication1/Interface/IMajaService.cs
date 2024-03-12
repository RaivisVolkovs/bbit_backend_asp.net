using WebApplication1.Models;
using WebApplication1.Requests.Maja;
using WebApplication1.Responses;

namespace WebApplication1.Interface
{
    public interface IMajaService
    {
        IEnumerable<MajaViewModel> GetAll();
        MajaViewModel GetById(Guid id);
        public void PostMaja(PostMajaRequest request);
        public void PutMaja(PutMajaRequest request);
        public void DeleteMaja(DeleteMajaRequest request);
    }
}
