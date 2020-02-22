using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aitividade_4._1
{
    class Program
    {
        struct rfunc
        {
            public int rgfunc;
            public string nome;
            public string cargo;
            public double sal;
        }
        static void Main(string[] args)
        {
           rfunc[] vfunc = new rfunc [20];
            int N;
            Console.Write("digite o valor de pessoas na empresa:");
            N = int.Parse(Console.ReadLine());
            valida(ref N,20);
            cadastrar(vfunc, N);
            exibirtodos(vfunc, N);
            acima5000(vfunc, N);
            Console.ReadKey();

        }
        static void valida (ref int N, int max)
        {
            while (N<1 || N>max)
            {
                Console.Write("digite o numero novamente");
                N = int.Parse(Console.ReadLine());
            }
        }
        static void cadastrar (rfunc [] f, int N )
        {
            for (int i=0; i<N; i++)
            {
                Console.Write("digite o rg");
                f[i].rgfunc= int.Parse(Console.ReadLine());
                Console.Write("digite o nome");
                f[i].nome=Console.ReadLine();
                Console.Write("digite o cargo");
                f[i].cargo=Console.ReadLine();
                Console.Write("digite o salario");
                f[i].sal= double.Parse(Console.ReadLine());
            }
        }
        
        static void exibirtodos (rfunc[] f, int N)
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write("\nRg:{0}", f[i].rgfunc);
                Console.Write("\nNome:{0}", f[i].nome);
                Console.Write("\ncargo:{0}", f[i].cargo);
                Console.Write("\nsalario:", f[i].sal);
            }
        }

        static void acima5000 (rfunc[] f, int N)
        {
            Console.Write("pessoas com salario acima de R$5000");
            for (int i = 0; i < N; i++)
            {
                if (f[i].sal>5000)
                {

                    Console.Write("{0}",f[i].nome);
                    Console.Write("{0}", f[i].cargo);
                    Console.Write("{0}", f[i].sal);
                }
            }
        }
    }
}
