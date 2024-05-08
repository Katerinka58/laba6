public abstract class Transport
{
    public abstract double Speed { get; }
    public abstract double Capacity { get; }
    public abstract double Range { get; }

    public abstract double GetSpeed();
    public abstract double GetCapacity();
    public abstract double GetRange();
}

public abstract class Car : Transport
{
    public override double Speed { get; }
    public override double Capacity { get; }
    public override double Range { get; }

    public override double GetSpeed() => Speed;
    public override double GetCapacity() => Capacity;
    public override double GetRange() => Range;
}

public abstract class Airplane : Transport
{
    public override double Speed { get; }
    public override double Capacity { get; }
    public override double Range { get; }

    public override double GetSpeed() => Speed;
    public override double GetCapacity() => Capacity;
    public override double GetRange() => Range;
}

public abstract class Ship : Transport
{
    public override double Speed { get; }
    public override double Capacity { get; }
    public override double Range { get; }

    public override double GetSpeed() => Speed;
    public override double GetCapacity() => Capacity;
    public override double GetRange() => Range;
}

public class PassengerCar : Car
{
    public override double Speed { get; } = 120.0;
    public override double Capacity { get; } = 500.0;
    public override double Range { get; } = 500.0;

    public override string ToString()
    {
        return $"Легковой автомобиль грузоподъемностью {GetCapacity()} может проехать {GetRange()}";
    }
}

public class Airplane1 : Airplane
{
    public override double Speed { get; } = 800.0;
    public override double Capacity { get; } = 10000.0;
    public override double Range { get; } = 5000.0;

    public override string ToString()
    {
        return $"Самолет грузоподcъемностью {GetCapacity()} может пролететь {GetRange()}";
    }
}

public class Ship1 : Ship
{
    public override double Speed { get; } = 20.0;
    public override double Capacity { get; } = 10000.0;
    public override double Range { get; } = 10000.0;

    public override string ToString()
    {
        return $"Корабль грузоподъемностью {GetCapacity()} может проплыть {GetRange()}";
    }
}
            
