public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a;  // boxing. A change from reference into value(object). Makes a new object in heap
        int c = (int)b; // unboxing. A change from value(object) into reference
        Console.WriteLine($"a: {a}, b: {b}, c: {c}"); // printing
    }
}