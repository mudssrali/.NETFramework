using System;
using System.Linq;

class Program {
   static void Main() {
      string[] words = {"hello", "wonderful", "LINQ", "beautiful", "world"};
		
      //Get only short words
    int a = 5;
      var shortWords = from word in words where word.Length <= a select word;
	  //delegate string mydel (string str){return str;};
      //var longWords = words.Where( w => w.length > 10);
     /* 
    //  var longwords = from w in words where w.length <= 5;
      //Dim longwords = from w in words where w.length > 10;

      //Lambda Expression
      var longWords = words.Where( w ⇒ w.length > 10);
      Dim longWords = words.Where(Function(w) w.length > 10);
      //Compression Method
      */
      Console.WriteLine(shortWords.Max());
      //Print each word out
      foreach (var word in shortWords) {
         Console.WriteLine(word);
      }	 
		
      Console.ReadLine();
   }
}