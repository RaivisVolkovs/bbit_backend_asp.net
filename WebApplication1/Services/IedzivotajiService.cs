using AutoMapper;
using WebApplication1.Interface;
using WebApplication1.Models;
using WebApplication1.Requests.Dzivokli;
using WebApplication1.Requests.Iedzivotaji;
using WebApplication1.Responses;

namespace WebApplication1.Services
{
    public class IedzivotajiService : IIedzivotajsService
    {
        private IIedzivotajsRepository _iedzivotajsRepository;
        private readonly IMapper _mapper;
        public IedzivotajiService(IIedzivotajsRepository iedzivotajsRepository, IMapper mapper)
        {
            _iedzivotajsRepository = iedzivotajsRepository;
            _mapper = mapper;
        }

        public IEnumerable<IedzivotajsViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<IedzivotajsViewModel>>(_iedzivotajsRepository.GetIedzivotaji());
        }

        public IedzivotajsViewModel GetById(Guid id)
        {
            return _mapper.Map<IedzivotajsViewModel>(_iedzivotajsRepository.GetIedzivotajs(id));
        }

        public void PostIedzivotajs(PostIedzivotajsRequest request)
        {
            _iedzivotajsRepository.PostIedzivotajs(_mapper.Map<Iedzivotajs>(request));
        }

        public void PutIedzivotajs(PutIedzivotajsRequest request)
        {
            _iedzivotajsRepository.PutIedzivotajs(request);
        }

        public void DeleteIedzivotajs(DeleteIedzivotajsRequest request)
        {
            _iedzivotajsRepository.Delete(request);
        }
    }
}
