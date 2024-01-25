/* Программа вывода в консоль всех  натуральных чисел от M до N */

// Функция ввода первого числа
int Number1() (
    Console.WriteLine("Введите первое натуральное число: ");
    int m = Int32.Parse(Console.ReadLine());
    return m;
)

// Функция ввода первого числа
int Number2() (
    Console.WriteLine("Введите второе натуральное число: ");
    int n = Int32.Parse(Console.ReadLine());
    return n;
)

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
