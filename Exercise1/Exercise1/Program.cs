using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Comparison between 2 words");
            Console.Write("Please enter the first word: ");
             string word1 = Console.ReadLine();
             Console.Write("Please enter the second word: ");
             string word2 = Console.ReadLine();
             Class1 obj1 = new Class1();
             Console.WriteLine(obj1.ComparisionWords(word1, word2));

            Console.WriteLine("Verify the biggest number in a list");
            int[] myArray = new int[5];
             int len1 = myArray.Length;
             int i;
            for (i = 0; i < len1; i++)
              {
                 Console.WriteLine("Enter the " + i + " number");
                   myArray[i] = Convert.ToInt32(Console.ReadLine());
               }
             Class1 obj2= new Class1();
              Console.WriteLine(obj2.BiggestNum(myArray));

            Console.WriteLine("Sort a list by asc and desc order");
            String[] myStrArray = new String[5];
              int len2 = myStrArray.Length;
              for (i = 0; i < len1; i++)
              {
                  Console.WriteLine("Enter the " + i + " word: ");
                  myStrArray[i] = Console.ReadLine();

              }
              Class1 obj3 = new Class1();
              obj3.SortList(myStrArray);


            Console.WriteLine("Count the length of a string"); 
              string word;
              Console.WriteLine("Enter the word: ");
              word = Console.ReadLine();
            Class1 obj4 = new Class1();
            Console.WriteLine("The length of a string: " + obj4.CountLenght(word));


            Console.WriteLine("Iterate trough a list and print the first 5 values");
            String[] myStrArray1 = new String[8];
            for (i = 0; i < 8; i++)
            {
                Console.WriteLine("Enter the " + i + " word: ");
                myStrArray1[i] = Console.ReadLine();

            }
            Class2 obj5 = new Class2();
            obj5.Print5Values(myStrArray1);

            Console.WriteLine("Iterate trough an Array and print the smallest number");
            int[] myArray1 = new int[5];
            int len3 = myArray1.Length;
            for (i = 0; i < len1; i++)
            {
                Console.WriteLine("Enter the " + i + " number");
                myArray1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Class2 obj6 = new Class2();
            obj6.SmallestNumber(myArray1);


            Console.WriteLine("Iterate trough a Dictionary and print the value based on the Key");
            Class2 obj7 = new Class2();
            obj7.Dictionary();
            Console.ReadLine();
        }
    }
}
