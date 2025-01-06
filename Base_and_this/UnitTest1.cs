using FluentAssertions;

namespace Base_and_this;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var car = new Car(12, "Toyota");
        car.DisplaySpeed().Should().Be("Speed: 12 , Model : Toyota");
    }
}