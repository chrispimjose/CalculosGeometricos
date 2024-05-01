using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosGeometricos
{
	public class Cone : FormaGeometrica
	{
		public double RaioBase { get; set; }
		public double Altura { get; set; }

		public Cone(double raioBase, double altura)
		{
			RaioBase = raioBase;
			Altura = altura;
		}

		public override double CalcularArea()
		{
			double lado = Math.Sqrt(RaioBase * RaioBase + Altura * Altura);
			return Math.PI * RaioBase * (RaioBase + lado);
		}

		public double CalcularVolume()
		{
			return (Math.PI * RaioBase * RaioBase * Altura) / 3;
		}
	}

}
