using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int[][] arr = new int[6][];
        for(int arr_i = 0; arr_i < 6; arr_i++){
           string[] arr_temp = Console.ReadLine().Split(' ');
           arr[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }
        var sums = new List<int>();
        for(int i=0; i<4; i++){
            for(int j=0; j<4; j++){
               sums.Add(arr[i][j]+arr[i][j+1]+arr[i][j+2]+arr[i+1][j+1]+arr[i+2][j]+arr[i+2][j+1]+arr[i+2][j+2]); 
            }
        }
        int max = int.MinValue;
        foreach(var a in sums){
            if(a>max){
                max=a;
            }
        }
        Console.WriteLine(max);
    }
}
