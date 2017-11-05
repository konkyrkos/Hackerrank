using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        int i2 =Convert.ToInt32(Console.ReadLine());
        decimal d2 = Convert.ToDecimal(Console.ReadLine());
        string s2 = Console.ReadLine();
        decimal d3 = (decimal)(d);
        Console.WriteLine(i+i2);
        Console.WriteLine(d3+d2);
        Console.WriteLine(s+s2);
	}
}