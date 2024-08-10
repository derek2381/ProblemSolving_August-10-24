// problem link
// https://codeforces.com/problemset/problem/1846/A


using System;

public class Solution{
    public static void Main(String[] args){
        int t = int.Parse(Console.ReadLine());
        
        while(t-- > 0){
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while(n-- > 0){
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');
                int x = int.Parse(parts[0]);
                int y = int.Parse(parts[1]);
                
                if(x-y > 0){
                    count++;
                }
            }
            
            Console.WriteLine(count);
        }
    }
}