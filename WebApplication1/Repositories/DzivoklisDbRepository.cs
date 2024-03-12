using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Interface;
using WebApplication1.Models;
using WebApplication1.Requests.Dzivokli;
using WebApplication1.Responses;

namespace WebApplication1.Repositories
{
    public class DzivoklisDbRepository : IDzivoklisRepository
    {

        private ApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public DzivoklisDbRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;

        }

        public IQueryable<Dzivoklis> GetDzivokli()
        {
            return _applicationDbContext.Dzivoklis;
        }

        public Dzivoklis GetDzivoklis(Guid Id)
        {
            return _applicationDbContext.Dzivoklis.Where(dzivoklis => dzivoklis.Id == Id).SingleOrDefault();

        }

        public void PostDzivoklis(Dzivoklis dzivoklis)
        {
            _applicationDbContext.Dzivoklis.Add(dzivoklis);
            _applicationDbContext.SaveChanges();
        }

        public void PutDzivoklis(PutDzivoklisRequest request)
        {
            var dzivoklis = GetDzivoklis(request.Id);
            if (dzivoklis != null)
            {
                _mapper.Map(request, dzivoklis);
                _applicationDbContext.SaveChanges();
            };
        }

        public void Delete(DeleteDzivoklisRequest request)
        {
            var index = GetDzivoklis(request.Id);
            if (index != null)
            {
                _applicationDbContext.Remove(index);
                _applicationDbContext.SaveChanges();
            }
        }

        public List<DzivoklisIedzivotajs> GetDzivoklisIedzivotajiByDzivoklisId(Guid dzivoklisId)
        {
            var dzivoklisIedzivotaji = _applicationDbContext.DzivoklisIedzivotaji
                .Include(di => di.Iedzivotajs)
                .Where(di => di.DzivoklisId == dzivoklisId)
                .ToList();

            return dzivoklisIedzivotaji;
        }
    }
}
