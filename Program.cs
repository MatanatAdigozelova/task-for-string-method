using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.String Equals methodu kimi method yazmaq algoritmini
            //2.Length in algoritmini method seklinde yaz
            //3.Contains
            //4.IsNullOrEmpty nin algoritmi

            //-----------------------------------------------

            //Taks1(Equal)

            //string equal = Console.ReadLine();
            //string equal2 = Console.ReadLine();
            //Console.WriteLine(Equal(equal, equal2));



            //-------------------------------

            //Task2(length metodu)

            //string length = Console.ReadLine();

            //Length(length);

            //----------------
            //3

            string word = Console.ReadLine();
            string word2 = Console.ReadLine();
            Contains(word,word2);



        }
        //1
        static bool Equal(string word, string word2)
        {
            if (word == word2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //2
        static void Length(string l)
        {

            int count = 0;



            foreach (var item in l)
            {
                count++;

            }
            Console.WriteLine(count);
        }
        //3

        static void Contains(string c,string a)
        {

            string empty = "";

            for(int i = 0; i < c.Length; i++)
            {
               empty += c[i];

                if (empty == a)
                {
                    
                    break;
                    
                }
                else
                {
                    Console.WriteLine("BU hal sehvdir");
                }

            }
            Console.WriteLine("bu hal duzdur");


        }


        
}   }
