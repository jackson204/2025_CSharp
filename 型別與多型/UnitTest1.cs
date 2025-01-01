using FluentAssertions;

namespace 型別與多型;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var dog = new Dog();
        
        dog.Sound().Should().Be("Unknown bark");

        var dog1 = new Dog("PuPu");
        dog1.Sound().Should().Be("PuPu bark");
        dog1.Food.Should().Be("meat");
    }

    [Fact]
    public void Test2()
    {
        var dog = new Animal();
        dog.Sound().Should().Be("Unknown bark");
    }
}
