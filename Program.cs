using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Operando: ");
         int Operando1=Convert.ToInt32(Console.ReadLine());
        
         Console.WriteLine("Operador: ");
         string operador=Convert.ToString(Console.ReadLine());

         Console.WriteLine("Operando: ");
         int Operando2=Convert.ToInt32(Console.ReadLine());

         String suma= "+";
         string resta= "-";
         string multiplicacion= "*";
         string division= "/";
         
        if (operador == suma)
        {
            int resultado= Operando1 + Operando2;
            Console.WriteLine(Operando1 + operador + Operando2 + " =" + resultado);
        }
        if (operador == resta)
        {
            int resultado= Operando1 - Operando2;
            Console.WriteLine(Operando1 + operador + Operando2 + " =" + resultado);
        }
        if (operador == multiplicacion)
        {
            int resultado= Operando1 * Operando2;
            Console.WriteLine(Operando1 + operador + Operando2 + " =" + resultado);
        }
        if (operador == division)
        {
            int resultado= Operando1 / Operando2;
            Console.WriteLine(Operando1 + operador + Operando2 + " =" + resultado);
        }

        }
    }
}
