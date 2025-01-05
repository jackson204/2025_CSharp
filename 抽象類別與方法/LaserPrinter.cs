namespace 抽象類別與方法;

public class LaserPrinter : AbstractPrinter
{
    public LaserPrinter()
    {
        PrinterType = "Laser print";
    }

    public override string Print(string message)
    {
        return $"{PrinterType}, {message}";
    }
}
