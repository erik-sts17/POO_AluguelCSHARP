using System;

namespace Exercicio_Vetor1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de um vetor da classe estudante de 10 posições.
            Estudante[] quartos = new Estudante[10];
            Console.WriteLine("Quantidade de estudantes: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nAluguel#{i}: ");

                Console.Write("\nDigite o quarto desejado: ");
                int numero = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o E-mail: ");
                string email = Console.ReadLine();

                //Criação do objeto no vetor de indíce(Quarto) escolhido pelo usuário;
                quartos[numero] = new Estudante(nome, email);
                Console.WriteLine("Quarto {0} alugado para {1}", numero, nome);

            }





            Console.WriteLine("\nQuartos ocupados: ");

            {
                for (int i = 0; i < quartos.Length; i++)
                {
                    if (quartos[i] != null)
                    {
                        Console.WriteLine(i + " " + quartos[i]);

                    }
                }


            }
        }
    }
}


