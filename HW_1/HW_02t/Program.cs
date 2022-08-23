Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

//Console.WriteLine(a>99 ? a.ToString()[2] : + a +" -> Нет третьей цифры");

if (a < 100)
{
  Console.WriteLine(a + " -> Нет третьей цифры");  
}
else
{
    Console.WriteLine(a.ToString()[2]);
}

