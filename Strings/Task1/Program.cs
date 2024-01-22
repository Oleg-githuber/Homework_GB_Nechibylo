char [,] ch1 = {{'a', 'b', 'c'},
                {'d', 'e', 'f'},
                {'g', 'h', 'i'}};
int stringSize = ch1.Length;
string str1 = "";
foreach(char e in ch1) {
    str1 += e;
}
Console.WriteLine(str1);