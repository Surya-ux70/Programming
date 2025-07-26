/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
	static void Main() {
		Console.WriteLine("Enter the number: ");
		string input = Console.ReadLine();
		int n = int.Parse(input);
		for(int i=1;i<n;i++){
		    bool ans = checkAms(i);
		    if(ans){
		        Console.Write(i + " ");
		    }
		}
    }
    public static bool checkAms(int n) {


			int final =n;
			int finalsum = n;
			int c =1;
			while(n>9) {
				n /= 10;
				c++;
			}
			double sum = 0;
			while(final>0) {
				int rem = final%10;
				double ams = Math.Pow((double)rem, (double)c);
				sum += ams;
				final /= 10;
			}

			if(finalsum == sum) {
				return true;
			}
			return false;
		
		/*public static int rootPower(int p, int c){
		    int pro = 1;
		    for(int i=0;i<c;i++){
		        pro *= p;
		    }
		    return pro;*/
	}
}
