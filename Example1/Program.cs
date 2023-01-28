// Виды методов

// Вид 1
// Ничего не возвращают и ничего не принимают

void Method1()
{
    System.Console.WriteLine("Автор ... ");
}

// Method1(); // вызов метода


// Вид 2
// Ничего не возвращают, но могут принимать аргументы

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

// Method2(msg: "Текст сообщения");
// msg: - явное указание, какому аргументу какое значение мы хотим указать
// актуально, если метод принимает больше одного аргумента

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++; // инкрементирование - увеличение значения переменной; декрементировать - уменьшить значение;
    }
}

// Method21(msg:"Текст", count: 4); // - 4 - сколько раз выведется сообщение

// ctrl + c - если программа зациклилась

// Method21(count: 4, msg: "Новый текст"); // если используются именованные аргументы, писать их по порядку не обязательно.

// Вид 3
// Что-то возвращают, но ничего не принимают

int Method3()// если метод что-то возвращает, обязательно нужно указать тип данных того, что будет возвращаться
{
    return DateTime.Now.Year;
}

// int year = Method3();
// System.Console.WriteLine(year);

// Вид 4
// Что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

// string res = Method4(10, "o");
// System.Console.WriteLine(res);