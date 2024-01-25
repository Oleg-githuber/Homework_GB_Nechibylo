// Программа для обратного вывода массива, с помощью рекурсии


// Функция получения массива
int [] GetArray() {
    int [] arr = {1, 2, 5, 0, 10, 34};
    return arr;
}

void ShowReverseArray(int [] array, int index) {
    if (index == array.Length) return;
    else {
        ShowReverseArray(array, index + 1);
        Console.Write($"{array[index]}\t");
    }
}

void ShowArray(int [] array, int index) {
    if (index == array.Length) return;
    else {
        
        Console.Write($"{array[index]}\t");
        ShowArray(array, index + 1);
    }
}

Console.Clear();
int [] arr = GetArray();
Console.WriteLine("Ваш массив:\n");
ShowArray(arr, 0);
Console.WriteLine("\nОбработаный массив:\n");
ShowReverseArray(arr, 0);