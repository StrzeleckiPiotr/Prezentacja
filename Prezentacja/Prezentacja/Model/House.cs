
namespace prezentacja.Model
{
  public class House : Home
  {
    public House(bool isGarden = false)
    {
      IsGarden = isGarden;
    }

    bool IsGarden { get; set; }
  }
}
