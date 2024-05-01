using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosGeometricos
{
	public class Piramide : FormaGeometrica
	{
		public double LadoBase { get; set; }
		public double Altura { get; set; }

		public Piramide(double ladoBase, double altura)
		{
			LadoBase = ladoBase;
			Altura = altura;
		}

		public override double CalcularArea()
		{
			double areaBase = LadoBase * LadoBase;
			double perimetroBase = 4 * LadoBase;
			return (areaBase + (perimetroBase * Altura) / 2);
		}

		public double CalcularVolume()
		{
			return (LadoBase * LadoBase * Altura) / 3;
		}
	}

}
