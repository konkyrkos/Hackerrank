using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i=0; i<n; i++)
        {
            string s = Console.ReadLine();
            string s1 = "";
            string s2 = "";
            for(int j=0; j<s.Length; j++)
            {
                if(j==0)
                {
                    s1 +=s[j];
                }else if(j%2==0)
                {
                    s1 +=s[j];
                }else
                {
                    s2 +=s[j];
                }
            }
            Console.WriteLine(s1+" "+s2);
        }
    }
}