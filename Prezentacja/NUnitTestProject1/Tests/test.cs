using NUnit.Framework;
using FluentAssertions;
using prezentacja.model;
using prezentacja.konwetery;

namespace prezentacja.Tests
{
  [TestFixture]
   public class Test
  {
    [Test]
    public void KonwenterLokumDoDomWithShould()
    {
      var expectedApartment = new Mieszkanie();
      expectedApartment.inwestycja = "pewna";
      expectedApartment.metraż = 50;
      expectedApartment.nazwa = "ładna";
      expectedApartment.Typ = "nowe";

      Lokum lokum = new Lokum();
      lokum.inwestycja = "pewna";
      lokum.metraż = 50;
      lokum.nazwa = "ładna";
      lokum.Typ = "nowe";

      Mieszkanie result = KonwenterLokumDoDom.Konwert(lokum);

      result.Should().Be(expectedApartment,"The Same");
    }
  }
}
