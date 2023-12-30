using System;

namespace ProjRelogio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Relógio Digital!");

            Console.WriteLine("Aguardando ação do usuário... Aperte qualquer tecla!");

            Console.ReadKey();

            Console.WriteLine("Insira uma quantidade em segundos para o cronônetro...");

            int varTempSeg = int.Parse(Console.ReadLine());

            Console.WriteLine("O tempo a ser percorrido é de " + varTempSeg + " segundo(s).\n\n");
            Thread.Sleep(1000);
            Console.WriteLine("O cronômetro já vai começar...");
            Thread.Sleep(2000);
            Console.Clear();

            int varHora = 0, varMin = 0, varSeg = 0, segCont = 0;
            bool onOff = true;

            while (onOff == true)
            {
                do
                {
                    varSeg++;
                    segCont++;

                    if (varSeg < 60)
                    {
                        Console.Clear();
                        Console.WriteLine(varHora + ":" + varMin + ":" + varSeg);
                        Thread.Sleep(1000);
                    }
                    else if (varSeg == 60)
                    {
                        Console.Clear();
                        varSeg = 0;
                        varMin++;
                        Console.WriteLine(varHora + ":" + varMin + ":" + varSeg);
                    }
                    else if (varMin == 59)
                    {
                        Console.Clear();
                        varSeg = 0;
                        varMin = 0;
                        varHora++;
                        Console.WriteLine(varHora + ":" + varMin + ":" + varSeg);
                    }

                } while (segCont < varTempSeg);

                onOff = false;
            }

            Thread.Sleep(2000);
            Console.WriteLine("\n\nO cronômetro atingiu o tempo definido pelo usuário!");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Aperte qualquer tecla para encerrar o programa...");
            Console.ReadKey();
            Console.Clear();
            

        }

    }
}