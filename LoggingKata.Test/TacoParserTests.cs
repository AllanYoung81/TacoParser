using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.035985, -84.683302, Taco Bell Acworth...",-84.683302)]
        [InlineData("34.087508,-84.575512,Taco Bell Acworth...", -84.575512)]
        [InlineData("34.376395,-84.913185,Taco Bell Adairsvill...", -84.913185)]
        [InlineData("33.22997,-86.805275,Taco Bell Alabaste...", -86.805275)]
        [InlineData("31.570771,-84.10353,Taco Bell Albany...", -84.10353)]
        
        //Add additional inline data. Refer to your CSV file.
        
           
            
            
            //31.570771,-84.10353,Taco Bell Albany...


        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange

                var tacoParser = new TacoParser();

            //Act
           // double actual = 0;
            double actual = (tacoParser.Parse(line)).Location.Longitude;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("33.724109,-84.937891,Taco Bell Villa Ric..", 33.724109)]
        [InlineData("33.810924,-86.820487, Taco Bell Warrio...", 33.810924)]
        [InlineData("32.524115,-86.20775, Taco Bell Wetumpk...", 32.524115)]
        [InlineData("33.926654,-87.757477, Taco Bell Winfiel...", 33.926654)]
        [InlineData("34.113051,-84.56005, Taco Bell Woodstoc...", 34.113051)]


        public void ShouldParseLatitude(string line, double expected)
        {
            

            //Arrange

            var tacoParser = new TacoParser();

            //Act
            // double actual = 0;
            double actual = (tacoParser.Parse(line)).Location.Latitude;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
