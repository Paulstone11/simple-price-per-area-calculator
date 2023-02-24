Console.WriteLine("Enter length");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("Enter width");
int width = int.Parse(Console.ReadLine());
int area = length * width;
int Par = 15;
Console.WriteLine("Price per area = " + Par);
Console.ReadKey();
Console.WriteLine("You must pay = " + area * Par);