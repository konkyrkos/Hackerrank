using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        string message="";
        if(N%2!=0)
        {
            message = "Weird";
        }else
        {
            if(N<=5 && N>=2)
            {
                message = "Not Weird";
            }else if(N>=6 && N<=20)
            {
                message = "Weird";
            }else if(N>20)
            {
                 message = "Not Weird";
            }
        }
        Console.WriteLine(message);
    }
}