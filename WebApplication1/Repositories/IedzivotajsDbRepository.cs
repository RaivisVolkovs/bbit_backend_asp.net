using AutoMapper;
using WebApplication1.Interface;
using WebApplication1.Models;
using WebApplication1.Requests.Iedzivotaji;
using WebApplication1.Responses;

namespace WebApplication1.Repositories
{
    public class IedzivotajsDbRepository : IIedzivotajsRepository
    {
        private ApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;


        public IedzivotajsDbRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;

        }

        public IQueryable<Iedzivotajs> GetIedzivotaji()
        {
            return _applicationDbContext.Iedzivotajs;
        }

        public Iedzivotajs GetIedzivotajs(Guid Id)
        {
            return _applicationDbContext.Iedzivotajs.Where(iedzivotajs => iedzivotajs.Id == Id).SingleOrDefault();

        }

        public void PostIedzivotajs(Iedzivotajs iedzivotajs)
        {
            _applicationDbContext.Iedzivotajs.Add(iedzivotajs);
            _applicationDbContext.SaveChanges();
        }

        public void PutIedzivotajs(PutIedzivotajsRequest request)
        {
            var iedzivotajs = GetIedzivotajs(request.Id);
            if (iedzivotajs != null)
            {
               _mapper.Map(request, iedzivotajs);
                _applicationDbContext.SaveChanges();
            };
        }

        public void Delete(DeleteIedzivotajsRequest request)
        {
            var index = GetIedzivotajs(request.Id);
            if (index != null)
            {
                _applicationDbContext.Remove(index);
                _applicationDbContext.SaveChanges();
            }
        }
    }
}
