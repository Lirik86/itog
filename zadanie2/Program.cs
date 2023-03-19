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
int ShowNumber(int first, int second)
{
    if (first == 0) return (second * (second + 1)) / 2;           
    else if (second == 0) return (first * (first + 1)) / 2;       
    else if (first == second) return first;                       
    else if (first < second) return second + ShowNumber(first, second - 1); 
    else return second + ShowNumber(first, second + 1);
}

int first = input("Введите первое число: ");
int second = input("Введите второе число: ");
System.Console.WriteLine();
validate(first); validate(second);
Console.WriteLine($"{ShowNumber(first, second)} ");