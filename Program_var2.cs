/* Итоговая проверочная работа.
Написать программу, которая из введенного с клавиатуры массива строк создаст
новый массив, в котором будут только строки длиной меньше или равной 3.

Задача решена 2мя способами: с помощью списков (закомментировано) и обычным.
Алгоритм составлен ко второму способу.
*/

/*
// Вариант 1. С помощью списка.

Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

string[] array = new string [num];
List<string> arrayNew = new List<string>();

for (int i = 0; i < num; i++)
{
    Console.Write($"Введите {i+1} элемент массива: ");
    array[i] = Console.ReadLine();
    if (array[i].Length<=3) arrayNew.Add(array[i]);
}

if (arrayNew.Count>0)
{
    Console.WriteLine("Массив из элементов, длина которых <=3 символов: ");
    foreach(string value in arrayNew) Console.WriteLine($"Это {arrayNew.IndexOf(value)+1} элемент массива: {value}");
}
else Console.WriteLine("Не было ни одного элемента меньше 3х символов длиной.");
*/

// Вариант 2. 

Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

string[] array = new string[num];
int arrayLength = 0;

for (int i = 0; i < num; i++)
{
    Console.Write($"Введите {i + 1} элемент массива: ");
    array[i] = Console.ReadLine();
    if (array[i].Length <= 3)
        arrayLength++;
}

if (arrayLength > 0)
{
    string[] arrayNew = new string[arrayLength];
    Console.WriteLine("Массив из элементов, длина которых <=3 символов: ");
    int indexNew = 0;

    for (int i = 0; i < num; i++)
    {
         if (array[i].Length <= 3)
        {
            arrayNew[indexNew]=array[i];
            Console.WriteLine($"Это {indexNew+1} элемент массива: {arrayNew[indexNew]}");
            indexNew++;
        }
    }
}
else
    Console.WriteLine("Не было ни одного элемента меньше 3х символов длиной.");
