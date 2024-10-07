using System.Globalization;
using System.Text.RegularExpressions;

namespace Fundamentos;

public class Exercicios
{
    static void Main()
    {
        MostrarData();
    }

    static void BoasVindas()
    {
        Console.Write("Olá, qual o seu nome?");
        string nome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome}! Seja muito bem vindo!");
    }

    static void NomeCompleto()
    {
        Console.Write("Informe o seu primeiro nome: ");
        string primeiroNome = Console.ReadLine();

        Console.Write("Agora informe o segundo nome: ");
        string segundoNome = Console.ReadLine();

        Console.WriteLine($"{primeiroNome} {segundoNome}, esse é seu nome completo?");
    }

    static void Calculo(double num1, double num2)
    {
        double soma = num1 + num2;
        double subtracao = num1 - num2;
        double multiplicacao = num1 * num2;
        double divisao = num1 / num2;
        double media = (num1 + num2) / 2; 

        Console.WriteLine($"A soma desses números é: {soma}.\n A subtração é: {subtracao}.\n A multiplicação é: {multiplicacao}.\n A divisão é: {divisao}.\n A média é {media}");
    }

    static void QtdPalavras(string palavra)
    {
        string semEspaços = palavra.Replace(" ", "");

        Console.WriteLine(semEspaços.Length);
    }

    static void Placa(string placa)
    {
        string padraoPlaca = @"^[a-zA-Z]{3}\d{4}$";

        bool placaValida = Regex.IsMatch(placa, padraoPlaca);

        Console.WriteLine(placaValida ? "Válida" : "Não válida");
    }

    static void MostrarData()
    {
        DateTime dataAtual = DateTime.Now;

        string formatoCompleto = dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss", new CultureInfo("pt-BR"));
        Console.WriteLine("Formato completo: " + formatoCompleto);

        string formatoData = dataAtual.ToString("dd/MM/yyyy");
        Console.WriteLine("Apenas data: " + formatoData);

        string formatoHora = dataAtual.ToString("HH:mm:ss");
        Console.WriteLine("Apenas hora: " + formatoHora);

        string formatoMesExtenso = dataAtual.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"));
        Console.WriteLine("Data com mês por extenso: " + formatoMesExtenso);
    }
}
