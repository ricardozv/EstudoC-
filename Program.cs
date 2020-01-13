using System;

namespace Pagueveloz
{
    class Program
    {
        static void Main(string[] args)
        {
            // ========== Programinha de notas ============ //
            double nota1, nota2, nota3, nota4 = 0;
            string frase = "Digite a {0} nota: ";

            Console.WriteLine(frase, 1);
            nota1 = Convert.ToDouble (Console.ReadLine() );

            Console.WriteLine(frase, 2);
            nota2 = Convert.ToDouble( Console.ReadLine() );

            Console.WriteLine(frase, 3);
            nota3 = Convert.ToDouble( Console.ReadLine() );

            Console.WriteLine(frase, 4);
            nota4 = Convert.ToDouble( Console.ReadLine() );

            double total, media = 0;
            total = nota1 + nota2 + nota3 + nota4;
            media = total / 4;
            
            Console.WriteLine("A média foi: " + media);



        }
    }
}
