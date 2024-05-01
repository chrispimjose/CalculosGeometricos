using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosGeometricos
{
	public class Quadrado : FormaGeometrica
	{
		public double Lado { get; set; }

		public Quadrado(double lado)
		{
			Lado = lado;
		}

		public override double CalcularArea()
		{
			return Lado * Lado;
		}
	}

}
