using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema
{
    class ConsoleUI

    {


        public string GetInput()

        {

            return Console.ReadLine();

        }



        public void Print(string message)

        {

            Console.WriteLine(message); 

        }

        public void Print()

        {

            Console.WriteLine();

        }
        public void PrintInRow(string message)

        {

            Console.Write(message);

        }

    }
}
