using System;

class Program {
  public static void Main (string[] args) {
    double volume, comprimento, largura, altura;
    Console.Write("Digite o comprimento da caixa:");
    comprimento = double.Parse(Console.ReadLine());
    Console.Write( "Digite a largura da caixa:");
    largura = double.Parse(Console.ReadLine());
    Console.Write("Digite a altura da caixa:");
    altura = double.Parse(Console.ReadLine());
    Console.Write( "O volume da caixa é:");
    volume = comprimento * largura * altura;
    Console.WriteLine($"\t O volume da caixa com {comprimento} metros de comprimentos, {largura} metros de largura {altura} metros de altura é: {volume} metros cúbicos.");
    
    
    }
  }