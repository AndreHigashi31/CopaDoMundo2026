using CopaDoMundo2026;
using System;
using System.Drawing;
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
    rumoACopa.quantidadeAcompanhantes = pessoasAdicionais;
}
Console.WriteLine($"Quais jogos você quer assister em {rumoACopa.destinoViagem}?");
Console.WriteLine(" [1] - Abertura: \r\n [2] - Fase de Grupos; \r\n [3] - Oitavas de Final; \r\n [4] - Quartas de Final; \r\n [5] - Semi Final; \r\n [6] - FINAL!");
rumoACopa.tipoIngresso = Console.ReadLine();


switch (rumoACopa.destinoViagem)
{
    case "Vancouver":
        rumoACopa.passagem = 7000;
        rumoACopa.hospedagem = 400 * rumoACopa.diasViajando;
        rumoACopa.alimentacao = (rumoACopa.alimentacao * rumoACopa.dolar) * rumoACopa.diasViajando;
        rumoACopa.gastosTotais = rumoACopa.hospedagem + ((rumoACopa.passagem + rumoACopa.alimentacao) * (rumoACopa.quantidadeAcompanhantes + 1));
        break;

    case "Toronto":
        rumoACopa.passagem = 5000;
        rumoACopa.hospedagem = 500 * rumoACopa.diasViajando;
        rumoACopa.alimentacao = (rumoACopa.alimentacao * rumoACopa.dolar) * rumoACopa.diasViajando;
        rumoACopa.gastosTotais = rumoACopa.hospedagem + ((rumoACopa.passagem + rumoACopa.alimentacao) * (rumoACopa.quantidadeAcompanhantes + 1));
        break;

    case "Atlanta":
        rumoACopa.passagem = 7000;
        rumoACopa.hospedagem = 500 * rumoACopa.diasViajando;
        rumoACopa.alimentacao = (rumoACopa.alimentacao * rumoACopa.dolar) * rumoACopa.diasViajando;
        rumoACopa.gastosTotais = rumoACopa.hospedagem + ((rumoACopa.passagem + rumoACopa.alimentacao) * (rumoACopa.quantidadeAcompanhantes + 1));
        break;

    case "Boston":
        rumoACopa.passagem = 4500;
        rumoACopa.hospedagem = 600 * rumoACopa.diasViajando;
        rumoACopa.alimentacao = (rumoACopa.alimentacao * rumoACopa.dolar) * rumoACopa.diasViajando;
        rumoACopa.gastosTotais = rumoACopa.hospedagem + ((rumoACopa.passagem + rumoACopa.alimentacao) * (rumoACopa.quantidadeAcompanhantes + 1));
        break;
        

    case "Dallas":
        rumoACopa.passagem = 7000;
        rumoACopa.hospedagem = 450 * rumoACopa.diasViajando;
        rumoACopa.alimentacao = (rumoACopa.alimentacao * rumoACopa.dolar) * rumoACopa.diasViajando;
        rumoACopa.gastosTotais = rumoACopa.hospedagem + ((rumoACopa.passagem + rumoACopa.alimentacao) * (rumoACopa.quantidadeAcompanhantes + 1));
        break;
      

    case "Filadelfia":
        rumoACopa.passagem = 6500;
        rumoACopa.hospedagem = 400 * rumoACopa.diasViajando;
        rumoACopa.alimentacao = (rumoACopa.alimentacao * rumoACopa.dolar) * rumoACopa.diasViajando;
        rumoACopa.gastosTotais = rumoACopa.hospedagem + ((rumoACopa.passagem + rumoACopa.alimentacao) * (rumoACopa.quantidadeAcompanhantes + 1));
        break;
       

    case "Houston":
        rumoACopa.passagem = 6000;
        rumoACopa.hospedagem = 400 * rumoACopa.diasViajando;
        rumoACopa.alimentacao = (rumoACopa.alimentacao * rumoACopa.dolar) * rumoACopa.diasViajando;
        rumoACopa.gastosTotais = rumoACopa.hospedagem + ((rumoACopa.passagem + rumoACopa.alimentacao) * (rumoACopa.quantidadeAcompanhantes + 1));
        break;
       

    case "Kansas City":
        rumoACopa.passagem = 6500;
        rumoACopa.hospedagem = 500 * rumoACopa.diasViajando;
        rumoACopa.alimentacao = (rumoACopa.alimentacao * rumoACopa.dolar) * rumoACopa.diasViajando;
        rumoACopa.gastosTotais = rumoACopa.hospedagem + ((rumoACopa.passagem + rumoACopa.alimentacao) * (rumoACopa.quantidadeAcompanhantes + 1));
        break; ;
        

    case "Los Angeles":
        rumoACopa.passagem = 4000;
        rumoACopa.hospedagem = 400 * rumoACopa.diasViajando;
        rumoACopa.alimentacao = (rumoACopa.alimentacao * rumoACopa.dolar) * rumoACopa.diasViajando;
        rumoACopa.gastosTotais = rumoACopa.hospedagem + ((rumoACopa.passagem + rumoACopa.alimentacao) * (rumoACopa.quantidadeAcompanhantes + 1));
        break;
        

    case "Miami":
        rumoACopa.passagem = 4000;
        rumoACopa.hospedagem = 400 * rumoACopa.diasViajando;
        rumoACopa.alimentacao = (rumoACopa.alimentacao * rumoACopa.dolar) * rumoACopa.diasViajando;
        rumoACopa.gastosTotais = rumoACopa.hospedagem + ((rumoACopa.passagem + rumoACopa.alimentacao) * (rumoACopa.quantidadeAcompanhantes + 1));
        break;

    case "Nova Iorque":
        rumoACopa.passagem = 4000;
        rumoACopa.hospedagem = 600 * rumoACopa.diasViajando;
        rumoACopa.alimentacao = (rumoACopa.alimentacao * rumoACopa.dolar) * rumoACopa.diasViajando;
        rumoACopa.gastosTotais = rumoACopa.hospedagem + ((rumoACopa.passagem + rumoACopa.alimentacao) * (rumoACopa.quantidadeAcompanhantes + 1));
        break;

    case "São Francisco":
        rumoACopa.passagem = 4500;
        rumoACopa.hospedagem = 350 * rumoACopa.diasViajando;
        rumoACopa.alimentacao = (rumoACopa.alimentacao * rumoACopa.dolar) * rumoACopa.diasViajando;
        rumoACopa.gastosTotais = rumoACopa.hospedagem + ((rumoACopa.passagem + rumoACopa.alimentacao) * (rumoACopa.quantidadeAcompanhantes + 1));
        break;

    case "Seattle":
        rumoACopa.passagem = 7000;
        rumoACopa.hospedagem = 500 * rumoACopa.diasViajando;
        rumoACopa.alimentacao = (rumoACopa.alimentacao * rumoACopa.dolar) * rumoACopa.diasViajando;
        rumoACopa.gastosTotais = rumoACopa.hospedagem + ((rumoACopa.passagem + rumoACopa.alimentacao) * (rumoACopa.quantidadeAcompanhantes + 1));
        break;

    case "Cidade do México":
        rumoACopa.passagem = 3800;
        rumoACopa.hospedagem = 300 * rumoACopa.diasViajando;
        rumoACopa.alimentacao = (rumoACopa.alimentacao * rumoACopa.dolar) * rumoACopa.diasViajando;
        rumoACopa.gastosTotais = rumoACopa.hospedagem + ((rumoACopa.passagem + rumoACopa.alimentacao) * (rumoACopa.quantidadeAcompanhantes + 1));
        break;

    case "Guadalajara":
        rumoACopa.passagem = 5500;
        rumoACopa.hospedagem = 250 * rumoACopa.diasViajando;
        rumoACopa.alimentacao = (rumoACopa.alimentacao * rumoACopa.dolar) * rumoACopa.diasViajando;
        rumoACopa.gastosTotais = rumoACopa.hospedagem + ((rumoACopa.passagem + rumoACopa.alimentacao) * (rumoACopa.quantidadeAcompanhantes + 1));
        break;

    case "Monterrey":
        rumoACopa.passagem = 5000;
        rumoACopa.hospedagem = 250 * rumoACopa.diasViajando;
        rumoACopa.alimentacao = (rumoACopa.alimentacao * rumoACopa.dolar) * rumoACopa.diasViajando;
        rumoACopa.gastosTotais = rumoACopa.hospedagem + ((rumoACopa.passagem + rumoACopa.alimentacao) * (rumoACopa.quantidadeAcompanhantes + 1));
        break;


    default:
        Console.WriteLine("Você escolheu uma cidade que não será sede da Copa 2026, escolha novamente!");
        break;

 
}
Console.WriteLine($"Com passagens area para {rumoACopa.destinoViagem}, vamos gastar R$ {rumoACopa.passagem}");
Console.WriteLine($"Com hospedagem vamos gastar R$ {rumoACopa.hospedagem}");
Console.WriteLine($"Com alimentação vamos gastar R$ {rumoACopa.alimentacao}");
Console.WriteLine($"Ao todo nossa viagem sairá por R$ {rumoACopa.gastosTotais}");





