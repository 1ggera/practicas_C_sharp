using System;

namespace clases //nombre de la superclase
{
	class Program //nombre de la clase principal
	{
		static void Main(string[] args) //clase principal tipo static
		{
			// 2do paso: creo la instancia de la clase 'ventana'.
			//nombre de la clase, le doy un nombre al nuevo objeto (Ej: calculadora.).
			//ahora 'calculadora' hereda todos los atrib y metods de ventana.
			ventana calculadora = new ventana();
			
			// calculadora. -> al escribir un . se pueden ver los métodos/funciones heredados.
		// No se podrá acceder a 'Minimizar' porque es private	
			//calculadora.
			
			calculadora.Cerrar();
			
			Console.ReadKey();
		}
	}
	
	// 1er paso: declaro una clase. Va a tener métodos y propiedades
	class ventana
	{
		//Atributos
		private int ancho=20, altura=25;
		private string color = "Rojo";
		
		//Métodos -> suelen ser públicos. Si es void no devuelve nada.
		public void Cerrar()
		{
			Console.WriteLine("La ventana se cerró");
		}
		
		private void Minimizar()
		{
			Console.WriteLine("La ventana se minimizó");
		}
		
		protected void Maximizar()
		{
			Console.WriteLine("La ventana se maximizó");
		}
	}
}












/*
 C# genera un código encapsulado porque es un lenguaje orientado a objetos.
 Crea una clase con:
					  espacio de nombre
						  clase
						  	atributos
						  		métodos
	  		
  class Program	-> clase q se crea por defecto.
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}		
   
Los programas generalmente NO trabajan con una sola clase sino varias.
Justamente POO me permite programar mi programa parte por parte.
Que trabajando en conjunto dan como resultado final un programa.
	
Si quisiera crear otra clase:

	class Program	-> clase q se crea por defecto.
	{
		//Atributos -> son variables. Tienen diferentes tipos.
		
		//se puede acceder desde cualquier parte del programa. Se puede llamar desde otra clase.
		public int ancho;
		
		//es privada. Solo se accede a ella desde esta misma clase.
		private int ancho;
		
		//cuando necesito que un atributo cambie automaticamente sin importar en q parte del programa esté siendo usado.
		static int ancho;
		
		//Protege los atributos/métodos NO como private.
		No se puede acceder desde afuera. Pero sí se puede desde instancias derivadas de esta clase.    
		protected int ancho;
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}		
 */