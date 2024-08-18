using static System.Console;
using System.Diagnostics;

class QuickSort{

    public static void Test_QS(int length){
        var time = new Stopwatch();
        int[] array = new int[length];
        Random rand = new Random();
        
        for (int i = 0; i < array.Length;i++)
        {
            array[i] =rand.Next(0,array.Length - 1);
            // NumList[i] = i*(17-13)*2;
        }
        time.Start();
        quick_sort(array, 0, array.Length -1);
        time.Stop();
        WriteLine("size: "+ length);
        WriteLine("ms: "+ time.ElapsedMilliseconds);
        WriteLine("seconds: "+ time.ElapsedMilliseconds / 1000);
    }
    public static void Test_QS(int[] array){
        var time = new Stopwatch();
        
        time.Start();
        quick_sort(array, 0, array.Length -1);
        time.Stop();
        WriteLine("size: "+ array.Length);
        WriteLine("ms: "+ time.ElapsedMilliseconds);
        WriteLine("seconds: "+ time.ElapsedMilliseconds / 1000);
    }

    public static void call_qs(){
        int[] array = [5,4,2,3,7,8,1,6,9,11,10];
        var time = new Stopwatch();
        foreach (int var in array){
            Write(var+ ", ");
        }
        WriteLine();
        time.Start();
        quick_sort(array, 0, array.Length - 1);
        time.Stop();
        foreach (int var in array){
            Write(var+ ", ");
        }
        WriteLine("\n", time.ElapsedMilliseconds);
    }
    internal static int partition(int[] array, int start, int end) {
        
        var pivot = array[end];
        int i = (int)start - 1;

        for (int j = start; j <= end - 1; j++){
            if (array[j] < pivot){
                i++;
                int temp_l = array[i];
                array[i] = array[j];
                array[j] = temp_l;
            }
        }
        i++;
        int temp = array[i];
        array[i] = array[end];
        array[end] = temp;
        return i;
    }

    internal static void quick_sort(int[] array, int start, int end){
        
        if (end <= start) return;
        var pivot = partition( array, start, end);
        quick_sort( array, start, pivot-1);
        quick_sort( array, pivot + 1, end);
    }

    }
