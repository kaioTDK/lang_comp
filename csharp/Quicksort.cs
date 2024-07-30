using System.Security.Cryptography.X509Certificates;

class QuickSort{
public static void Quicksort(uint[] arr){
    uint find_pivot(int[] arr, uint start, uint end) {
        var rand = new Random();
        var index = (uint)rand.Next(((int)start),(int)end);
        return index;
    } 
    void quick_sort(int[] arr){
        
        var pivot = find_pivot(arr,0,(uint)arr.Length);
        
    }

    }
}