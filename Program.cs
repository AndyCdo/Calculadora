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

         string suma= "+";
         string resta= "-";
         string multiplicacion= "*";
         string division= "/";
         int resultado= 0;
        if (operador == suma)
        {
           resultado= sumar(Operando1, Operando2);
        }
        else if (operador == resta)
        {
            resultado= restar(Operando1, Operando2);
        }
        else if (operador == multiplicacion)
        {
            resultado= multiplicar(Operando1, Operando2);
        }
        else if (operador == division)
        {
            resultado= dividir(Operando1, Operando2);
        }
        
        Console.WriteLine(Operando1 + (" ") + operador + (" ") + Operando2 + " = " + resultado);

        }
        static int sumar(int num1, int num2 ){
           int resultado= (num1 + num2);
            return resultado;
        }
        static int restar(int num1, int num2 ){
           int resultado= (num1 - num2);
            return resultado;
        }
        static int multiplicar(int num1, int num2 ){
           int resultado= (num1 * num2);
            return resultado;
        }
        static int dividir(int num1, int num2 ){
           int resultado= (num1 / num2);
            return resultado;
        }
    }
}
