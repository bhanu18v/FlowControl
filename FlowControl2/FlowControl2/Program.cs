﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing)
              {
                Console.Clear();
                Console.WriteLine("This is the main menu.");
                Console.WriteLine("Input number to choose function");
                Console.WriteLine("0) Exit");
                string input = Console.ReadLine();
                                switch (input)
                                    {
                                     case "0":
                                     keepGoing = false;
                                     break;
                                     default:
                    Console.WriteLine("Incorrect choice \nPlease input again");
                    Console.ReadKey();
                                     break;
                                  }
                
           }
        }
      
    }
}
