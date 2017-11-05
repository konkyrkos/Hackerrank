using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, int> d = new Dictionary<string, int>();
        for(int i=0; i<n; i++)
        {
            string[] ar_temp = Console.ReadLine().Split(' ');
            string name = ar_temp[0];
            int phone = Convert.ToInt32(ar_temp[1]);
            d.Add(name, phone);
        }
        string input = Console.ReadLine();
        while(input !=null)
        {            
           if (d.ContainsKey(input) == true)
           {
	           Console.WriteLine(input+"="+d[input]);
           }else
           {
              Console.WriteLine("Not found");
           }
            input = Console.ReadLine();
        }
    }
}