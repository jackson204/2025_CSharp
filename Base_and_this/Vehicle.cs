namespace Base_and_this;

public class Vehicle
{
    private readonly int _speed;

    public Vehicle(int speed) => _speed = speed;

    public virtual string DisplaySpeed() => $"Speed: {_speed}";
}
