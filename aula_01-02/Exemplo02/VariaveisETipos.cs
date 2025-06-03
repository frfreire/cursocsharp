namespace ExemploTiposEVariaveis;

public class VariaveisETipos
{
    static void Main()
        {
            Console.WriteLine("=== DEMONSTRAÇÃO DE VARIÁVEIS E TIPOS ===\n");

            // --- Tipos Integrais ---
            Console.WriteLine("--- Tipos Integrais ---");
            byte idade = 25;
            short ano = 2023;
            int populacao = 215000000;
            long distanciaEstrelas = 9460730472580800L; // anos-luz em metros

            Console.WriteLine($"Idade (byte): {idade}");
            Console.WriteLine($"Ano (short): {ano}");
            Console.WriteLine($"População (int): {populacao:N0}");
            Console.WriteLine($"Distância estelar (long): {distanciaEstrelas:N0} metros");

            // --- Tipos de Ponto Flutuante ---
            Console.WriteLine("\n--- Tipos de Ponto Flutuante ---");
            float temperatura = 36.5f;
            double pi = 3.14159265359;
            decimal preco = 199.99m;

            Console.WriteLine($"Temperatura corporal (float): {temperatura}°C");
            Console.WriteLine($"Valor de PI (double): {pi}");
            Console.WriteLine($"Preço (decimal): R$ {preco}");

            // --- Outros Tipos ---
            Console.WriteLine("\n--- Outros Tipos ---");
            bool estaLogado = true;
            char inicial = 'J';
            string nomeCompleto = "João Silva";

            Console.WriteLine($"Está logado (bool): {estaLogado}");
            Console.WriteLine($"Inicial (char): {inicial}");
            Console.WriteLine($"Nome completo (string): {nomeCompleto}");

            // --- Demonstração de var ---
            Console.WriteLine("\n--- Inferência de Tipo com var ---");
            var numeroAutomatico = 42;           // int
            var textoAutomatico = "C# é incrível!"; // string
            var decimalAutomatico = 3.14;        // double

            Console.WriteLine($"Número automático: {numeroAutomatico} (Tipo: {numeroAutomatico.GetType().Name})");
            Console.WriteLine($"Texto automático: {textoAutomatico} (Tipo: {textoAutomatico.GetType().Name})");
            Console.WriteLine($"Decimal automático: {decimalAutomatico} (Tipo: {decimalAutomatico.GetType().Name})");

            // --- Constantes ---
            Console.WriteLine("\n--- Constantes ---");
            const double VELOCIDADE_LUZ = 299792458; // m/s
            const string EMPRESA = "TechCorp Solutions";
            
            Console.WriteLine($"Velocidade da luz: {VELOCIDADE_LUZ:N0} m/s");
            Console.WriteLine($"Empresa: {EMPRESA}");
        }
}