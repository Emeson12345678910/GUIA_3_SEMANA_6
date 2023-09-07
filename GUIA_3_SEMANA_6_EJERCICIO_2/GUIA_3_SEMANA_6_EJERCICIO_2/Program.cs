class Operacionn
{
    static void Main()
    {
        int[] scores = { 90, 71, 82, 93, 75, 82 };

        var queryLowNums =
            from num2 in scores
            where num2 > 80
            orderby num2 descending
            select num2;

        foreach (var num2 in queryLowNums)
        {
            Console.WriteLine(num2);
            {
                static bool isEven(int i)
                { return i % 2 == 0; }
            }
        }
    }
}