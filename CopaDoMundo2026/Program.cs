using CopaDoMundo2026;
using System;
using System.Runtime.InteropServices;

Console.WriteLine("Rumo a Copa do Mundo 2026!");
Console.WriteLine("A Copa do Mundo no Catar acabou e você já começou a se planejar para a acompanhar nossa Seleção em 2026?");
Console.WriteLine("A Copa do Mundo 2026, será disputada em 3 países: Canadá, Estados Unidos e México!");
Console.WriteLine("As sedes no Canadá serão:");
Console.WriteLine(" - Vancouver; \r\n - Toronto.");
Console.WriteLine("Nos EUA as sedes serão:");
Console.WriteLine(" - Atlanta; \r\n - Boston; \r\n - Dallas; \r\n - Filadelfia; \r\n - Houston; \r\n - Kansas City; \r\n - Los Angles; \r\n - Miami; \r\n - Nova Iorque; \r\n - São Francisco; \r\n - Seattle.");
Console.WriteLine("E no México as sedes serão:");
Console.WriteLine(" - Cidade do México; \r\n - Guadalajara; \r\n - Monterrey.");

Destino rumoACopa = new Destino();
Console.WriteLine("Em qual cidade você gostaria de assistir um jogo da Copa? ");
rumoACopa.destinoViagem =  Console.ReadLine();


Console.WriteLine($"Quantos dias pretende ficar em {rumoACopa.destinoViagem} acompanhando os jogos da Copa do Mundo? ");
int dias = Int32.Parse(Console.ReadLine());
rumoACopa.diasViajando = dias;

Console.WriteLine("Você pretende viajar sozinho? Digite (S/N)");
rumoACopa.acompanhantes = (Console.ReadLine());
if(rumoACopa.acompanhantes  == "n")
{
    Console.WriteLine("Quantas pessoas vão viajar com você?");
    int pessoasAdicionais = Int32.Parse(Console.ReadLine());
    rumoACopa.quantidadeDeAcompanhantes = pessoasAdicionais;
}
Console.WriteLine($"Quais jogos você quer assister em {rumoACopa.destinoViagem}?");
Console.WriteLine(" [1] - Abertura: \r\n [2] - Fase de Grupos; \r\n [3] - Oitavas de Final; \r\n [4] - Quartas de Final; \r\n [5] - Semi Final; \r\n [6] - FINAL!");
rumoACopa.tipoIngresso = Console.ReadLine();



