using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Exercise1
{
    class Class2
    {

        public void Print5Values(string [] words)
        {
            Console.WriteLine("The First five words are: ");
         
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(words[i]);
            }
            

        }

        public void SmallestNumber(int [] numbers)
        {
            Array.Sort(numbers);
            int res = numbers[0];
            Console.WriteLine("The smallest number is: " + res);

        }

        public void Dictionary()
        {
            Dictionary<string, string> Holidays = new Dictionary<string, string>();
            Holidays.Add("Memorial Day", "2019-05-27");
            Holidays.Add("Independence Day", "2019-07-04");
            Holidays.Add("Labor Day", "2019-09-02");
            Holidays.Add("Mexican Independence Day", "2019-09-16");
            Holidays.Add("Thanksgiving Day", "2019-11-28");
            Holidays.Add("Christmas Day", "2019-11-29");

            foreach (KeyValuePair<string, string> holiday in Holidays)
            {
                Console.WriteLine("Holiday" + '\t'+ holiday.Key + '\t' + holiday.Value);
            }
           
        }

    }
}
