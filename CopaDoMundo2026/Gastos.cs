using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CopaDoMundo2026
{
    public class Gastos
    {
        public static void GastosBasicos(string? destinoViagem, int diasViajando, double passagem, double hospedagem)
        {
            switch (destinoViagem)
            {
                case "Vancouver":
                    passagem = 7000;
                    hospedagem = 400 * diasViajando;
                    break;

                case "Toronto":
                    passagem = 5000;
                    hospedagem = 500 * diasViajando;
                    break;

                case "Atlanta":
                    passagem = 7000;
                    hospedagem = 500 * diasViajando;
                    break;

                case "Boston":
                    passagem = 4500;
                    hospedagem = 600 * diasViajando;
                    break;

                case "Dallas":
                    passagem = 7000;
                    hospedagem = 450 * diasViajando;
                    break;

                case "Filadelfia":
                    passagem = 6500;
                    hospedagem = 400 * diasViajando;
                    break;

                case "Houston":
                    passagem = 6000;
                    hospedagem = 400 * diasViajando;
                    break;

                case "Kansas City":
                    passagem = 6500;
                    hospedagem = 500 * diasViajando;
                    break;

                case "Los Angeles":
                    passagem = 4000;
                    hospedagem = 400 * diasViajando;
                    break;

                case "Miami":
                    passagem = 4000;
                    hospedagem = 400 * diasViajando;
                    break;

                case "Nova Iorque":
                    passagem = 4000;
                    hospedagem = 600 * diasViajando;
                    break;

                case "São Francisco":
                    passagem = 4500;
                    hospedagem = 350 * diasViajando;
                    break;

                case "Seattle":
                    passagem = 7000;
                    hospedagem = 500 * diasViajando;
                    break;

                case "Cidade do México":
                    passagem = 3800;
                    hospedagem = 300 * diasViajando;
                    break;

                case "Gadalajara":
                    passagem = 5500;
                    hospedagem = 250 * diasViajando;
                    break;

                case "Monterrey":
                    passagem = 5000;
                    hospedagem = 250 * diasViajando;
                    break;


                default:
                    Console.WriteLine("Você escolheu uma cidade que não será sede da Copa 2026, escolha novamente!");
                    break;
            }
           
        }

    }
}