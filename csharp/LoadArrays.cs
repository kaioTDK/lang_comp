using static System.IO.Path;
using static System.Console;
using static System.IO.File;
using System.Linq;
public class LoadArrays{
    public static int[]  GetArray(){
        try {
            var file_path = @"../util/arrays.txt";
            string[] file_cont = ReadAllLines(file_path);
            file_cont = file_cont[0].Split('[');
            file_cont = file_cont.
             WriteLine(file_cont);
            int[] int_array = file_cont[0].Split(',').Select(int.Parse).ToArray();
            return int_array;
        }
        catch (IOException e) {throw e;}
        
        
    }

}