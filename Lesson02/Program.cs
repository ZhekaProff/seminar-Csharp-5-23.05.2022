// Написать программу преобразования десятичного числа в двоичное
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int tmpnumber = number;
int tmp = 0;
int count = 0; // определяет длинну массива
while(tmpnumber > 0)
    {
        tmp = tmpnumber % 2;
        tmpnumber = tmpnumber /2;
        count++;
    }
void FillArray(int[] array) 
{
    int tmp = 0;
    int index = 0;
    int length = array.Length;
    while(index < length)
    {
        tmp = number % 2;
        number = number /2;
        array[index] = tmp;

        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}
int[] array = new int[count];
FillArray(array);
PrintArray(array.Reverse().ToArray());
Console.WriteLine($" длинна {count} ");

//Второе решение //Написать программу преобразования десятичного числа в двоичное

// Console.WriteLine("Введите число");
// int a = int.Parse(Console.ReadLine());
// int b = 0;
// string result = " ";
// //int result = 0;

// while(a > 0)
// {
//     b = a % 2;
//     result = b + result;
//     a = a / 2;
  
// }
// Console.WriteLine(result);

// Решение три // 2. Перевести число в двоичное
// Console.Write("Введите число: ");
// int Number = int.Parse(Console.ReadLine() ?? "0");
// int Bit = Number % 2;
// int NewNumber = Bit;
// Number = Number / 2;
// int i = 1;
// while (Number > 0)
// {
//     Bit = Number % 2;
//     Number = Number / 2;
//     NewNumber = NewNumber + Bit * (int)Math.Pow(10,i);
//     i++;
// }
// Console.WriteLine(NewNumber);
