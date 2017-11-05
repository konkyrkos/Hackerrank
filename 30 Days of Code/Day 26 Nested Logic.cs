using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
class Solution {
    static void Main(String[] args) {
        var fine = 0;
        string []to = Console.ReadLine().Split(' ');
        var a = new int[3];
        for(int i=0; i<to.Length; i++){
            a[i] = Int32.Parse(to[i]);
        }
        string []frm = Console.ReadLine().Split(' ');
        var b = new int[3];
        for(int j=0; j<frm.Length; j++){
            b[j] = Int32.Parse(frm[j]);
        }
        if(a[2]>b[2]){
            fine += 10000;
        }else if(a[2]==b[2]){
            if(a[1]>b[1]){
                fine += (a[1]-b[1])*500;
            }else if(a[1]==b[1]){
                if(a[0]>b[0]){
                    fine += (a[0]-b[0])*15;
                }
            }
        }
        Console.WriteLine(fine);
    }
}