using CalculosGeometricos;

namespace CalculosGeometricosTests
{
	public class CalculosGeometricos_Testes
	{
		[Fact (DisplayName = "Calcula a área do Circulo")]
		public void CalcularArea_DeveRetornarAreaCorreta()
		{
			// Arrange
			double raio = 5.0;
			Circulo circulo = new Circulo(raio);
			double areaEsperada = Math.PI * raio * raio;

			// Act
			double areaCalculada = circulo.CalcularArea();

			// Assert
			Assert.Equal(areaEsperada, areaCalculada, precision: 10);
		}

		public class QuadradoTests
		{
			[Fact (DisplayName = "Calcula a área do Quadrado")]
			public void CalcularArea_DeveRetornarAreaCorreta()
			{
				// Arrange
				double lado = 4.0;
				Quadrado quadrado = new Quadrado(lado);
				double areaEsperada = lado * lado;

				// Act
				double areaCalculada = quadrado.CalcularArea();

				// Assert
				Assert.Equal(areaEsperada, areaCalculada);
			}
		}

		public class RetanguloTests
		{
			[Fact (DisplayName = "Calcula a área do Retângulo")]
			public void CalcularArea_DeveRetornarAreaCorreta()
			{
				// Arrange
				double @base = 5.0;
				double altura = 3.0;
				Retangulo retangulo = new Retangulo(@base, altura);
				double areaEsperada = @base * altura;

				// Act
				double areaCalculada = retangulo.CalcularArea();

				// Assert
				Assert.Equal(areaEsperada, areaCalculada);
			}
		}

		public class TrapezioTests
		{
			[Fact (DisplayName = "Calcula a área do Trapésio")]
			public void CalcularArea_DeveRetornarAreaCorreta()
			{
				// Arrange
				double baseMaior = 6.0;
				double baseMenor = 4.0;
				double altura = 3.0;
				Trapezio trapezio = new Trapezio(baseMaior, baseMenor, altura);
				double areaEsperada = ((baseMaior + baseMenor) / 2) * altura;

				// Act
				double areaCalculada = trapezio.CalcularArea();

				// Assert
				Assert.Equal(areaEsperada, areaCalculada);
			}
		}

		public class CilindroTests
		{
			[Fact (DisplayName = "Calcula a área do Cilindro")]
			public void CalcularArea_DeveRetornarAreaCorreta()
			{
				// Arrange
				double raioBase = 2.0;
				double altura = 5.0;
				Cilindro cilindro = new Cilindro(raioBase, altura);
				double areaEsperada = 2 * Math.PI * raioBase * (raioBase + altura);

				// Act
				double areaCalculada = cilindro.CalcularArea();

				// Assert
				Assert.Equal(areaEsperada, areaCalculada, precision: 10);
			}

			[Fact (DisplayName = "Calcula o volume do Cilindro")]
			public void CalcularVolume_DeveRetornarVolumeCorreto()
			{
				// Arrange
				double raioBase = 2.0;
				double altura = 5.0;
				Cilindro cilindro = new Cilindro(raioBase, altura);
				double volumeEsperado = Math.PI * raioBase * raioBase * altura;

				// Act
				double volumeCalculado = cilindro.CalcularVolume();

				// Assert
				Assert.Equal(volumeEsperado, volumeCalculado, precision: 10);
			}
		}

		public class ConeTests
		{
			[Fact(DisplayName = "Calcula a área do Cone")]
			public void CalcularArea_DeveRetornarAreaCorreta()
			{
				// Arrange
				double raioBase = 3.0;
				double altura = 4.0;
				Cone cone = new Cone(raioBase, altura);
				double areaEsperada = Math.PI * raioBase * (raioBase + Math.Sqrt(raioBase * raioBase + altura * altura));

				// Act
				double areaCalculada = cone.CalcularArea();

				// Assert
				Assert.Equal(areaEsperada, areaCalculada, precision: 10);
			}

			[Fact(DisplayName = "Calcula o volume do Cone")]
			public void CalcularVolume_DeveRetornarVolumeCorreto()
			{
				// Arrange
				double raioBase = 3.0;
				double altura = 4.0;
				Cone cone = new Cone(raioBase, altura);
				double volumeEsperado = (Math.PI * raioBase * raioBase * altura) / 3;

				// Act
				double volumeCalculado = cone.CalcularVolume();

				// Assert
				Assert.Equal(volumeEsperado, volumeCalculado, precision: 10);
			}
		}

		public class PiramideTests
		{
			[Fact(DisplayName = "Calcula a área da Pirãmide")]
			public void CalcularArea_DeveRetornarAreaCorreta()
			{
				// Arrange
				double ladoBase = 6.0;
				double altura = 8.0;

				double areaBase = ladoBase * ladoBase;
				double perimetroBase = 4 * ladoBase;
				Piramide piramide = new Piramide(ladoBase, altura);
				double areaEsperada = (areaBase + (perimetroBase * altura) / 2);

				// Act
				double areaCalculada = piramide.CalcularArea();

				// Assert
				Assert.Equal(areaEsperada, areaCalculada);
			}

			[Fact(DisplayName = "Calcula o volume do Pirâmide")]
			public void CalcularVolume_DeveRetornarVolumeCorreto()
			{
				// Arrange
				double ladoBase = 6.0;
				double altura = 8.0;
				Piramide piramide = new Piramide(ladoBase, altura);
				double volumeEsperado = (ladoBase * ladoBase * altura) / 3;

				// Act
				double volumeCalculado = piramide.CalcularVolume();

				// Assert
				Assert.Equal(volumeEsperado, volumeCalculado);
			}
		}

		public class CuboTests
		{
			[Fact(DisplayName = "Calcula a área do Cubo")]
			public void CalcularArea_DeveRetornarAreaCorreta()
			{
				// Arrange
				double lado = 4.0;
				Cubo cubo = new Cubo(lado);
				double areaEsperada = 6 * lado * lado;

				// Act
				double areaCalculada = cubo.CalcularArea();

				// Assert
				Assert.Equal(areaEsperada, areaCalculada);
			}

			[Fact(DisplayName = "Calcula o volume do Cubo")]
			public void CalcularVolume_DeveRetornarVolumeCorreto()
			{
				// Arrange
				double lado = 4.0;
				Cubo cubo = new Cubo(lado);
				double volumeEsperado = lado * lado * lado;

				// Act
				double volumeCalculado = cubo.CalcularVolume();

				// Assert
				Assert.Equal(volumeEsperado, volumeCalculado);
			}
		}

		public class ParalelepipedoTests
		{
			[Fact(DisplayName = "Calcula a área do Paralelepípedo")]
			public void CalcularArea_DeveRetornarAreaCorreta()
			{
				// Arrange
				double comprimento = 5.0;
				double largura = 3.0;
				double altura = 4.0;
				Paralelepipedo paralelepipedo = new Paralelepipedo(comprimento, largura, altura);
				double areaEsperada = 2 * (comprimento * largura + comprimento * altura + largura * altura);

				// Act
				double areaCalculada = paralelepipedo.CalcularArea();

				// Assert
				Assert.Equal(areaEsperada, areaCalculada);
			}

			[Fact(DisplayName = "Calcula o volume do Paralelepípedo")]
			public void CalcularVolume_DeveRetornarVolumeCorreto()
			{
				// Arrange
				double comprimento = 5.0;
				double largura = 3.0;
				double altura = 4.0;
				Paralelepipedo paralelepipedo = new Paralelepipedo(comprimento, largura, altura);
				double volumeEsperado = comprimento * largura * altura;

				// Act
				double volumeCalculado = paralelepipedo.CalcularVolume();

				// Assert
				Assert.Equal(volumeEsperado, volumeCalculado);
			}
		}

		// Fim da Classe
	}
}