using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosGeometricos
{
	public class Cilindro : FormaGeometrica
	{
		public double RaioBase { get; set; }
		public double Altura { get; set; }

		public Cilindro(double raioBase, double altura)
		{
			RaioBase = raioBase;
			Altura = altura;
		}

		public override double CalcularArea()
		{
			return 2 * Math.PI * RaioBase * (RaioBase + Altura);
		}

		public double CalcularVolume()
		{
			return Math.PI * RaioBase * RaioBase * Altura;
		}
	}
}
