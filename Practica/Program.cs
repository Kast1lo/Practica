Console.Write("Введите число: ");
string bin = Console.ReadLine();
int dec = Convert.ToInt32(bin, 2);
Console.WriteLine($"число:{dec}");


Console.Write("Введите второе число: ");
int value = Convert.ToInt32(Console.ReadLine());
string bolt = Convert.ToString(value, 2);
Console.WriteLine($"число: {bolt}");


int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
int T = int.Parse(Console.ReadLine());
int totalMinutes = N * 60 + M;
totalMinutes += T;
totalMinutes %= 1440;
int hours = totalMinutes / 60;
int minutes = totalMinutes % 60;
Console.WriteLine($"{hours:D2}:{minutes:D2}");