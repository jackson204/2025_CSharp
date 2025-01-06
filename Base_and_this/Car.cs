namespace Base_and_this;

public class Car : Vehicle
{
    private readonly string _model;

    public Car(int speed, string model)
        : base(speed)
    {
        _model = model;
    }

    public override string DisplaySpeed()
    {
        return $"{base.DisplaySpeed()} , Model : {_model}";
    }
}
