using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Class1
    {


        public string ComparisionWords(string word1, string word2)
        {
            string result;
            if (word1 == word2)
            {
                result="The two words are the same";
            }

            else
            {
                result = "The two words are not the same";
            }
            return result;

        }

        public int BiggestNum(int [] numbers)
        {
            int len1 = numbers.Length;
            int max = numbers[0];
            for (int i = 0; i < len1; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("The biggest number is: ");
            return max;

        }

        public void SortList(String [] words)
        {
            int len1 = words.Length;
            Array.Sort(words);
            Console.WriteLine("ASC ORDER");
            for (int i = 0; i < len1; i++)
            {
                Console.WriteLine(words[i]);
            }
            Array.Reverse(words);

            Console.WriteLine("DSC ORDER");
            for (int i = 0; i < len1; i++)
            {
                Console.WriteLine(words[i]);
            }
          
        }

        public int CountLenght(string Word)
        {
            
            int length = Word.Length;
            return length;
        }
    }
}
