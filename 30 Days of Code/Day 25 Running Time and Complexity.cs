using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int T=Int32.Parse(Console.ReadLine());
        for(int i=0; i<T; i++){
            bool isPrime = true;
            int num = Int32.Parse(Console.ReadLine());
            int sqrt = (int) Math.Sqrt((double)num);
            if(num == 1) {
                Console.WriteLine("Not prime");
                isPrime = false;
            }
            for(int j = 2; j <= sqrt; j++) {
                if(num % j == 0) {
                    Console.WriteLine("Not prime");
                    isPrime = false;
                    break;
                }
            }
            if(isPrime)  Console.WriteLine("Prime");
        }
    }      
}