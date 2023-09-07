
//EJERCICIO 1
class Operacion
{
    static void Main()
    {
        int[] scores = { 97, 92, 81, 60, };

        var queryLowNums =
            from num in scores
            where num > 80
            orderby num descending
            select num;
        foreach (var num in queryLowNums)
        {
            Console.WriteLine("NUmeros mayor a 80");
            Console.WriteLine(num);

        }

    }
}

