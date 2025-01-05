namespace 抽象類別與方法;

public abstract class AbstractPrinter
{
    public string PrinterType { get; set; } = "Abstract Print";

    public abstract string Print(string message);
}
