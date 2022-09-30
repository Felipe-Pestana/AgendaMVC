using Controllers;
using Models;
using System;
using System.Collections.Generic;

namespace ProjAgendaMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agenda Telefonica");

            Contato c = new()
            {
                Nome = "Baratao",
                Telefone = "1234567890"
            };

            new ContatoController().InserirContato(c);

            List<Contato> l = new ContatoController().ConsultaTodos();

            foreach (var item in l)
            {
                Console.WriteLine(item.ToString());
            }
        }
        
    }
}
