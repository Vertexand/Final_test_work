/// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []


Console.WriteLine("Массив из n строк, введите n:");// 1 вар.
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
//Заполнение массива
int i=0;
while (i<array.Length) 
    {
        Console.WriteLine($"введите {i}-ю строку:");
        array[i]=Console.ReadLine();
        i++;
    }
Console.WriteLine("Ваш массив:");
show(array);
string[] result = new string[CountSize(array)];//выделение памяти под нов массив
i=0;                     // заполнение нов массива
n=0;
while (i<array.Length)
    {
        if (size(array[i]))
        {
            result[n]=array[i];
            n++;        
        }
        i++;
    }
Console.WriteLine("Результирующий массив ");
show(result);
void show(string[] array)//метод выборка
    {
        int i=0;
        while (i<array.Length)
        {
            Console.Write($" {array[i]+""}");
            i++;
        }
        Console.WriteLine();
    }
// подсчет выбранных элементов 
int CountSize(string[] array)
{
    int n=0;
    int i=0;
    while (i<array.Length)
    {
        if (size(array[i])) n++;
            
        i++;
    }
    return n;
}
bool size(string s) //проверка длинны элемента
{
    if (s.Length<4) 
    return true;
    else return false;
}



/* Console.WriteLine("Введите любой текст с клавиатуры:");//РЕШЕНИЕ 2 вар. не рабоч  
string[] sourceArray = Console.ReadLine().Split();
Console.WriteLine($"Исходный массив: {string.Join(", ", sourceArray)}");
Console.WriteLine($"Укороченный массив из строк с 3 и менее символами: {string.Join(", ", shortarr)}");
// int [] sourceArray = Convert.ToInt32string[] sourceArray

string[] shortarr(string[] sourceArray)//принимать будет на вход источник
{
    string[] destinationArray = new string[sourceArray.Length-j];
    j=0;
    for (string i = sourceArray[0]; string i < sourceArray.Length; i++)//i стороки , length число и как совместить, 
    // конвертировать старый массив?
       {
    if ((stringStr.Length <= 3))
    {
        destinationArray[i] = sourceArray[i];
    }
    else
    {
        j++;
        // new string[sourceArray.Length]--;
    }
    // return destinationArray;
} */




