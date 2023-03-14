public static class Library
{
    public static bool TriangleSidesCheck(int a, int b, int c)
    {
        if (a + b > c && a + c > b && b + c > a) return true;
        return false;
    }
    public static string PrintResult(int a, int b, int c, bool exist)
    {
        if (exist) return $"Триугольник со сторонами AB={a} BC={b} CA={c} соответсвует теореме";
        return "Такого триугольника быть не может";
    }
}