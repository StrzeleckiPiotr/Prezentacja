using FluentAssertions;
using NUnit.Framework;
using prezentacja.Converter;
using prezentacja.DtoModel;
using prezentacja.Model;
using prezentacja.Personalization.Model;

namespace testy
{
    [TestFixture]
    public class ConverterTest
    {
        [Test]
        public void Test1()
        {
            var expectedApartment = new Apartment();
            expectedApartment.Localization = new Location();
            expectedApartment.m2 = 50;
            expectedApartment.name = "ładna";
            expectedApartment.Typ = "nowe";


            Home home = new Home();
            home.Localization = new Location();
            home.m2 = 50;
            home.name = "ładna";
            home.Typ = "nowe";

            var result = HomeToApartment.ConverToApartment(home);

            result.Should().BeEquivalentTo(expectedApartment);
        }

        [Test]
        public void Test2()
        {
            var expectedDtoHome = new DtoHome();
            expectedDtoHome.Localization = new Location();
            expectedDtoHome.Meter = 50;
            expectedDtoHome.name = "ładna";
            expectedDtoHome.Typ = "nowe";

            Home home = new Home();
            home.Localization = new Location();
            home.m2 = 50;
            home.name = "ładna";
            home.Typ = "nowe";


            var result = HomeToDtoHome.ConvertToDtoHome(home);

            result.Should().BeEquivalentTo(expectedDtoHome);
            result.Should().NotBeNull();
        }

        [Test]
        public void TestHomeToHouse()
        {
            var expectedHouse = new House(true);
            expectedHouse.Localization = new Location();
            expectedHouse.m2 = 50;
            expectedHouse.name = "ładna";
            expectedHouse.Typ = "nowe";

            Home home = new Home();
            home.Localization = new Location();
            home.m2 = 50;
            home.name = "ładna";
            home.Typ = "nowe";


            var result = HomeToHouse.ConvertToHouse(home);

            result.Should().BeEquivalentTo(expectedHouse);
            result.Should().NotBeNull();
        }
    }
}
