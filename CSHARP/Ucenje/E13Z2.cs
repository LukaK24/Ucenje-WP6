﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Z2
    {
        public static void Izvedi() 
        {
            //Console.WriteLine("Bok");
            Zad1();
        }
        private static void Zad1() 
        {
            Console.WriteLine("Dobro došli u 1 zadatak");
            string ime;
            while (true)
            {
                 ime = E12Metode.UcitajString("Unesi ime osobe (NE za kraj):");
                if (ime.ToUpper()== "NE") 
                {
                    Console.WriteLine("Hvala na korištenju programa 1. zadatak!");
                    break;
                }
            }
            Console.WriteLine(ime.Length);
        }
    }
}