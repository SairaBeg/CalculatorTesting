using Domain;
using FluentAssertions;

namespace CalculatorTest
{
    public class CalculatorTests
    {
        //Sum function
        [Fact]
        public void Sumof2Plus2()=>new Calculator().Sum(2,2).Should().Be(4);

    }
}