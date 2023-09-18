class Car
{
    public string Model { get; }
    public Engine CarEngine { get; }
    public int? Weight { get; }
    public string? Color { get;  }

    public Car(string Model, Engine CarEngine, int? Weight, string? Color)
    {
        this.Model = Model;
        this.CarEngine = CarEngine;
        this.Weight = Weight;
        this.Color = Color;
    }

    public override string ToString()
    {
        return 
            $"\n{Model}: " +
            $"\n  {CarEngine.ToString()} " +
            $"\n  Weigth: {(Weight == null || Weight == -1 ? "n/a" : Weight)} " +
            $"\n  Color: {(Color == null ? "n/a" : Color)}";
    }
}