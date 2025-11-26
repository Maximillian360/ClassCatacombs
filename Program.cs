// See https://aka.ms/new-console-template for more information

using ClassCatacombs;

Point myPoint = new Point();
Point myPoint2 = new Point();

myPoint.X = 2;
myPoint.Y = 3;

myPoint2.X = -4;
myPoint2.Y = 0;

Console.WriteLine($"{myPoint.X}, {myPoint.Y}");
Console.WriteLine($"{myPoint2.X}, {myPoint2.Y}");


Color myColor = new Color(169, 87, 90);
Color myColor2 = Color.CreateOrange();



Console.WriteLine($"myColor: {myColor.Red}, {myColor.Green}, {myColor.Blue}");
Console.WriteLine($"myColor2: {myColor2.Red}, {myColor2.Green}, {myColor2.Blue}");