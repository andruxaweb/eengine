using System;

namespace eengine
{
    class Program
    {
        static void Main(string[] args)
        {
            StarThePorog();
            OneMoreTime();

                //Console.ReadLine();


        }
        public static void StarThePorog()
        {
            Console.Write("Prosze podać rozmiar tablicy:");
            int elementsCount = int.Parse(Console.ReadLine());
            string[] myArr = new string[elementsCount];

            for (int i = 0; i < myArr.Length; i++)
            {
                Console.Write($"Prosze wpisać liczbę do tablicy:");
                string setStrdane= Console.ReadLine();
                if(setStrdane == "" || setStrdane == " " || setStrdane == null)
                {
                    Console.Write("Wprowadzona niepoprawna wartość ! ");
                    Console.ReadLine();
                    //Environment.Exit(0);
                    StarThePorog();
                }
                else
                {
                    myArr[i] = setStrdane;
                }

            }

            Console.Write("Dane w tablice:");
            for (int i = 0; i < myArr.Length; i++)
            {

                if (i == myArr.Length - 1) Console.WriteLine(myArr[i] + ";");
                else Console.Write(myArr[i] + ", ");
            }
            
            Console.Write("parzyste:");
            for (int i = 0; i < myArr.Length; i++)
            {
                if (Convert.ToInt32(myArr[i]) % 2 == 0)
                {
                    Console.Write(myArr[i] + " ");
                }

            }
            Console.Write("; Nie parzyste:");
            for (int i = 0; i < myArr.Length; i++)
            {
                if (Convert.ToInt32(myArr[i]) % 2 == 1)
                {
                    Console.Write(myArr[i] + " ");
                }
            }
            Console.Write(";");
            int sumOfNum = 0;
            Console.WriteLine();
            for (int i = 0; i < myArr.Length; i++)
            {
                sumOfNum += Convert.ToInt32(myArr[i]);

            }
            Console.WriteLine("suma liczb = " + sumOfNum);
            if (sumOfNum % 2 == 0)
            {
                Console.WriteLine("suma liczb jest parzysta ");
            }
            else
            {
                Console.WriteLine("suma liczb jest nie parzysta ");
            }
        }
        public static void OneMoreTime()
        {
            Console.WriteLine("Sprobować jeszcze raz?");
            string oneMoreTime = Console.ReadLine();
            if (oneMoreTime == "y" || oneMoreTime == "Y")
            {
                StarThePorog();
                Console.ReadLine();
            }
            else if (oneMoreTime == "n" || oneMoreTime == "N")
            {
                Console.Write("Koniec");
            }
        }
    }
}
