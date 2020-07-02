using AutoMapper;
using prezentacja.Model;

namespace prezentacja.Converter
{
  public class HomeToHouse
  {
    public static House ConvertToHouse(Home home)
    {
      MapperConfiguration mapperConfiguration = new MapperConfiguration(x => x.CreateMap<Home, House>());
      IMapper mapper = mapperConfiguration.CreateMapper();
      return mapper.Map<House>(home);
    }
  }
}