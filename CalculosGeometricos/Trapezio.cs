using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosGeometricos
{
	public class Trapezio : FormaGeometrica
	{
		public double BaseMaior { get; set; }
		public double BaseMenor { get; set; }
		public double Altura { get; set; }

		public Trapezio(double baseMaior, double baseMenor, double altura)
		{
			BaseMaior = baseMaior;
			BaseMenor = baseMenor;
			Altura = altura;
		}

		public override double CalcularArea()
		{
			return ((BaseMaior + BaseMenor) / 2) * Altura;
		}
	}
}
