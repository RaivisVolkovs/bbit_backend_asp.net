using WebApplication1.Models;
using WebApplication1.Requests.Iedzivotaji;
using WebApplication1.Responses;

namespace WebApplication1.Interface
{
    public interface IIedzivotajsRepository
    {

        public IQueryable<Iedzivotajs> GetIedzivotaji();

        public Iedzivotajs GetIedzivotajs(Guid Id);

        public void PostIedzivotajs(Iedzivotajs iedzivotajs);

        public void PutIedzivotajs(PutIedzivotajsRequest request);

        public void Delete(DeleteIedzivotajsRequest request);
    }
}
