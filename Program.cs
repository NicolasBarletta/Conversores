using System;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual tipo de conversor deseja usar?");
            Console.WriteLine("1) Conversor de Medidas");
            Console.WriteLine("2) Conversor de Moedas");
            Console.WriteLine("3) Conversor de Peso");
            Console.WriteLine("4) Sair");
            int conversor = Convert.ToInt32(Console.ReadLine());

            switch (conversor)
            {

                case 1:

                    Console.WriteLine("1) Métricas");
                    Console.WriteLine("2) Volumétricas");
                    Console.WriteLine("3) Voltar ao Menu Principal");

                    int medidas = Convert.ToInt32(Console.ReadLine());
                   
                    if (medidas == 1) {
                        Console.WriteLine("1) Metros para Centímetro");
                        Console.WriteLine("2) Centímetro para Metros");
                        Console.WriteLine("3) Voltar ao Menu Principal");
                        int metricas = Convert.ToInt32(Console.ReadLine());

                        if (metricas == 1)
                        {
                            Console.WriteLine("Quantos metros quer converter?");
                            double metro = Convert.ToDouble(Console.ReadLine());
                            double Cmetro = metro * 100;
                            Console.WriteLine("O Resultado é: " + Cmetro + " cm");

                        }
                        else if (metricas == 2)
                        {
                            Console.WriteLine("Quantos centímetros quer converter?");
                            double cm = Convert.ToDouble(Console.ReadLine());
                            double Ccm = cm / 100;
                            Console.WriteLine("O Resultado é: " + Ccm + " cm");

                        }
                        else if (metricas == 3)
                        {

                        }
                        else
                        {
                            Console.WriteLine("Comando Inválido!");

                        }
                        Console.ReadKey();
                    }
                    else if (medidas == 2) {
                        Console.WriteLine("1) Litros para Mililitros");
                        Console.WriteLine("2) Mililitros para Litros");
                        Console.WriteLine("3) Voltar ao Menu Principal");
                        int volumetricas = Convert.ToInt32(Console.ReadLine());

                        if (volumetricas == 1)
                        {
                            Console.WriteLine("Quantos litros quer converter?");
                            double litros = Convert.ToDouble(Console.ReadLine());
                            double ML = litros * 1000;
                            Console.WriteLine("O Resultado é: " + ML + " mililitros");

                        }
                        else if (volumetricas == 2)
                        {
                            Console.WriteLine("Quantos mililitros quer converter?");
                            double mili = Convert.ToDouble(Console.ReadLine());
                            double L = mili / 1000;
                            Console.WriteLine("O Resultado é: " + L + " litros");

                        }
                        else if (volumetricas == 3)
                        {
                        
                        }
                        else
                        {
                            Console.WriteLine("Comando Inválido!");

                        }
                        
                    }
                    else if (medidas == 3) {

                    }
                    Console.ReadKey();
                    break;



                     case 2:

                    Console.WriteLine("1) Dolar");
                    Console.WriteLine("2) Euro");
                    Console.WriteLine("3) Voltar ao Menu Principal");

                    int moeda = Convert.ToInt32(Console.ReadLine());

                    if (moeda == 1)
                    {
                        Console.WriteLine("1) Dolar para Real");
                        Console.WriteLine("2) Real para Dolar");
                        Console.WriteLine("3) Voltar ao Menu Principal");
                        int opcaoM = Convert.ToInt32(Console.ReadLine());

                        if (opcaoM == 1)
                        {
                            Console.WriteLine("Quantos Dólares quer converter?");
                            double dolares = Convert.ToDouble(Console.ReadLine());
                            double RDolares = dolares * 5.31;
                            Console.WriteLine("O valor convertido é U$" + RDolares);
                        }
                       else if (opcaoM == 2)
                        {
                            
                            Console.WriteLine("Quantos Reais quer converter?");
                            double reais = Convert.ToDouble(Console.ReadLine());
                            double DReais = reais / 5.31;
                            Console.WriteLine("O valor convertido é U$" + DReais);
                        }
                       else if (opcaoM == 3)
                        {
                            
                        }
                        else
                        {
                            Console.WriteLine("Comando Inválido!");

                        }

                    }

                    else if (moeda == 2)
                    {
                        Console.WriteLine("1) Euro para Real");
                        Console.WriteLine("2) Real para Euro");
                        Console.WriteLine("3) Voltar ao Menu Principal");
                        int opcaoM1 = Convert.ToInt32(Console.ReadLine());

                        if (opcaoM1 == 1)
                        {
                            Console.WriteLine("Quantos Euros quer converter?");
                            double euros = Convert.ToDouble(Console.ReadLine());
                            double Reuros = euros * 6.48;
                            Console.WriteLine("O valor convertido é U$" + Reuros);
                        }
                        if (opcaoM1 == 2)
                        {
                            Console.WriteLine("Quantos Reais quer converter?");
                            double reais1 = Convert.ToDouble(Console.ReadLine());
                            double EReais = reais1 / 6.48;
                            Console.WriteLine("O valor convertido é U$" + EReais);
                        }
                        if (opcaoM1 == 3)
                        {

                        }
                        
                    }
                    else if (moeda == 3) {

                    }
                     else {
                        Console.WriteLine("Comando Inválido!");
                    }
                    Console.ReadKey();
                    break;


                case 3:

                    Console.WriteLine("1) Quilo para Grama");
                    Console.WriteLine("2) Grama para Quilo");
                    Console.WriteLine("3) Voltar ao Menu Principal");
                    int peso = Convert.ToInt32(Console.ReadLine());

                    if (peso == 1) {
                        Console.WriteLine("Quantos quilos quer converter?");
                        double quilos = Convert.ToDouble(Console.ReadLine());
                        double QG = quilos * 1000;
                        Console.WriteLine("O Resultado é: " + QG + " gramas");
                    }
                    else if (peso == 2) {
                        Console.WriteLine("Quantas gramas quer converter?");
                        double gramas = Convert.ToDouble(Console.ReadLine());
                        double GQ = gramas / 1000;
                        Console.WriteLine("O Resultado é: " + GQ + " quilos");
                    }
                    else if (peso == 3) {

                    }
                    else {
                        Console.WriteLine("Comando Inválido!");
                    }
                    Console.ReadKey();
                    break;
            }
            }
    }
}
