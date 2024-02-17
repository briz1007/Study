using Asp.NetCore;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

public class Program
{
    //public static void Main(string[] args)
    //{
    //    //Program onj = new Program();
    //    //Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
    //    ////Console.WriteLine("The generation number of object obj is:" + GC.GetGeneration(obj));
    //    //Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
    //    //CreateWebHostBuilder(args).Build().Run();
    //    //int num1, num2;
    //    //Console.WriteLine("Enter a number");
    //    //num1 = Convert.ToInt32(Console.ReadLine());
    //    //for (num2 = 1; num2 <= 10; num2++)
    //    //{
    //    //    Console.WriteLine("{0}*{1} = {2}", num1, num2, num1 * num2);
    //    //}
    //    int i, j, n;
    //    Console.WriteLine("Enter a Value");        
    //    n = Convert.ToInt32(Console.ReadLine());
    //    //Pattern 1
    //    //for (i = 0; i<n; i++)
    //    //{
    //    //    for(j = 0; j < n; j++)
    //    //    {
    //    //        Console.Write("*");
    //    //    }
    //    //    Console.WriteLine();

    //    //}
    //    //Pattern 2
    //    //for (i = 0; i < n; i++)
    //    //{
    //    //    for (j = 0; j <= i; j++)
    //    //    {
    //    //        Console.Write("*");
    //    //    }
    //    //    Console.WriteLine();

    //    //}
    //    //pattern 3
    //    //for (i = 1; i <= n; i++)
    //    //{
    //    //    for (j = 1; j <= i; j++)
    //    //    {
    //    //        Console.Write(i);
    //    //    }
    //    //    Console.WriteLine();

    //    //}
    //    //pattern-4
    //    //for (i = 0; i < n; i++)
    //    //{
    //    //    for (j = 0; j < n-i-1; j++)
    //    //    {
    //    //        Console.Write(" ");
    //    //    }
    //    //    for (j = 0; j < 2*i+1; j++)
    //    //    {
    //    //        Console.Write("*");
    //    //    }
    //    //    for (j = 0; j < n - i - 1; j++)
    //    //    {
    //    //        Console.Write(" ");
    //    //    }
    //    //    Console.WriteLine();

    //    //}
    //    //Console.ReadLine();
    //}
    public static void Main(string[] args)
    {
        CreateWebHostBuilder(args).Build().Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
}
