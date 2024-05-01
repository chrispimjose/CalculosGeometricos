using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosGeometricos
{
	public class Paralelepipedo : FormaGeometrica
	{
		public double Comprimento { get; set; }
		public double Largura { get; set; }
		public double Altura { get; set; }

		public Paralelepipedo(double comprimento, double largura, double altura)
		{
			Comprimento = comprimento;
			Largura = largura;
			Altura = altura;
		}

		public override double CalcularArea()
		{
			return 2 * (Comprimento * Largura + Comprimento * Altura + Largura * Altura);
		}

		public double CalcularVolume()
		{
			return Comprimento * Largura * Altura;
		}
	}

}
