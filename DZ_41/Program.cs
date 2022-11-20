//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


int n = 0;
int[] numbers = new int[n];


int[] ReadNumbers (int n)
{
    int[] array = new int[n];
    Console.Write($"Введите {n} чисел: ");
    for (int i = 0; i < n; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}


int CalculateTask (int[] inputArray)
{
    int answer = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i]>0)
        {
            answer++;
        }
    }
    return answer;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    Console.Write(string.Join(",", array));
    Console.WriteLine("]");
}

numbers = ReadNumbers(5);
PrintArray(numbers);
Console.Write ("Количество чисел больше 0: " + CalculateTask(numbers));