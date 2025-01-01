using FluentAssertions;

namespace 型別與多型;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var dog = new Dog();
        dog.Sound().Should().Be("Unknown bark");
    }
}