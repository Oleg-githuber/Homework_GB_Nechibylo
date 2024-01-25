/* Программа вывода в консоль всех  натуральных чисел от M до N */

// Функция ввода первого числа
int SetNumber1() {
    Console.WriteLine("Введите первое натуральное число: ");
    int m = Int32.Parse(Console.ReadLine());
    return m;
}

// Функция ввода первого числа
int SetNumber2() {
    Console.WriteLine("Введите второе натуральное число: ");
    int n = Int32.Parse(Console.ReadLine());
    return n;
}

// Функция нахождения максимума(защита от дураков)

int Max(int m, int n) {
    if (m > n) return m;
    else return n;
}

// Функция нахождения минимума (защита от дураков)

int Min(int m, int n) {
    if (m > n) return n;
    else return m;
}

// Рекурсивная функция
void PrintNumbers(int m, int n) {
    
    if (m > n) return;
    else 
    {
        Console.Write($"{m}\t");
        PrintNumbers(m + 1, n);
    
    }
}

Console.Clear();
int m = SetNumber1();
int n = SetNumber2();
Console.WriteLine("Полученый ряд чисел:\n");
PrintNumbers(Min(m, n), Max(m, n));