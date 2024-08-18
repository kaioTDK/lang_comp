using static System.IO.Path;
using static System.Console;
using static System.IO.File;
using System.Linq;
public class LoadArrays{
    public static int[]  GetArray(int lenght){
        try {
            var file_path = @"../util/arrays.txt";
            string[] file_cont = ReadAllLines(file_path);
            int[] int_array = [];
            string line_array = "";
            for ( int i = 0; i < file_cont.Length; i++){
                if (file_cont[i].Contains("Array of "+lenght+" = [")){
                    line_array = file_cont[i];
                    break;
                }
            }
            line_array = line_array.Substring(line_array.IndexOf('[') + 1);
            line_array = line_array.Remove(line_array.Length - 1);
            
            int_array = line_array.Split(',').Select(int.Parse).ToArray();
            return int_array;
        }
        catch (IOException e) {

            throw;
        }
        
        
    }

}