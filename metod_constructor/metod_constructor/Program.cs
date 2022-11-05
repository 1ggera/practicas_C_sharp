using System;

/* Constructor
 * Basicamente, es el método q contruye la aplicación. Es muy usado para inicializar variables.
 * Es el primer método llamado y contiene todos los datos para darle apariencia a nuestro programa cuando lo inicio. Puede incluir mensajes.
 * Tiene un aspecto predefinido con altura, anchura y color. 
*/

namespace metod_constructor
{
	class Program
	{
		public static void Main(string[] args)
		{
			//instancio una variable de ventana
			ventana calculadora = new ventana();
			
			//el primer mensaje será lo grabado en el método constructor.
			
			//Luego mostrará lo llamado por la función 'mostrar'
			//calculadora.Mostrar();
			
			Console.ReadKey();
		}
	}
	
	class ventana{
		//Atributos -> se declaran, luego cuando sean usados se les asigna valores.
		private int ancho, altura;
		private string color;
		
		//El método constructor se identifica al llamarlo igual que a su clase padre.
		// nombre + (){}
		//El constructor no tiene tipo. SOLO hay q indicar que referencia va a tener (public, private, protected).
		public ventana(){
			
			ancho = 15;
			altura = 20;
			color="rojo";
			Console.WriteLine("Primero se llamó a este metod constructor.");
		}
		
		public void Mostrar()
		{
			Console.WriteLine("La ventana es una window de: "+ancho+" x "+altura+ " y su color es: "+color);
		}
		
		/*	Destructor ~ -> (Alt+126)
 		*	Es una función que se inicia al cerrar el programa y limpia/libera los procesos/recursos usados al inicializarse el programa.
		*	Es llamado por el Garbage Collector del .NET framework.  
 		*/		
		~ventana(){
			//Es un mensaje diagostico. No se imprime por pantalla
			System.Diagnostics.Trace.WriteLine("Se destruyeron los datos cargados en el constructor");
			//Para ver este mensaje ir a 
		}
	}
}

