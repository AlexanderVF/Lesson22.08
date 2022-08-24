Console.Clear();
Console.WriteLine("Введите число от 1 до 7");
int a = int.Parse(Console.ReadLine());

int b = 1;
int c = 2;
int d = 3;
int e = 4;
int f = 5;
int g = 6;
int j = 7;

if (a > 7)
{
   Console.WriteLine("Вы ввели неверное число, введите число от 1 до 7"); 
}

if (a == b)
{
    Console.WriteLine(a + " -> Нет, рабочий день");
}
if (a == c)
{
    Console.WriteLine(a + " -> Нет, рабочий день");
}
if (a == d)
{
    Console.WriteLine(a + " -> Нет, рабочий день");
}
if (a == e)
{
    Console.WriteLine(a + " -> Нет, рабочий день");
}
if (a == f)
{
    Console.WriteLine(a + " -> Нет, рабочий день");
}
if (a == g)
{
    Console.WriteLine(a + " -> Да, выходной день");
}
if (a == j)
{
    Console.WriteLine(a + " -> Да, выходной день");
}