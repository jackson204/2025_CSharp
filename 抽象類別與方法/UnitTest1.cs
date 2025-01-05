using FluentAssertions;

namespace 抽象類別與方法;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var dotPrint = new DotPrint();
        var laserPrinter = new LaserPrinter();
        dotPrint.Print("Hello").Should().Be("Dot Printer, Hello");
        laserPrinter.Print("Hello").Should().Be("Laser print, Hello");
    }
}
