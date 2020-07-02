
using AutoMapper;
using prezentacja.Model;

namespace prezentacja.Converter
{
  public static class HomeToApartment
  {
    public static Apartment ConverToApartment(Home lokum)
    {
      MapperConfiguration config = new MapperConfiguration(cfg => cfg.CreateMap<Home, Apartment>());
      IMapper mapper = config.CreateMapper();

      return mapper.Map<Home, Apartment>(lokum);
    }

  }
}
