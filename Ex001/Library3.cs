public static class Library3
{
    public static int[] makeArray()
    {
        int[] array = new int[5];
        Random rand = new Random();
        for (int i = 0; i< array.Length; i++)
        array[i] = rand.Next();
        return array;
    }
}