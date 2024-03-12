using AutoMapper;
using System.Net.Sockets;
using WebApplication1.Interface;
using WebApplication1.Models;
using WebApplication1.Requests.Maja;
using WebApplication1.Responses;

namespace WebApplication1.Repositories
{
    public class MajaDbRepository : IMajaRepository
    {

        private ApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public MajaDbRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        public IQueryable<Maja> GetMajas()
        {
            return _applicationDbContext.Majas;
        }

        public Maja GetMaja(Guid Id)
        {
            return _applicationDbContext.Majas.Where(maja => maja.Id == Id).SingleOrDefault();
        }

        public void PostMaja(Maja maja)
        {
            _applicationDbContext.Majas.Add(maja);
            _applicationDbContext.SaveChanges();
        }

        public void PutMaja(PutMajaRequest request)
        {
            var maja = GetMaja(request.Id);
            if (maja != null)
            {
                _mapper.Map(request, maja);
                _applicationDbContext.SaveChanges();
            };
        }

        public void Delete(DeleteMajaRequest request)
        {
            var index = GetMaja(request.Id);
            if (index != null)
            {
                _applicationDbContext.Remove(index);
                _applicationDbContext.SaveChanges();
            }
        }
    }
}
