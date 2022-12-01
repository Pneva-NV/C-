// 1 метод - ничего не принимает и ничего не возвращает

void Method1()
{
    Console.WriteLine("Пнева Н.В.");
}
Method1();

// 2 метод - принимает, но не возвращает

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Любой текст");
Method2("Который можно менять");
Method2("И выводить на экран");

// Можно указывать несколько различных аргументов

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Повторение текста, указанное колечество раз", 3);
Method21("Текст можно измениять и количество то же", 2);

// Бывают именованные аргументы, каждому из которых можно также назначать определенное значение

Method21(msg: "И ещё раз", count: 5);

// 3 метод - ничего не принимает, но возвращает

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// 4 метод - и принимает, и возвращает

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
// String.Empty - изначально указывается пустая строкм
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string result = Method4(4, "УРА!!!");
Console.WriteLine(result);