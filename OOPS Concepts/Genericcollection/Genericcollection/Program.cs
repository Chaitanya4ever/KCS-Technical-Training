using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CollectionGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region NonGenerics Collection

            ArrayList ArrL = new ArrayList();
            Queue Q = new Queue();
            Stack S = new Stack();

            ArrL.Add("Chaitanya");
            ArrL.Add(1);

            foreach (Object O in ArrL)
            {
                Console.WriteLine(O);
            }

            Q.Enqueue("Chaitanya");
            Q.Enqueue(2);

            foreach (Object O in Q)
            {
                Console.WriteLine(O);
            }

            S.Push("Chaitanya");
            S.Push(3);
            foreach (Object O in S)
            {
                Console.WriteLine(O);
            }

            #endregion

            #region Generics Collection

            List<Int32> IntegerGenericsExm = new List<Int32>();
            IntegerGenericsExm.Add(10);
            IntegerGenericsExm.AddRange(new int[] {  });

            foreach (int I in IntegerGenericsExm)
            {
                Console.WriteLine(I);
            }


            #endregion

            Console.ReadKey();
        }
    }
}
