using System;

namespace LearningCSharp 
    {
        class Program
            {
                static void Main(string[] args)
                    {
                        Home();
                    }

                static async void Home()
                {
                    Console.WriteLine("++++++++ CALCULADORA ++++++++");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Qual operação deseja realizar? (Digite o número relacionado com a operação)");
                    Console.WriteLine("1- Adição");
                    Console.WriteLine("2- Subtração");
                    Console.WriteLine("3- Multiplicação");
                    Console.WriteLine("4- Divisão");
                    short res = short.Parse(Console.ReadLine());
                    switch(res) {
                        case 1: Soma(); break;
                        case 2: Subtração(); break;
                        case 3: Multiplicação(); break;
                        case 4: Divisão(); break;
                        default: Erro(); break;
                    }
                }
                static void Soma()
                {
                    Console.Clear();

                    Console.WriteLine("Digite o primero valor: ");
                    float value1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo valor");
                    float value2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

                    float result = value1 + value2;

                    Console.WriteLine($"O resultado da soma entre {value1} e {value2} é {result}");

                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

                }

                static void Subtração()
                {
                    Console.Clear();

                    Console.WriteLine("Digite o primero valor: ");
                    float value1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo valor");
                    float value2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

                    float result = value1 - value2;

                    Console.WriteLine($"O resultado da subtração entre {value1} e {value2} é {result}");

                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

                }

                static void Multiplicação()
                {
                    Console.Clear();

                    Console.WriteLine("Digite o primero valor: ");
                    float value1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo valor");
                    float value2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

                    float result = value1 * value2;

                    Console.WriteLine($"O resultado da multiplicação entre {value1} e {value2} é {result}");

                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

                }

                static void Divisão()
                {
                    Console.Clear();

                    Console.WriteLine("Digite o primero valor: ");
                    float value1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo valor");
                    float value2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

                    float result = value1 / value2;

                    Console.WriteLine($"O resultado da divisão entre {value1} e {value2} é {result}");

                    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

                }

                static async void Erro()
                {
                    Console.WriteLine("Esse valor não corresponde a nenhuma operação. Tente novamente");
                    Task.Delay(2000).Wait();
                    Home();
                }
            }
    }