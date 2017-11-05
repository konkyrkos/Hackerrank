using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();
        try   
        {  
            int i= Int32.Parse(S);
            Console.WriteLine(i);
        }  
        catch  
        {
            Console.WriteLine("Bad String");
        }  
    }
}