/* # Задача 1
Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

 0
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

//3) переворот массива (Максим)

public static class Library1
{
    public static int[] ArrayTurn(int[] arr)
    {
        int arrEnd = arr.Length - 1;

        for (int i = 0; i < arr.Length / 2; i++)
        {
            int x = arr[i];
            arr[i] = arr[arrEnd];

            arr[arrEnd] = x;

            arrEnd -= 1;
        }
        return arr;
    }
}