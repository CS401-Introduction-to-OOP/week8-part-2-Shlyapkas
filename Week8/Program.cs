
class Program
{
    public static void Main()
    {
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;
        p2.X = 3;
        p1.Print();
        p2.Print();
        
        PointRef r1 = new PointRef { X = 1, Y = 2 };
        PointRef r2 = r1;
        r2.Y = 5;
        r1.Print();
        r2.Print();
        
        BoxingTester.Test();
    }
    
    /* 
     1. Пам'ять:
     Структури зазвичай зберігаються в стеку (Stack).
     Класи зберігаються в купі (Heap), а в стеку лише посилання на них.
     2. Копіювання:
     При присвоєнні 'Point 2 = Point 1' копіюються всі дані структури. Вони стають автономними.
     При присвоєнні 'PointRef 2 = PointRef 1' копіюється лише "адреса" об'єкта.
     3. Нульові значення:
     Структури не можуть бути null (за замовчуванням).
     Класи можуть мати значення null.
     */
}