// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

//Ввод количества чисел с экрана
int Promt (string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine()!;
    int result = int.Parse (ReadInput);
    return result;
}

// Метод ввода масисва
int [] Input_Array (int length)
{
    int[] arry_M = new int[length];
    for (int i = 0; i< length; i++)
    {
        //Console.Write($"Ведите {i+1}-е число  :");
        //arry_M[i] = int.Parse(Console.ReadLine()!);
        arry_M[i] = Promt($"Ведите {i+1}-е число  :");
    }
    return arry_M;
}

// Метод вывода массива
void PrintArray (int [] array)
{
    Console.Write("[");
    for(int i=0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.WriteLine("]");
}

// Метод подсчета количества положительных чисел
int Coll_Positiv_Num (int [] array)
{
    int col_Pos_num = 0;
    for (int j =0; j < array.Length; j++)
    {
        if (array[j] > 0 ) {col_Pos_num++;}
    }
    return col_Pos_num;
}


int M = Promt("Введите количество чисел М  :");
int[] array = Input_Array (M);
Console.WriteLine();
Console.Write("Вами были введены следующие числа : ");
PrintArray (array);
int result = Coll_Positiv_Num(array);
Console.Write($"Из введенных {M} чисел положительнх {result}");



