using AutoMapper;
using SuperHeroesAutomapper.Dto;
using SuperHeroesAutomapper.Model;

namespace SuperHeroesAutomapper.Helper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<SuperHero, SuperHeroDto>();
    }
}