/* 
Функция Аккермана
f(m, n)
Если m = 0, то f(m, n) = n + 1.
Если n = 0, то f(m, n) = f((m - 1), 1).
Функция в общем виде:
f(m, n) = f((m - 1), f(m, (n - 1))).
*/

// Функция ввода первого аргумента
int InputFirstArgument() {
    Console.WriteLine("Введите первый аргумент функции Аккермана:");
    return Int32.Parse(Console.ReadLine());
}

// Функция ввода второго аргумента
int InputSecondArgument() {
    Console.WriteLine("Введите второй аргумент функции Аккермана:");
    return Int32.Parse(Console.ReadLine());
}

// Функция Аккермана
int Akkerman(int m, int n) {
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Clear();
int m = InputFirstArgument();
int n = InputSecondArgument();
Console.WriteLine(Akkerman(n, m));