// problem link
// https://www.codechef.com/problems/HCAGMAM1


using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		int t = int.Parse(Console.ReadLine());
		while(t-- > 0){
		    string val = Console.ReadLine();
		    
		    string[] parts = val.Split(' ');
		    
		    int x = int.Parse(parts[0]);
		    int y = int.Parse(parts[1]);
		    
		    string str = Console.ReadLine();
		    
		    long max_val = 0, count = 0, c1 = 0;
		    
		    foreach(char i in str){
		        if(i == '1'){
		            count++;
		            c1++;
		        }else{
		            c1 = 0;
		        }
		        
		        if(c1 > max_val){
		            max_val = c1;
		        }
		    }
		    
		    max_val = (x*count) + (y*max_val);
		    
		    Console.WriteLine(max_val);
		}
	}
}



