using AutoMapper;
using prezentacja.DtoModel;
using prezentacja.Model;

namespace prezentacja.Converter
{
  public static class HomeToDtoHome
  {
    public static DtoHome ConvertToDtoHome(Home home)
    {
      MapperConfiguration config = new MapperConfiguration(cfg => cfg.CreateMap<Home, DtoHome>()
      .ForMember(x => x.Meter, y => y.MapFrom(x => x.m2)));
      IMapper mapper = config.CreateMapper();
      
      return mapper.Map<Home, DtoHome>(home);
    }
  }
}
