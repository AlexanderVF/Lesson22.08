Console.Clear();
Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());

int b = a % 100;

int c = b / 10;

Console.WriteLine("Вторая цифра числа " + a + " -> " + c);
