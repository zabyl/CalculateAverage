internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Lütfen ortalamasını hesaplamak istediğiniz fibonacci derinliğini giriniz: ");
        int fibonacciDepth = Convert.ToInt32(Console.ReadLine());
        
        FibonacciAverage.CalculateAvrg(fibonacciDepth);
    }
}