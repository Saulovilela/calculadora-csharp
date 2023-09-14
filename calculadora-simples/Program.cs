using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado = 0;

            Console.WriteLine("Carregando...");
            Console.WriteLine(@"

--                      ###                        ###                 ###
--                       ##                         ##                  ##
--    ####     ####      ##      ####    ##  ##     ##      ####        ##    ####    ######    ####
--   ##  ##       ##     ##     ##  ##   ##  ##     ##         ##    #####   ##  ##    ##  ##      ##
--   ##        #####     ##     ##       ##  ##     ##      #####   ##  ##   ##  ##    ##       #####
--   ##  ##   ##  ##     ##     ##  ##   ##  ##     ##     ##  ##   ##  ##   ##  ##    ##      ##  ##
--    ####     #####    ####     ####     ######   ####     #####    ######   ####    ####      #####

--    #####    ####    ##   ##  ######   ####     #######   #####
--   ##   ##    ##     ### ###   ##  ##   ##       ##   #  ##   ##
--   #          ##     #######   ##  ##   ##       ## #    #
--    #####     ##     #######   #####    ##       ####     #####
--        ##    ##     ## # ##   ##       ##   #   ## #         ##
--   ##   ##    ##     ##   ##   ##       ##  ##   ##   #  ##   ##
--    #####    ####    ##   ##  ####     #######  #######   #####

"
            );
            // Solicita o primeiro número e lê como um inteiro
            Console.WriteLine("Digite o primeiro número: ");
            numero1 = LerNumeroInteiro(); //metodo que coloquei abaixo

            // Lê a operação do usuário
            string operacao = LerOperacao(); //metodo está abaixo

            // Solicita o segundo número e lê como um inteiro
            Console.WriteLine("Digite o segundo número: ");
            numero2 = LerNumeroInteiro();

            // Realiza a operação selecionada e obtém o resultado
            resultado = RealizarOperacao(operacao, numero1, numero2); //metodo abaixo

            // Verifica se é uma divisão e se o divisor não é zero
            if (operacao == "/" && numero2 != 0)
            {
                // Calcula o resultado da divisão como um número decimal
                double resultadoDecimal = (double)numero1 / numero2;

                // Exibe o resultado formatado
                Console.WriteLine("{0} {1} {2} = {3}", numero1, operacao, numero2, resultadoDecimal);
            }
            else
            {
                // Exibe o resultado das outras operações
                Console.WriteLine("{0} {1} {2} = {3}", numero1, operacao, numero2, resultado);
            }

            // Aguarda uma tecla ser pressionada antes de finalizar o programa
            Console.ReadKey(true);
        }

        // Método para ler um número inteiro e validações 
        static int LerNumeroInteiro()
        {
            int numero;

            // Continua pedindo um número até que uma entrada válida seja fornecida
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Número inválido. Digite novamente: ");
            }

            return numero;
        }

        // Método para ler uma operação e validações
        static string LerOperacao()
        {
            string operacao;

            // Continua pedindo uma operação até que uma operação válida seja fornecida
            while (true)
            {
                Console.WriteLine("Digite a operação (+, -, *, /): ");
                operacao = Console.ReadLine();

                // Verifica se a operação é válida, se sim, sai do loop, senão exibe uma mensagem de erro e volta
                if (operacao == "+" || operacao == "-" || operacao == "*" || operacao == "/")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Operação inválida. Apenas operações são permitidas.");
                }
            }

            return operacao;
        }

        // Método para realizar operações para validações
        static int RealizarOperacao(string operacao, int num1, int num2)
        {
            switch (operacao)
            {
                case "+": return num1 + num2;
                case "-": return num1 - num2;
                case "*": return num1 * num2;
                case "/":
                    if (num2 != 0)
                    {
                        return num1 / num2;
                    }
                    else if (num1 !=0)
                    {
                        return num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Divisão por zero não é permitida.");
                        return int.MinValue;
                    }
                default:
                    Console.WriteLine("Operação inválida!");
                    return int.MinValue;
            }
        }
    }
}
