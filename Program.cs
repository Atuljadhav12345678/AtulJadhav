using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

   public interface IA /*abstraction - To show the data which is  relevent  like return Type,methodname and parametrs ,*//*Design  phase*/
    {/*This is your abstraction phase */
      void  MethodName();
        
    }

    public class A:IA /*this one is Encapsulate beccause we are writting the code in this derived class*/ /*code implementation phase*/
    {
      public   void MethodName()
        {
            Console.WriteLine("This is you encapsulation which is implemnting the interface ");

        }

    }
}
