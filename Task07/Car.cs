class Car
{
    public string Model { get; }
    public double FuelAmount { get; set; }
    public double FuelConsumption { get; }
    public int TravelledDistance { get; set; }

    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumption = fuelConsumption;
        this.TravelledDistance = 0;
    }

    public void Travel(int Distance)
    {
        TravelledDistance += Distance;
        FuelAmount -= Distance * FuelConsumption;
    }

    public override string ToString()
    {
        return $"{Model} {FuelAmount.ToString("0.00")} {TravelledDistance}";
    }
}