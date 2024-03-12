using AutoMapper;
using WebApplication1.Models;
using WebApplication1.Requests.Dzivokli;
using WebApplication1.Requests.Iedzivotaji;
using WebApplication1.Requests.Maja;
using WebApplication1.Responses;

namespace WebApplication1.Config
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PostMajaRequest, Maja>();
            CreateMap<Maja, PostMajaRequest>();

            CreateMap<PutMajaRequest, Maja>();
            CreateMap<Maja, PutMajaRequest>();

            CreateMap<PostDzivoklisRequest, Dzivoklis>();
            CreateMap<Dzivoklis, PostDzivoklisRequest>();

            CreateMap<PutDzivoklisRequest, Dzivoklis>();
            CreateMap<Dzivoklis, PutDzivoklisRequest>();

            CreateMap<PutIedzivotajsRequest, Iedzivotajs>();
            CreateMap<Iedzivotajs, PutIedzivotajsRequest>();

            CreateMap<PostIedzivotajsRequest, Iedzivotajs>();
            CreateMap<Iedzivotajs, PostIedzivotajsRequest>();

            CreateMap<MajaViewModel, Maja>();
            CreateMap<Maja, MajaViewModel>();

            CreateMap<DzivoklisViewModel, Dzivoklis>();
            CreateMap<Dzivoklis, DzivoklisViewModel>();

            CreateMap<IedzivotajsViewModel, Iedzivotajs>();
            CreateMap<Iedzivotajs, IedzivotajsViewModel>();

            CreateMap<DzivoklisIedzivotajsViewModel, DzivoklisIedzivotajs>();
            CreateMap<DzivoklisIedzivotajs, DzivoklisIedzivotajsViewModel>();
        }
    }
}
