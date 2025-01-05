namespace 抽象類別與方法;

public class DotPrint : AbstractPrinter
{
    public DotPrint()
    {
        PrinterType = "Dot Printer";
    }

    public override string Print(string message)
    {
        return $"{PrinterType}, {message}";
    }
}
