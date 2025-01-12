namespace TryCatch;

public class CustomDivideByZeroException: Exception
{
    public CustomDivideByZeroException(int number)
        : base($"Divide by zero, b: {number}")
    {
        Number = number;
    }

    public int Number { get; }
}

