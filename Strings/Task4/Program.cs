// See https://aka.ms/new-console-template for more information
string GetString() {
    Console.WriteLine("Введите строку, состоющую из нескольких слов: ");
    return Console.ReadLine();
}

// Количество слов
int WordCounter(string str) {
    int count = 1;
    for (int i = 0; i < str.Length; i++) {
        if (str[i] == ' ') count++;
    }
    return count;
}

string [] ReverseString(string str) {
    string [] str2 = new string [WordCounter(str)];
    int i = 0;
    int j = 0;
    while (j < str.Length) {
        if (str[j] != ' ') {
            str2[i] += str[j];
        } else i++;
        j++;
    }
    return str2;
}

void PrintReverse (string [] str, int number) {
    for (int i = number - 1; i >= 0; i--) {
        Console.Write(str[i] + " ");
    }
}

// Основная программа
//Console.WriteLine("Введите строку, состоющую из нескольких слов: ");
string str1 = GetString();
string [] newString = ReverseString(str1);
int number = WordCounter(str1);
//Console.WriteLine(WordCounter(str1));
//Console.WriteLine(newString[0]);
PrintReverse(newString, number);