Console.WriteLine();
Console.Write("Введите количество элементов: ");
int len = Convert.ToInt32(Console.ReadLine());

string[] stringArr = new string[len];
string index = string.Empty;
string tmp = string.Empty;

for (int i = 0; i < len; i++)
{
    Console.Write("Введите {0}-й элемент ({1}): ", i + 1, i);
    stringArr[i] = Console.ReadLine();
    if (stringArr[i].Length <= 3)
    {
        index += i;
    }
}
Console.WriteLine();

Console.Write("[");
for (int i = 0; i < stringArr.Length; i++)
{
    if (i < stringArr.Length - 1) tmp = ", ";
    else tmp = "]";
    Console.Write($"\"{stringArr[i]}\"" + tmp);
}

Console.Write(" -> ");

Console.Write("[");
for (int i = 0; i < index.Length; i++)
{
    if (i < index.Length - 1) tmp = ", ";
    else tmp = "]";
    Console.Write($"\"{stringArr[Convert.ToInt32(Convert.ToString(index[i]))]}\"" + tmp);
}
Console.WriteLine();


// string[] newArr = new string[index.Length];
// for (int i = 0; i < index.Length; i++)
// {
//     newArr[i] = stringArr[Convert.ToInt32(Convert.ToString(index[i]))];
// }
// for (int i = 0; i < newArr.Length; i++)
// {
//     Console.Write($"{newArr[i]} ");
// }
