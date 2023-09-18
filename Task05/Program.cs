// Data Modifier

string date1 = Console.ReadLine();
string date2 = Console.ReadLine();

DataModifier dataModifier = new DataModifier();
dataModifier.DaysDatesDifference(date1, date2);

Console.WriteLine(dataModifier.DaysDifference);
