using System;
using System.Collections.Generic;

namespace Cinema
{
    class Program
    {
        static List<double> d = new List<double>();
        static int sum = 0;
        static int age;
        static ConsoleUI ui = new ConsoleUI();
        

        static void Main(string[] args)

        {

            do
            {

                ShowMenu();
                UserAction();

            } while (true);
        }

        private static void UserAction()
        {

            switch (ui.GetInput())
            {

                case "1":

                    CostCalculation();

                    break;
                case "2":

                    UseOfForLoop();
                    break;

                case "3":

                    StringSplit();

                    break;

                case "4":

                    Environment.Exit(0);

                    break;

            }
        }

        private static void StringSplit()
        {
            ui.Print("Anger en mening med minst 3 ord");
            string sentence = ui.GetInput();
            
            string[] arr = sentence.Split(" ");

            for (int i = 0; i < arr.Length;)
            {
                ui.Print(" Den tredje ordet är: " + arr[arr.Length - 1]);
                break;
            }

        }

        private static void UseOfForLoop()
        {

            ui.Print("Ange en text: ");
           
            string variabel = ui.GetInput();

            Console.WriteLine(variabel);
           
            for (int i = 1; i <= 10; i++)
            {

                ui.PrintInRow(i + ". " + variabel + ",");

            }
         ui.Print();

        }

        private static void CostCalculation()
        {

            ui.Print("Antal personer: ");
            int antalPersoner = int.Parse(ui.GetInput());
            string[] ageList = new string[antalPersoner];

            ui.Print("Key your ages");

            for (int i = 0; i < ageList.Length; i++)
            {


                //Populate the array
                ageList[i] = ui.GetInput();


            }

            foreach (string ageString in ageList)
            {
                age = int.Parse(ageString);

                if (age < 20)
                {
                    ui.Print("Ungdomspris: 80kr");
                    d.Add(Price.UngdomPris);

                }
                else if (age > 64)
                {
                    ui.Print("Pensionärspris: 90kr");
                    d.Add(Price.PensionPris);
                }
                else
                {
                    ui.Print("Standarprisen: 120kr");
                    d.Add(Price.StandarPris);
                }

            }

            foreach (int i in d)
            {

                sum += i;
            }

            ui.Print("Totalkostnad for hela sällskapet: " + sum);


        }

        private static void ShowMenu()
        {
            ui.Print("Welcome to the main menu");
            ui.Print("1: Beräkna kostnad på deltagare");
            ui.Print("2: Får for-loop till att upprepa saker för us ");
            ui.Print("3: Det tredje ordet från en mening");
            ui.Print("4: Exit the system");

        }
    }
}
