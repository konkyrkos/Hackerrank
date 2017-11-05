using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        decimal meal = Convert.ToDecimal(Console.ReadLine());             
        decimal tip = Convert.ToDecimal(Console.ReadLine());
        decimal tax = Convert.ToDecimal(Console.ReadLine());
        decimal total = meal + (decimal)meal*tip/100 + (decimal)meal*tax/100;
        int output = (int)Math.Round(total, MidpointRounding.AwayFromZero);
        Console.WriteLine("The total meal cost is "+output+" dollars.");
    }
}