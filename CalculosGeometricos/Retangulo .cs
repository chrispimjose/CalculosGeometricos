using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosGeometricos
{
	public class Retangulo : FormaGeometrica
	{
		public double Base { get; set; }
		public double Altura { get; set; }

		public Retangulo(double @base, double altura)
		{
			Base = @base;
			Altura = altura;
		}

		public override double CalcularArea()
		{
			return Base * Altura;
		}
	}
}
