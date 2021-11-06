using System;

namespace Calentando
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "";
            Console.Write("Escriba una horacion: ");
            x = Console.ReadLine();

            string[] texto = x.Split(' ');
            string palabra;
            string signos = " ";
            bool pass = false;
            
            for (int i = 0; i < texto.Length ; i++)
            {
                signos = "";
                palabra = texto[i];
                for (int j = palabra.Length - 1; j >= 0 ; j--)
                {
                    if (palabra[j] == '.' || palabra[j] == ',' || palabra[j] == ';' || palabra[j] == ':')
                    {
                        signos = Convert.ToString(palabra[j]);
                        pass = true;
                    }
                    else
                    {
                        Console.Write(palabra[j]);
                    }                    
                }
                if (pass)
                {
                    Console.Write(signos);
                }
                Console.Write(" ");
            }

        }
    }
}
