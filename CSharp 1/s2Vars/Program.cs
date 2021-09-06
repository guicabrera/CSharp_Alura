using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace s2Vars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo a aula de criação de variáveis");

            //Vars do tipo integer
            int peso = 88;
            int imc;

            imc = peso / 2;

            Console.WriteLine("Seu IMC é o: " + imc + "!");


            //Vars flutuantes --> Double
            double peso2 = 75.9;
            double altura = 1.88;
            double imc2;

            imc2 = peso2 / altura;
            Console.WriteLine("\n Seu peso é: " + peso2 + "\n Sua altura é: " + altura + "\n Seu IMC é: " + imc2);
            
            //verificando com valores int
            peso2 = (double)peso;
            altura = 2;
            imc2 = peso2 / altura;
            Console.WriteLine("\n Seu peso é: " + peso2 + "\n Sua altura é: " + altura + "\n Seu IMC é: " + imc2);

            //A3 - casting e outros tipos de número
            long nGrande;
            int nMedio;
            short nPequeno;
            
            nPequeno = 9999;
            nMedio = 999999999;
            nGrande = 999999999999999999;

            Console.WriteLine("\nThis is a 16 bits numbe: " +nPequeno+"\nThis is a 32 bits number: "+nMedio+"\nThis is a 64 bits numer: "+nGrande);

            Console.ReadLine();
        }
    }
}
