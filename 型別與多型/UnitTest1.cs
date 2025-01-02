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
        dog.Sound().Should().Be("@#$%^&*(O");
    }

    [Fact]
    public void Test3()
    {
        Animal dog = new Dog();

        dog.Sound().Should().Be("@#$%^&*(O");
    }

    [Fact]
    public void Test4_override()
    {
        Animal dog = new Dog();

        dog.Sound2().Should().Be("Unknown bark");
    }

    [Fact]
    public void Test5()
    {
        var dog = new Dog();
        dog.Play().Should().Be("Playing");
        dog.Eat2().Should().Be("Dog is eating");
    }

    [Fact]
    public void Test6_overloading()
    {
        var dog = new Dog();
        dog.Play().Should().Be("Playing");
        dog.Play("AAA").Should().Be("Playing AAA");
    }
}
