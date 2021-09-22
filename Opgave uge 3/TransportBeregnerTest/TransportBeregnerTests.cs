using System;
using Xunit;
using Opgave_uge_3;

namespace TransportBeregnerTest
{
    public class TransportBeregnerTests
    {
        [Fact]
        //Hvis afstanden er under 5 km og vægten er under 10 kg, så er transporten gratis.
        public void Distance_Under_5_Weight_Under_10()
        {
            Transportberegner sut = new Transportberegner();

            double pris = sut.GetPrice(4500, 9.8);

            Assert.Equal(0, pris);
        }

        [Fact]
        //Er afstanden under 5 km, men vægten er 10 kg eller mere, så koster transporten 50 kr.
        public void Distance_Under_5_Weight_10_or_more()
        {
            Transportberegner sut = new Transportberegner();

            double pris = sut.GetPrice(4500, 10);

            Assert.Equal(50, pris);
        }

        [Fact]
        //Hvis afstanden er 5 km eller mere, koster transporten 75 kroner, hvis vægten er under 10 kg
        public void Distance_5_or_more_Weight_Less_Than_10()
        {
            Transportberegner sut = new Transportberegner();

            double pris = sut.GetPrice(5000, 9.8);

            Assert.Equal(75, pris);
        }

        [Fact]
        //Hvis afstanden er 5 km eller mere, og vægten over 10 koster transporten 100kr.
        public void Distance_5_or_more_Weight_10_or_more()
        {
            Transportberegner sut = new Transportberegner();

            double pris = sut.GetPrice(5000, 10);

            Assert.Equal(100, pris);
        }
    }
}
