using System;
using DESAFIO___PERSONAGENS.SRC.ENTITIES;

namespace DESAFIO___PERSONAGENS
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 35, "Knight");
            Wizard Jenica = new Wizard("Jenica", 28, "White Wizard");
            Knight Wedge = new Knight("Wedge", 46, "Ninja");
            Wizard Topapa = new Wizard ("Topapa", 37, "Black Wizard");
           
            Console.WriteLine(Arus.Attack());
            Console.WriteLine(Jenica.Attack());
            Console.WriteLine(Wedge.Attack());
            Console.WriteLine(Topapa.Attack());

        }
    }   
}