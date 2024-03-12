using WebApplication1.Models;
using WebApplication1.Requests.Iedzivotaji;
using WebApplication1.Responses;

namespace WebApplication1.Interface
{
    public interface IIedzivotajsService
    {
        public IEnumerable<IedzivotajsViewModel> GetAll();

        public IedzivotajsViewModel GetById(Guid id);

        public void PostIedzivotajs(PostIedzivotajsRequest request);
        public void PutIedzivotajs(PutIedzivotajsRequest request);
        public void DeleteIedzivotajs(DeleteIedzivotajsRequest request);

    }
}
