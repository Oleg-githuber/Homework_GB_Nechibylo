// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите строку: ");
string str1 = Console.ReadLine();
bool isPalindrome = true;
for (int i = 0; i < (str1.Length / 2); i++) {
    if (str1[i] != str1[str1.Length -1 - i]) {
        isPalindrome = false;
    } 
}
if (isPalindrome) Console.WriteLine("Строка является палиндромом");
else Console.WriteLine("Строка не является палиндромом");