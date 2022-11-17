// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

string[] array = SetArray();
string[] result = FindLessThan(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] SetArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

string[] FindLessThan(string[] array, int n) {
    string[] arrayNew = new string[CountLessThan(array, n)];

    for(int i = 0, j = 0; i < array.Length; i++) {
        if(array[i].Length <= n) {
            arrayNew[j] = array[i];
            j++;
        }
    }

    return arrayNew;
}

int CountLessThan(string[] array, int n) {
    int count = 0;

    for(int i = 0; i < array.Length; i++) {
        if(array[i].Length <= n) {
            count++;
        }
    }

    return count;
}