class Engine
{
    public string Model { get; }
    public int Power { get; }
    public int? Displacement { get; }
    public string? Efficiency { get; }

    public Engine(string Model, int Power, int? Displacement, string? Efficiency)
    {
        this.Model = Model;
        this.Power = Power;
        this.Displacement = Displacement;
        this.Efficiency = Efficiency;
    }

    public override string ToString()
    {
        return 
            $"{Model}: " +
            $"\n    Power: {Power} " +
            $"\n    Displacement: {(Displacement == null || Displacement == -1 ? "n/a" : Displacement)} " +
            $"\n    Efficiency: {(Efficiency == null ? "n/a" : Efficiency)}";
    }
}