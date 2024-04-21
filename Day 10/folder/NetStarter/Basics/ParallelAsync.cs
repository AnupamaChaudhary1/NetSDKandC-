// //parallel programming :multi core- multiple cpus physically
// //technique to makr use of these cpus in parallel
// //.Net has TPL( task parallel library) 

// //AJAX non-b;ocking i/o 
// //asynchronous
// //.net async, awat
// //
// using System;
// using System.Threading;
// using System.Threading.Tasks;
// class ParallelAsync.cs
// {
//     int[] numbers = [22, 34, 52, 86, 34];

// public void ProcessNumbers()
// {
//     Console.WriteLine("Sequential implem");
//     //sequential
//     foreach (var num in numbers)
//     {
//         DoWork(num);
//         Console.WriteLine("parallel");
//         ParallelAsync.ForEach(num, DoWork);
//     }
// }

// public void DoWork(int num)
// {
//     Thread.Sleep(1000); //delay
//     Console.WriteLine($"Num: {num}");
// }
// // public async Task IgniteStove()
// // {
// //     await Task.delay(5000);
// // }
// // public void putPot() { }
// // public void putwater() { }
// // public void putSugar() { }

    
// }
using System;
using System.Threading;
using System.Threading.Tasks;

class ParallelAsync
{
    int[] numbers = {22, 34, 52, 86, 34};

    public void ProcessNumbers()
    {
        Console.WriteLine("Sequential implementation");
        // Sequential
        foreach (var num in numbers)
        {
            DoWork(num);
        }

        Console.WriteLine("Parallel implementation");
        // Parallel
        Parallel.ForEach(numbers, DoWork);
    }

    public void DoWork(int num)
    {
        Thread.Sleep(1000); // Delay
        Console.WriteLine($"Num: {num}");
    }

    // Other methods...
}
