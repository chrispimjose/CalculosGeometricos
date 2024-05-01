namespace CalculosGeometricos
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Exemplo de uso das classes
			// Limpa a tela do console
			Console.Clear();

			// Calculando a área de um círculo
			Circulo circulo = new Circulo(5.0);
			Console.WriteLine($"Área do Círculo: {circulo.CalcularArea()}");

			// Calculando a área de um quadrado
			Quadrado quadrado = new Quadrado(4.0);
			Console.WriteLine($"Área do Quadrado: {quadrado.CalcularArea()}");

			// Calculando a área de um retângulo
			Retangulo retangulo = new Retangulo(5.0, 3.0);
			Console.WriteLine($"Área do Retângulo: {retangulo.CalcularArea()}");

			// Calculando a área de um trapézio
			Trapezio trapezio = new Trapezio(6.0, 4.0, 3.0);
			Console.WriteLine($"Área do Trapézio: {trapezio.CalcularArea()}");

			// Calculando a área e o volume de um cilindro
			Cilindro cilindro = new Cilindro(2.0, 5.0);
			Console.WriteLine($"Área do Cilindro: {cilindro.CalcularArea()}");
			Console.WriteLine($"Volume do Cilindro: {cilindro.CalcularVolume()}");

			// Calculando a área e o volume de um cone
			Cone cone = new Cone(3.0, 4.0);
			Console.WriteLine($"Área do Cone: {cone.CalcularArea()}");
			Console.WriteLine($"Volume do Cone: {cone.CalcularVolume()}");

			// Calculando a área e o volume de uma pirâmide
			Piramide piramide = new Piramide(6.0, 8.0);
			Console.WriteLine($"Área da Pirâmide: {piramide.CalcularArea()}");
			Console.WriteLine($"Volume da Pirâmide: {piramide.CalcularVolume()}");

			// Calculando a área e o volume de um cubo
			Cubo cubo = new Cubo(4.0);
			Console.WriteLine($"Área do Cubo: {cubo.CalcularArea()}");
			Console.WriteLine($"Volume do Cubo: {cubo.CalcularVolume()}");

			// Calculando a área e o volume de um paralelepípedo
			Paralelepipedo paralelepipedo = new Paralelepipedo(5.0, 3.0, 4.0);
			Console.WriteLine($"Área do Paralelepípedo: {paralelepipedo.CalcularArea()}");
			Console.WriteLine($"Volume do Paralelepípedo: {paralelepipedo.CalcularVolume()}");
		}	
	}
}
