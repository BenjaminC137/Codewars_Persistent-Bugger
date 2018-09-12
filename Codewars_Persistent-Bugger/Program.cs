using System;

namespace Codewars_Persistent_Bugger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Persistence(39));

        }
           public static int Persistence(long n) 
        {
            int count;
            for(count = 0; n > 9; count ++){
                
                  var stringN = n.ToString();
                  n = 1;
                  
                  foreach(var number in stringN){
                  string numph = number.ToString();
                      int num = Int32.Parse(numph);
                      n *= num;
                  }   
            }
         return count;
        }        
        
    }
  
}
 