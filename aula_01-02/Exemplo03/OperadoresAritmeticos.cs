namespace ExemplosOperadores;

public class OperadoresAritmeticos
{
    static void Main()
        {
            Console.WriteLine("=== CALCULADORA DE OPERAÇÕES BÁSICAS ===\n");

            // Solicitar números do usuário
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Operações básicas
            Console.WriteLine("\n--- Resultados das Operações ---");
            Console.WriteLine($"Adição: {num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"Subtração: {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"Multiplicação: {num1} * {num2} = {num1 * num2}");
            
            // Verificar divisão por zero
            if (num2 != 0)
            {
                Console.WriteLine($"Divisão: {num1} / {num2} = {num1 / num2:F2}");
                Console.WriteLine($"Módulo: {num1} % {num2} = {num1 % num2:F2}");
            }
            else
            {
                Console.WriteLine("Divisão: Não é possível dividir por zero!");
            }

            // Demonstrar incremento e decremento
            Console.WriteLine("\n--- Demonstração de Incremento/Decremento ---");
            int contador = 10;
            Console.WriteLine($"Valor inicial: {contador}");
            Console.WriteLine($"Pós-incremento: {contador++} (valor após: {contador})");
            Console.WriteLine($"Pré-incremento: {++contador}");
            Console.WriteLine($"Pós-decremento: {contador--} (valor após: {contador})");
            Console.WriteLine($"Pré-decremento: {--contador}");

            // Operadores compostos
            Console.WriteLine("\n--- Operadores de Atribuição Compostos ---");
            int x = 10;
            Console.WriteLine($"Valor inicial de x: {x}");
            
            x += 5;  Console.WriteLine($"x += 5: {x}");
            x -= 3;  Console.WriteLine($"x -= 3: {x}");
            x *= 2;  Console.WriteLine($"x *= 2: {x}");
            x /= 4;  Console.WriteLine($"x /= 4: {x}");
            x %= 3;  Console.WriteLine($"x %= 3: {x}");
        }
    
}