using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        int ns = 0;
        int temp;
        for(int i=0; i<n; i++){
            for(int j=0; j<n-1; j++){
                if(a[j]>a[j+1]){
                    temp=a[j+1];
                    a[j+1]= a[j];
                    a[j]=temp;
                    ns++;
                }
            }
            if(ns==0){
                break;
            }
        }
        Console.WriteLine("Array is sorted in "+ns+" swaps.");
        Console.WriteLine("First Element: "+a[0]);
        Console.WriteLine("Last Element: "+a[n-1]);
    }
}
