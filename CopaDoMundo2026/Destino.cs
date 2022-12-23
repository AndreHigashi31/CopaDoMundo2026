using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopaDoMundo2026
{
    public class Destino

    {
        public  string destinoViagem { get; set; }
        public int diasViajando { get; set; }
        public string tipoIngresso { get; set; }
        public string acompanhantes { get; set; }
        public int quantidadeAcompanhantes { get; set; }
        public double alimentacao = 75;
        public double passagem { get; set; }
        public double hospedagem { get; set; }
        public double dolar = 5.20;
        public double gastosTotais { get; set; }
    }
}
