// Задача
// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
// Создать на его основе масив B, отбрасывая те, которые
//  + нарушают порядок возрастания
//  + больше среднего арифметического элементов A
//  + чётные
int GetRandom(int minValue, int maxValue)     // для примера сделали метод для возврата случайных
{
    return new Random().Next(minValue, maxValue);
}

int[] A = new int[10];                         //создаем массив                                            
int index = 0;
while (index < A.Length)                       //заполняем массив случайными числами
{
     A[index] = GetRandom(10, 100);    //[10, 99)
     Console.Write($"{A[index]} ");          
     index++;
}
Console.WriteLine();

// index = 1;   // создаем массив В с исключением значений наруающих...
// int currentElement = A[0];
// Console.Write(currentElement);
// while (index < A.Length)
// {
//     if(A[index] > currentElement)
//     {
//         Console.Write($" {A[index]} ");
//         currentElement = A[index];
//     }
//     index++;
// }


