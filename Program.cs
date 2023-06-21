// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool sair = false;
        SomaNumeros soma = new SomaNumeros();
        ConversorMetroMilimetro conversor = new ConversorMetroMilimetro();
        CalculaAumento calculaAumento = new CalculaAumento();
        CalculaDesconto calculaDesconto = new CalculaDesconto();
        AluguelCarro aluguelCarro = new AluguelCarro();
        CalculaIMC calculaIMC = new CalculaIMC();
        Cantoneira cantoneira = new Cantoneira();
        Tabuada tabuada = new Tabuada();
        MultiplosDeTres multiplosDeTres = new MultiplosDeTres();
        Fatoriais fatoriais = new Fatoriais();
        CalculaImpostoRenda calculaImpostoRenda = new CalculaImpostoRenda();
        AdivinharNumero adivinharNumero = new AdivinharNumero();
        FinanciamentoVeiculo financiamentoVeiculo = new FinanciamentoVeiculo();
        Aposentadoria aposentadoria = new Aposentadoria();
        JogoDaVelha jogoDaVelha = new JogoDaVelha();

        
        while (!sair)
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("0) Sair");
            Console.WriteLine("1) Somar números");
            Console.WriteLine("2) Converter de metros para milímetros");
            Console.WriteLine("3) Calcular Aumento");
            Console.WriteLine("4) Calcular Desconto");
            Console.WriteLine("5) Aluguel Carro");
            Console.WriteLine("6) Calcular IMC");
            Console.WriteLine("7) Cantoneira até número fornecido");
            Console.WriteLine("8) Tabuada de cada número");
            Console.WriteLine("9) Múltiplos de 3 entre 0 e 100");
            Console.WriteLine("10) Fatoriais de 1 até 10");
            Console.WriteLine("11) Imposto de Renda");
            Console.WriteLine("12) Adivinhar número");
            Console.WriteLine("13) Financiamento do veículo");
            Console.WriteLine("14) Aposentadoria");
            Console.WriteLine("15) Jogo da velha");
            
            Console.Write("Opção selecionada: ");
            int opcao = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            
            switch (opcao)
            {
                case 0:
                    sair = true;
                    Console.WriteLine("Saindo...");
                    break;
                case 1:
                    // Implementar a classe de soma de números aqui
                    Console.WriteLine("Opção 1 selecionada: Somar números");
                    Console.Write("Digite o primeiro número: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    int num2 = int.Parse(Console.ReadLine());
                    int resultado = soma.Somar(num1, num2);
                    Console.WriteLine($"Resultado da soma: {resultado}");
                    break;
                case 2:
                    // Implementar a classe de conversão de metros para milímetros aqui
                    Console.WriteLine("Opção 2 selecionada: Converter de metros para milímetros");
                    Console.Write("Digite a quantidade de metros: ");
                    int metros = int.Parse(Console.ReadLine());
                    int milimetros = conversor.ConverterParaMilimetro(metros);
                    Console.WriteLine($"Resultado da conversão: {milimetros} milímetros");
                    break;
                case 3:
                    // Implementar a classe de cálculo de aumento aqui
                    Console.WriteLine("Opção 3 selecionada: Calcular Aumento");
                    Console.Write("Digite o valor: ");
                    double valorAumento = double.Parse(Console.ReadLine());
                    Console.Write("Digite a taxa de aumento em percentual: ");
                    double taxaAumento = double.Parse(Console.ReadLine());
                    double valorAumentado = calculaAumento.Calcular(valorAumento, taxaAumento);
                    Console.WriteLine($"Valor após aumento: {valorAumentado}");
                    break;
                case 4:
                    // Implementar a classe de cálculo de desconto aqui
                    Console.WriteLine("Opção 4 selecionada: Calcular Desconto");
                     Console.Write("Digite o valor: ");
                    double valorDesconto = double.Parse(Console.ReadLine());
                    Console.Write("Digite a taxa de desconto em percentual: ");
                    double taxaDesconto = double.Parse(Console.ReadLine());
                    double valorDescontado = calculaDesconto.Calcular(valorDesconto, taxaDesconto);
                    Console.WriteLine($"Valor após desconto: {valorDescontado}");
                    break;
                case 5:
                    // Implementar a classe de aluguel de carro aqui
                    Console.WriteLine("Opção 5 selecionada: Aluguel Carro");
                    Console.WriteLine("Opção 5 selecionada: Aluguel Carro");
                    Console.Write("Digite a quantidade de dias de aluguel: ");
                    int quantidadeDias = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da diária: ");
                    double valorDiaria = double.Parse(Console.ReadLine());
                    double valorTotal = aluguelCarro.CalcularValorTotal(quantidadeDias, valorDiaria);
                    Console.WriteLine($"Valor total do aluguel: {valorTotal}");
                    break;
                case 6:
                    // Implementar a classe de cálculo de IMC aqui
                    Console.WriteLine("Opção 6 selecionada: Calcular IMC");
                    Console.WriteLine("Opção 6 selecionada: Calcular IMC");
                    Console.Write("Digite o peso (em kg): ");
                    double peso = double.Parse(Console.ReadLine());
                    Console.Write("Digite a altura (em cm): ");
                    double altura = double.Parse(Console.ReadLine());
                    double imc = calculaIMC.Calcular(peso, altura);
                    Console.WriteLine($"Seu IMC é: {imc:F2}");
                    break;
                case 7:
                    // Implementar a classe de cantoneira até número fornecido aqui
                    Console.WriteLine("Opção 7 selecionada: Cantoneira até número fornecido");
                    Console.WriteLine("Opção 7 selecionada: Cantoneira até número fornecido");
                    Console.Write("Digite um número: ");
                    int numeroCantoneira = int.Parse(Console.ReadLine());
                    cantoneira.ImprimirCantoneira(numeroCantoneira);
                    break;
                case 8:
                    // Implementar a classe de tabuada de cada número aqui
                    Console.WriteLine("Opção 8 selecionada: Tabuada de cada número");
                    Console.WriteLine("Opção 8 selecionada: Tabuada de cada número");
                    Console.Write("Digite um número: ");
                    int numeroTabuada = int.Parse(Console.ReadLine());
                    tabuada.ImprimirTabuada(numeroTabuada);
                    break;
                case 9:
                    // Implementar a classe de múltiplos de 3 entre 0 e 100 aqui
                    Console.WriteLine("Opção 9 selecionada: Múltiplos de 3 entre 0 e 100");
                    multiplosDeTres.ImprimirMultiplosDeTres();
                    break;
                case 10:
                    // Implementar a classe de fatoriais de 1 até 10 aqui
                    Console.WriteLine("Opção 10 selecionada: Fatoriais de 1 até 10");
                    fatoriais.ImprimirFatoriais();
                    break;
                case 11:
                    // Implementar a classe de cálculo de Imposto de Renda aqui
                    Console.WriteLine("Opção 11 selecionada: Imposto de Renda");
                    Console.Write("Digite o valor do salário: ");
                    double salario = double.Parse(Console.ReadLine());
                    double impostoRenda = calculaImpostoRenda.CalcularImpostoRenda(salario);
                    Console.WriteLine($"Imposto de Renda devido: R$ {impostoRenda:F2}");
                    break;
                case 12:
                    // Implementar a classe de adivinhar número aqui
                    Console.WriteLine("Opção 12 selecionada: Adivinhar número");
                    adivinharNumero.JogoAdivinharNumero();
                    break;
                case 13:
                    // Implementar a classe de financiamento do veículo aqui
                    Console.WriteLine("Opção 13 selecionada: Financiamento do veículo");
                    Console.Write("Digite o valor do veículo: ");
                    double valorVeiculo = double.Parse(Console.ReadLine());
                    Console.Write("Digite a taxa de juros: ");
                    double taxaJuros = double.Parse(Console.ReadLine());
                    Console.Write("Digite a quantidade de parcelas: ");
                    int quantidadeParcelas = int.Parse(Console.ReadLine());
                    double valorParcela = financiamentoVeiculo.CalcularFinanciamento(valorVeiculo, taxaJuros, quantidadeParcelas);
                    Console.WriteLine($"Valor da parcela do financiamento: R$ {valorParcela:F2}");
                    break;
                case 14:
                    // Implementar a classe de aposentadoria aqui
                    Console.WriteLine("Opção 14 selecionada: Aposentadoria");
                    Console.Write("Digite o sexo (M/F): ");
                    string sexo = Console.ReadLine();
                    int idadeAposentadoria = aposentadoria.CalcularIdadeAposentadoria(sexo);
                    Console.WriteLine($"Idade mínima para aposentadoria: {idadeAposentadoria} anos");
                    break;
                    
                case 15:
                    // Implementar a classe do jogo da velha aqui
                    Console.WriteLine("Opção 15 selecionada: Jogo da velha");
                    Console.WriteLine("Opção 15 selecionada: Jogo da Velha");
                    Console.WriteLine("Digite as coordenadas (linha e coluna) para jogar (0 a 2):");
                    Console.Write("Linha: ");
                    int linha = int.Parse(Console.ReadLine());
                    Console.Write("Coluna: ");
                    int coluna = int.Parse(Console.ReadLine());
                    jogoDaVelha.Jogar(linha, coluna);
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
            
            Console.WriteLine();
        }
    }
}

