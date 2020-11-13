using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculoViagem.Models
{
    public class CalculoViagemModel
    {
        public double KmLitro { get; set; }

        public DateTime Tempo { get; set; }

        public double Velocidade { get; set; }

        public double Distancia { get; set; }

        public double LitrosUsado { get; set; }


    }
}