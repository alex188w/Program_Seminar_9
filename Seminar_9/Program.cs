// Рекурсия простой пример
void Recursion(int number)
{
if (number == 0) return;
Console.WriteLine("Привет рекурсия! ");
number--;
Recursion(number);
}

void Zadacha63(int number, int counter = 1)
// Задача 63: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.
{
if (counter > number) return;
Console.WriteLine(counter);
counter++;
Zadacha63(number, counter);
}

void Zadacha65(int M, int N)
// Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N
{
if (M > N) return;
Console.WriteLine(M);
M++;
Zadacha65(M, N);
}

void Zadacha65_1() // другой метод
{
    Console.WriteLine("Введите первое число ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе чило ");
    int N = Convert.ToInt32(Console.ReadLine());
    string Rec(int a, int b)
    {
        if (a <= b) return $"{a} " + Rec(a+1, b); // ответ собирается постепенно (склеивается) в обратном порядке
        else return string.Empty;
    }
    Console.WriteLine(Rec(M, N));

}

void Zadacha67(int N, int sum = 0)
// Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр
{
    if (N == 0)
    {
        Console.WriteLine("Сумма цифр данного числа равна " + sum);
        return;
    }     
    sum = sum + N % 10;        
    N = N / 10;
    Zadacha67(N, sum); // sum - прописываем, чтобы не обращалась в 0 при перезапуске
}

// Напишите программу, которая на вход принимает два числа A и B, и 
// возводит число А в целую степень B с помощью рекурсии
void Zadacha69()
{
    int a = 5;
    int b = 3;
    Console.Write($"Число {a} в степени {b} равно ");
    Recursion1(a, b);    
}

void Zadacha69_1()
{
    Console.WriteLine("Введите первое число ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе чило ");
    int n = Convert.ToInt32(Console.ReadLine());
    int Rec(int m, int n, int result = 1)
    {
        if(n!=0) // не равен 0
        {
            result = result * m;
            n--;
            return Rec(m, n, result);
        }
        else return result;
    }
    Console.WriteLine($"Число {m} в степени {n} равно {Rec(m, n)}");
}

// Произведение матриц (условие длина строки в первой должно быть равно длине столбца второй)
// приумножении матрицы 5х2 и 2х3 = 5х3
// произведение матриц - сумма произведений элементов строки первой матрицы 
// на соответствующие элементы столбца второй матрицы

void MatrixMultiplication()
{
    int rowsFirst = 5;
    int columnsFirst = 2;
    int rowsSecond = columnsFirst; // обязательное условие!!
    int columnsSecond = 3;
    int[,] a = new int[rowsFirst, columnsFirst];
    int[,] b = new int[rowsSecond, columnsSecond];
    int [,] result = new int[rowsFirst, columnsSecond];
    FillArray(a, 1, 5);
    Console.WriteLine("Первая матрица ");
    PrintArray(a);
    Console.WriteLine();
    FillArray(b, 1, 5);
    Console.WriteLine("Вторая матрица ");
    PrintArray(b);

    for (int i = 0; i < rowsFirst; i++)
    {
        for (int j = 0; j < columnsSecond; j++)
        {
            for (int k = 0; k <  rowsSecond; k++)
            {
                result[i, j] = result[i, j] + a[i, k] * b[k, j];
            }            
        }
    }
    Console.WriteLine();   
    Console.WriteLine("Результат умножения первой матрицы на вторую ");
    PrintArray(result);
}


void Recursion1(int a, int b, int result = 1)
{
    if (b == 0)
    {   
        Console.WriteLine(result);  
        return;        
    }
    result = result * a;
    b--;
    Recursion1(a, b, result);
}

void FillArray(int[,] array, int startNumber, int finishNumder)
{
    Random random = new Random();
    finishNumder++;
    int rows =  array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(startNumber, finishNumder);   
        }
    }
}
void PrintArray(int[,] array)
{
    int rows =  array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
              Console.Write(array[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

    
MatrixMultiplication();  
//Zadacha69_1();    
//Recursion1(2, 5, 1);
//Zadacha69();
//Zadacha67(1476);
//Zadacha65_1();
//Zadacha65(2, 24);
//Zadacha63(5);
//Recursion(5);


