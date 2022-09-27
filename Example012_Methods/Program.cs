// Вид 1  - ничего не возвращают, ничего не принимают
void Method1()
{
    Console.WriteLine("Автор Елизавета");
}
// Method1();

// Вид 2 - ничего не возвращают, но могут принимать какие-то аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);

}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; //инкремент
    }
}
//Method21("Текст", 4);
//Method21(count: 4, msg: "новый текст");

//Вид 3 - ничего не принимают, но что-то возвращают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

//Вид 4 - что-то принимают и что-то возвращают
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf ");
Console.WriteLine(res);