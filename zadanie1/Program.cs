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
void ShowNumber(int first, int second)
{
    if(first > second) return;
    if (first % 2 == 0)
    System.Console.Write($"{first} ");
    ShowNumber(first+1, second);
    
}

int first = input("Введите первое число: ");
int second = input("Введите второе число: ");
System.Console.WriteLine();
validate(first); validate(second);
ShowNumber(first, second);