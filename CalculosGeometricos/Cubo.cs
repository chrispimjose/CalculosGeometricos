using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosGeometricos
{
	public class Cubo : FormaGeometrica
	{
		public double Lado { get; set; }

		public Cubo(double lado)
		{
			Lado = lado;
		}

		public override double CalcularArea()
		{
			return 6 * Lado * Lado;
		}

		public double CalcularVolume()
		{
			return Lado * Lado * Lado;
		}
	}

}
