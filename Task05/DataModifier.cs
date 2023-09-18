class DataModifier
{

    public double DaysDifference { get; set; }

    public void DaysDatesDifference(string StringDate1, string StringDate2)
    {
        DateTime date1 = DateTime.Parse(StringDate1);
        DateTime date2 = DateTime.Parse(StringDate2);

        double difference = (date2 - date1).TotalDays;
        this.DaysDifference = Math.Abs(difference);
    }
}