public static class Library2
{
    public static string PrintArray(int)string printArray(int[] array)
    {
        string nArray = String.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            nArray = nArray + array[i] + " ";
        }
        return nArray;
    }
}