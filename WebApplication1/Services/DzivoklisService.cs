using AutoMapper;
using WebApplication1.Interface;
using WebApplication1.Models;
using WebApplication1.Requests.Dzivokli;
using WebApplication1.Responses;

namespace WebApplication1.Services
{
    public class DzivoklisService : IDzivoklisService
    {
        private IDzivoklisRepository _dzivoklisRepository;
        private readonly IMapper _mapper;

        public DzivoklisService(IDzivoklisRepository dzivoklisRepository, IMapper mapper)
        {
            _dzivoklisRepository = dzivoklisRepository;
            _mapper = mapper;
        }

        public IEnumerable<DzivoklisViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<DzivoklisViewModel>>(_dzivoklisRepository.GetDzivokli());
        }

        public DzivoklisViewModel GetById(Guid Id)
        {
            return _mapper.Map<DzivoklisViewModel>(_dzivoklisRepository.GetDzivoklis(Id));
        }

        public IEnumerable<DzivoklisIedzivotajsViewModel> GetDzivoklisIedzivotajiByDzivoklisId(Guid dzivoklisId)
        {
            return _mapper.Map<IEnumerable<DzivoklisIedzivotajsViewModel>>(_dzivoklisRepository.GetDzivoklisIedzivotajiByDzivoklisId(dzivoklisId));
        }

        public void PostDzivoklis(PostDzivoklisRequest request)
        {
            _dzivoklisRepository.PostDzivoklis(_mapper.Map<Dzivoklis>(request));
        }

        public void PutDzivoklis(PutDzivoklisRequest request)
        {
            _dzivoklisRepository.PutDzivoklis(request);
        }

        public void DeleteDzivoklis(DeleteDzivoklisRequest request)
        {
            _dzivoklisRepository.Delete(request);
        }
    }
}
