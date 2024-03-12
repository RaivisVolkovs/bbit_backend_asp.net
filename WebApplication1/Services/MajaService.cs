using AutoMapper;
using WebApplication1.Interface;
using WebApplication1.Models;
using WebApplication1.Requests.Maja;
using WebApplication1.Responses;

namespace WebApplication1.Services
{
    public class MajaService : IMajaService
    {
        private IMajaRepository _majaRepository;
        private readonly IMapper _mapper;
        public MajaService(IMajaRepository majaRepository, IMapper mapper)
        {
            _majaRepository = majaRepository;
            _mapper = mapper;
        }

        public IEnumerable<MajaViewModel> GetAll()
        {

            return _mapper.Map<IEnumerable<MajaViewModel>>(_majaRepository.GetMajas());
        }

        public MajaViewModel GetById(Guid Id)
        {

            return _mapper.Map<MajaViewModel>(_majaRepository.GetMaja(Id));
        }

        public void PostMaja(PostMajaRequest request)
        {
            _majaRepository.PostMaja(_mapper.Map<Maja>(request));
        }

        public void PutMaja(PutMajaRequest request)
        {

            _majaRepository.PutMaja(request);

        }

        public void DeleteMaja(DeleteMajaRequest request)
        {
            _majaRepository.Delete(request);

        }
    }
}
