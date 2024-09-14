using System;


List<string> names = new List<string> { "Anna", "Jonathan", "Canada", "Andrew",
"Banana", "Alan" };
string input = "";

static List<string> SearchStrings(List<string> list, string search)
{
    return list.Where(s => s.IndexOf(search, StringComparison.OrdinalIgnoreCase)
    >= 0).ToList();
}

while (true)
{
    Console.Clear();
Console.WriteLine("Введите строку для поиска (или 'exit' для завершения):");
    Console.WriteLine(input);
    if (input.ToLower() == "exit")
        break;
List<string> results = SearchStrings(names, input);
if (results.Count > 0)
{
    Console.WriteLine("Найдены строки:");
    foreach (var result in results)
    {
        Console.WriteLine(result);
    }
}
else
{
    Console.WriteLine("Совпадений не найдено.");
}
    while (true)
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        Console.WriteLine(input);
        if (key.Key == ConsoleKey.Backspace)
        {
            input = input.Replace(input[input.Length - 1].ToString(), "");
            break;
        }
        else 
        {
            input += key.KeyChar;
            break;
        }
    }
}