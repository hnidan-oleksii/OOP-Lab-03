// Rectangle Intersection 

using System.Reflection;

int[] arguments = Console.ReadLine().Split().Select(int.Parse).ToArray();
(int rectsNumber, int intersectionChecks) = (arguments[0], arguments[1]);
Rectangle[] rects = new Rectangle[rectsNumber];

for (int i = 0; i < rectsNumber; i++)
{
    string[] values = Console.ReadLine().Split();

    string id = values[0];
    int width = int.Parse(values[1]);
    int height = int.Parse(values[2]);
    int x0 = int.Parse(values[3]);
    int y0 = int.Parse(values[4]);

    rects[i] = new Rectangle(id, width, height, x0, y0);
}

for (int i = 0; i < intersectionChecks; i++)
{
    string[] rectsToCheck = Console.ReadLine().Split();

    Rectangle firstRect = rects.FirstOrDefault(rect => string.Equals(rect.Id, rectsToCheck[0]));
    Rectangle secondRect = rects.FirstOrDefault(rect => string.Equals(rect.Id, rectsToCheck[1]));

    Console.WriteLine(firstRect.CheckIntersection(secondRect));
}
