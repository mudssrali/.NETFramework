using System;

public delegate int NumberChanger(Int32 num);
public delegate void MyPrinter(String str, Int32 num);
namespace DelegateAppl {
   
   class TestDelegate {
      static int num = 10;
      
      public static int AddNum(int p) {
         num += p;
         return num;
      }
      public static int MultNum(int q) {
         num *= q;
         return num;
      }
      public static int getNum() {
         return num;
      }
      public static void mySysOut(String str,Int32 num)
      {
          Console.WriteLine(str+num);
      }
      static void Main(string[] args) {
         //create delegate instances       
         NumberChanger nc1 = new NumberChanger(AddNum);
         NumberChanger nc2 = new NumberChanger(MultNum);
         // print delegate
         MyPrinter print  = mySysOut;
         //calling the methods using the delegate objects
         nc1(25);
         // Error
         //print("Value of Num: "+getNum());
         print("Value of Num: ",getNum());
         nc2(5);
         print("Value of Num: ",getNum());
         Console.ReadKey();
      }
   }
}