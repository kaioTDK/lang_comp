using static System.Console;
using System.Diagnostics;

public static class Fibonacci{

    internal static void Fibo(uint num){
        var num_list = new uint[num];
        for (uint i = 1; i < num; i++) {
            num_list[i -1] = i-1 + i;
        }
    }
}