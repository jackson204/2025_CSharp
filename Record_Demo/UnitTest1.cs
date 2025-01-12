using FluentAssertions;

namespace Record_Demo;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var position = new Position(12, 4);
        var position2 = new Position(12, 4);
        (position == position2).Should().BeTrue();
    }

    [Fact]
    public void class_record()
    {
        var position = new Position(12, 4);
        position.ToString().Should().BeEquivalentTo("Position { Row = 12, Col = 4 }");

        var myClass = new MyClass(12,4);
        myClass.ToString().Should().BeEquivalentTo("Record_Demo.MyClass");
    }

  
}
public record Position(int Row, int Col);
public class MyClass(int i, int i1);
