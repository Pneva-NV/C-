// Заменить все пробелы в тексте звездочками.
// Маленькие буквы "к" заменить большими "К".
// Большие буквы "С" заменить маленькими "с".

string text = "Снова наступила ночь, когда на небе много звезд."
            + "Снег лег как мягкое покрывала и только дорога чернела вдали."
            + "Сверкнул и погас вдали огонек.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '*');
Console.WriteLine(newText); 
Console.WriteLine(); 
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText); 
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText); 