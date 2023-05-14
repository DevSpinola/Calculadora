using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    //Classe que possui as operações que serão utilizadas no codigo
    internal class Operacoes
    {
        public double resultado;
        public double Adicao(double a, double b)
        {
            resultado = a + b;
            return resultado;
        }
        public double Subtracao(double a, double b)
        {
            resultado = a - b;
            
            return resultado;
        }
        public double Multiplicacao(double a, double b)
        {
            resultado = a * b;
            return resultado;
        }
        public double Divisao(double a, double b)
        {
            resultado = a / b;
            return resultado;
        }
        public double Potencia(double a, double b)
        {
            resultado = Math.Pow(a, b);
            return resultado;
        }       
    }
}
