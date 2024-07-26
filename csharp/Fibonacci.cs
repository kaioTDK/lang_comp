using static System.Console;
using System.Diagnostics;

public static class Fibonacci{

    internal static ulong[] Fibo(uint num){
        var num_list = new ulong[num];
        num_list[0] = 0;
        num_list[1] = 1;
        
        for (uint i = 2; i < num; i++) {
            num_list[i] = num_list[i-2] + num_list[i -1];
        }
        return num_list;
    }

    public static void test_fibo(uint num){
        var time = new Stopwatch();
        time.Start();
        Fibo(num);
        time.Stop();
        WriteLine(time.ElapsedMilliseconds);

    }

    public static void print_fibo(uint num) {
        var num_list = Fibo(num);
        for (int i = 0; i < num_list.Length; i++){
            WriteLine(num_list[i]);
        }
    }

}