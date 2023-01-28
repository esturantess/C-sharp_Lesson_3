// Циклы

// Цикл в цикле
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}"); // интерполяция строк
//     }
//     Console.WriteLine();
// }

// Задача 1
// ===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".

// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; // инициализация пустой строки
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
        result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие пруссского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
newText = Replace(newText, 'С', 'с');
Console.WriteLine();
Console.WriteLine(newText);