namespace 型別與多型;

public class Animal
{
    public Animal()
    {
        int i = 0;
    }

    public string Name { get; set; }

    public string Sound() => "@#$%^&*(O";

    public virtual string Sound2() => "@#$%^&*(O";

    protected virtual string Eat() => "Eating";
}
