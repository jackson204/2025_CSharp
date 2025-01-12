using System.Runtime.InteropServices;
using FluentAssertions;
using Xunit.Abstractions;

namespace TryCatch;

public class UnitTest1
{
    private readonly ITestOutputHelper _testOutputHelper;

    public UnitTest1(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Test1()
    {
        try
        {
          FuncA();
        }
        catch (Exception e)
        {
            _testOutputHelper.WriteLine(e.Message);
            e.Message.Should().BeEquivalentTo("Divide by zero, b: 0");
        }
    }

    private void FuncA()
    {
        FuncB();
    }

    private void FuncB()
    {
        int b = 0;

        try
        {
            var rest = 10 / b;
        }
        catch (DivideByZeroException e)
        {
            throw new CustomDivideByZeroException(b);
        }
    }
}