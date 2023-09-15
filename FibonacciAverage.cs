public static class FibonacciAverage
{
    public static void CalculateAvrg(int depth)
    {
        int firstNum = 0, secondNum = 1, thirdNum = 0;
        int total = firstNum + secondNum;
        Console.Write("{0} {1}", firstNum, secondNum);
        for (int i = 2; i < depth; i++)
        {
            thirdNum = firstNum + secondNum;
            Console.Write(" {0}", thirdNum);
            firstNum = secondNum;
            secondNum = thirdNum;
            total += thirdNum;
        }
        double totalDouble = Convert.ToDouble(total);
        double average = totalDouble / depth;
        Console.WriteLine($" Average of {depth} first fibonacci numbers is {average}.");
    }
}