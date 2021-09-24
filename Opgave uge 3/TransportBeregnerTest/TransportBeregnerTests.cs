using System;
using Xunit;
using Opgave_uge_3;

namespace TransportBeregnerTest
{

    public class TransportBeregnerTests
    {

        [InlineData(4500, 9.8, 0)]
        [InlineData(4500, 10, 50)]
        [InlineData(5000, 9.8, 75)]
        [InlineData(5000, 10, 100)]
        [Theory]

        public void find_transport_pris(int afstand, double vaegt, int pris)
        {
            // Arrange
            Transportberegner beregner = new Transportberegner();

            // Act
            double beregnetPris = beregner.GetPrice(afstand, vaegt);

            // Assert
            Assert.Equal(pris, beregnetPris);
        }
    }
}
