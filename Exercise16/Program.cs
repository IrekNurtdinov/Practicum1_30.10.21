// Сформировать случайным образом N-элементный массив, заполненный однозначными 
// целыми числами разных знаков. Задать к и выяснить

// сколько раз повторяется к в массиве?
// сколько элементов находится между первым и последним к?
// сколько раз встречается к?


int[] CreateAndFillArray(int amount, int min, int max)  // метод для создания N-элементного массива и заполнения  однозначными 
                                                        // целыми числами 
{
    int[] array = new int[amount];
    int lenght = array.Length;
    int index = 0;

    while (index < lenght)
    {
        array[index] = new Random().Next(min, max);
        if (array[index] != 0)
        {
            Console.Write($"{array[index]} ");
            index++;
        }

    }
    return array;

}



int[] newArray = CreateAndFillArray(10, -9, 10);           //как сюда передать значения из массива array созданного в методе?
Console.WriteLine();
Console.WriteLine("Введите число от -9 до 9 включительно и нажмите Enter");
int k = Convert.ToInt32(Console.ReadLine());                     // нужно  сделать чтобы пользователь вводил к

int index = 0;
int count = 0;
int firstIndex = 0;
int lastIndex = 0;
while (index < newArray.Length)
{
    if (newArray[index] == k)
    {
        count++;

    }
    firstIndex = index;
    index++;
}
Console.WriteLine($"Число {k} встречается в  массиве {count} раз."); // выяснили сколько раз повторяется к



