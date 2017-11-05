using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;
	
	public Difference(int [] a){
        this.elements = a;
    }
    int first, second;
    public void computeDifference(){
        this.maximumDifference = 0;
        for(int i=0; i< this.elements.Length; i++){
            first = this.elements[i];
            for(int j=i+1; j<this.elements.Length; j++){
               second = this.elements[j];
                if(Math.Abs(first-second)>this.maximumDifference){
                    this.maximumDifference = Math.Abs(first-second);
                }
            }               
        }
    }
} 

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}