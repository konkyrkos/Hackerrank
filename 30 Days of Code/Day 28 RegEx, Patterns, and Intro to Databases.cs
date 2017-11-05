using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Solution {

    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        var nameList = new List<string>();
        for(int a0 = 0; a0 < N; a0++){
            string[] tokens_firstName = Console.ReadLine().Split(' ');
            string firstName = tokens_firstName[0];
            string emailID = tokens_firstName[1];
            if(Regex.IsMatch(emailID, @".+@gmail\.com$"))  nameList.Add(firstName);                      
        }
        nameList.Sort();
        foreach(var a in nameList){
            Console.WriteLine(a);
        }
    }
}