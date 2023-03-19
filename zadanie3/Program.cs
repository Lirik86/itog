int input(string msg)
{
    System.Console.WriteLine($"{msg} >");
    int value;
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

bool validate(int num)
{
    if (num >=0) return true;
    else System.Console.WriteLine("Одно из чисел не натуральное!"); Environment.Exit( 0 ); 
    return false;
    
}

int Func(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Func(n - 1, 1);
    else
        return Func(n - 1, Func(n, m - 1));
}

int first = input("Введите первое число: ");
int second = input("Введите второе число: ");
System.Console.WriteLine();
validate(first); validate(second);
Console.WriteLine($"{Func(first, second)} ");