using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operators {
   class LINQQueryExpressions { 
      static void Main() {
         // Specify the data source.
         int[] scores = new int[] { 97, 92, 81, 60 };

         // Define the query expression.
         //IEnumerable<int> scoreQuery = from score in scores where score > 80 select score;
           IEnumerable<int> scoreQuery = scores.Where(score => score>80);

         // Execute the query.
		 
         foreach (int i in scoreQuery) {
            Console.Write(i + " ");
         }
		 
         Console.ReadLine();
      }
   }
}