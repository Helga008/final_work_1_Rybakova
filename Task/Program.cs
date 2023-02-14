// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный
// массив можно ввести с клавиатуры либо задать на старте. При решении лучше обойтись исключительно массивами.


int getIntFromUser(string message)
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine());
    return userInt;
}


string[] GetStringArray (int length)
{
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine("Введите слово или комбинацию символов");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");;
}

string[] GetArray3SizeElements(string[] array)
{
    int j = 0;
    string[] array2 = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[j] = array[i];
            j++;
        }
    }
    return array2;
}

int length = getIntFromUser("Введите размер массива");
string[] array = GetStringArray(length);

PrintArray(array);
string[] arr = GetArray3SizeElements(array);
PrintArray(arr);