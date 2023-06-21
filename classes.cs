public class SomaNumeros
{
    public int Somar(int numero1, int numero2)
    {
        return numero1 + numero2;
    }
}
public class ConversorMetroMilimetro
{
    public int ConverterParaMilimetro(int metros)
    {
        return metros * 1000;
    }
}
public class CalculaAumento
{
    public double Calcular(double valor, double taxaPercentual)
    {
        double aumento = valor * taxaPercentual / 100;
        return valor + aumento;
    }
}

public class CalculaDesconto
{
    public double Calcular(double valor, double taxaPercentual)
    {
        double desconto = valor * taxaPercentual / 100;
        return valor - desconto;
    }
}

public class AluguelCarro
{
    public double CalcularValorTotal(int quantidadeDias, double valorDiaria)
    {
        return quantidadeDias * valorDiaria;
    }
}

public class CalculaIMC
{
    public double Calcular(double peso, double altura)
    {
        double alturaMetros = altura / 100; // Convertendo altura para metros
        return peso / (alturaMetros * alturaMetros);
    }
}

public class Cantoneira
{
    public void ImprimirCantoneira(int numero)
    {
        for (int i = 1; i <= numero; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

public class Tabuada
{
    public void ImprimirTabuada(int numero)
    {
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}

public class MultiplosDeTres
{
    public void ImprimirMultiplosDeTres()
    {
        Console.WriteLine("Múltiplos de 3 entre 0 e 100:");
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

public class Fatoriais
{
    public void ImprimirFatoriais()
    {
        Console.WriteLine("Fatoriais de 1 até 10:");
        for (int i = 1; i <= 10; i++)
        {
            int fatorial = CalcularFatorial(i);
            Console.WriteLine($"{i}! = {fatorial}");
        }
    }

    private int CalcularFatorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * CalcularFatorial(n - 1);
        }
    }
}

public class CalculaImpostoRenda
{
    public double CalcularImpostoRenda(double salario)
    {
        double imposto = 0;
        if (salario <= 1903.98)
        {
            imposto = 0;
        }
        else if (salario <= 2826.65)
        {
            imposto = salario * 0.075;
        }
        else if (salario <= 3751.05)
        {
            imposto = salario * 0.15;
        }
        else if (salario <= 4664.68)
        {
            imposto = salario * 0.225;
        }
        else
        {
            imposto = salario * 0.275;
        }
        return imposto;
    }
}

public class AdivinharNumero
{
    public void JogoAdivinharNumero()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);
        int tentativas = 0;
        
        Console.WriteLine("Jogo da Adivinhação!");
        Console.WriteLine("Tente adivinhar um número entre 1 e 100.");
        
        while (true)
        {
            Console.Write("Digite um número: ");
            int numeroDigitado = int.Parse(Console.ReadLine());
            
            tentativas++;
            
            if (numeroDigitado == numeroAleatorio)
            {
                Console.WriteLine($"Parabéns! Você acertou o número em {tentativas} tentativas.");
                break;
            }
            else if (numeroDigitado < numeroAleatorio)
            {
                Console.WriteLine("Tente um número maior.");
            }
            else
            {
                Console.WriteLine("Tente um número menor.");
            }
        }
    }
}

public class FinanciamentoVeiculo
{
    public double CalcularFinanciamento(double valorVeiculo, double taxaJuros, int quantidadeParcelas)
    {
        double valorFinanciado = valorVeiculo * (1 + taxaJuros);
        double valorParcela = valorFinanciado / quantidadeParcelas;
        return valorParcela;
    }
}

public class Aposentadoria
{
    public int CalcularIdadeAposentadoria(string sexo)
    {
        if (sexo.ToLower() == "masculino" || sexo.ToLower() == "m")
        {
            return 65;
        }
        else if (sexo.ToLower() == "feminino" || sexo.ToLower() == "f")
        {
            return 60;
        }
        else
        {
            return 0;
        }
    }
}

public class JogoDaVelha
{
    private char[,] tabuleiro;
    private char jogadorAtual;

    public JogoDaVelha()
    {
        tabuleiro = new char[3, 3];
        jogadorAtual = 'X';
        InicializarTabuleiro();
    }

    private void InicializarTabuleiro()
    {
        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                tabuleiro[linha, coluna] = ' ';
            }
        }
    }

    public void Jogar(int linha, int coluna)
    {
        if (linha < 0 || linha > 2 || coluna < 0 || coluna > 2 || tabuleiro[linha, coluna] != ' ')
        {
            Console.WriteLine("Jogada inválida. Tente novamente.");
            return;
        }

        tabuleiro[linha, coluna] = jogadorAtual;
        MostrarTabuleiro();
        VerificarVencedor();
        TrocarJogador();
    }

    private void MostrarTabuleiro()
    {
        Console.WriteLine();
        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write(tabuleiro[linha, coluna]);
                if (coluna < 2)
                {
                    Console.Write(" | ");
                }
            }
            Console.WriteLine();
            if (linha < 2)
            {
                Console.WriteLine("---------");
            }
        }
        Console.WriteLine();
    }

    private void VerificarVencedor()
    {
        // Verificar linhas
        for (int linha = 0; linha < 3; linha++)
        {
            if (tabuleiro[linha, 0] == tabuleiro[linha, 1] && tabuleiro[linha, 0] == tabuleiro[linha, 2] && tabuleiro[linha, 0] != ' ')
            {
                Console.WriteLine($"Jogador {jogadorAtual} venceu!");
                return;
            }
        }

        // Verificar colunas
        for (int coluna = 0; coluna < 3; coluna++)
        {
            if (tabuleiro[0, coluna] == tabuleiro[1, coluna] && tabuleiro[0, coluna] == tabuleiro[2, coluna] && tabuleiro[0, coluna] != ' ')
            {
                Console.WriteLine($"Jogador {jogadorAtual} venceu!");
                return;
            }
        }

        // Verificar diagonais
        if ((tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[0, 0] == tabuleiro[2, 2] && tabuleiro[0, 0] != ' ') ||
            (tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[0, 2] == tabuleiro[2, 0] && tabuleiro[0, 2] != ' '))
        {
            Console.WriteLine($"Jogador {jogadorAtual} venceu!");
            return;
        }

        // Verificar empate
        bool empate = true;
        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                if (tabuleiro[linha, coluna] == ' ')
                {
                    empate = false;
                    break;
                }
            }
            if (!empate)
            {
                break;
            }
        }

        if (empate)
        {
            Console.WriteLine("Empate!");
        }
    }

    private void TrocarJogador()
    {
        if (jogadorAtual == 'X')
        {
            jogadorAtual = 'O';
        }
        else
        {
            jogadorAtual = 'X';
        }
    }
}
