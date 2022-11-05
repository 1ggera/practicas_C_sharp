/*
 * Created by SharpDevelop.
 * User: 1
 * Date: 3/10/2022
 * Time: 03:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO; //librería que permite trabajar con archivos. In/Out

namespace archivos
{
	class Program
	{
		public static void Main(string[] args)
		{	
			// In/Out permite crear variables de tipo objeto q serán tratados como archivo. Parecido a manejar matrices.
			
			Console.WriteLine("Hello World!");
			/*	Textwriter
			Siempre crea un archivo
			 
			//creo una variable tipo TextWriter para crear y escribir un archivo.
			TextWriter archivo; 
			
			//instancio para crear un archivo de cualquier extensión que quiera. Ej: un archivo .txt
			archivo = new StreamWriter("archivo.txt"); //ahora el archivo está creado y en uso
			
			//creo una variable para guardar un mensaje dentro de mi archivo
			string mensaje;
			
			mensaje = Console.ReadLine(); //indicación para gurdar todo lo q escriba en la variable mensaje.

			//significa: sobre la instancia archivo, escribe una linea del mensaje que grabé en 'mensaje'.
			archivo.WriteLine(mensaje); //imprime el mensaje captado en 'mensaje'
			
			//Es importante cerrar los archivos abiertos, sino se pierde la información.
			archivo.Close();
			
			Console.Clear(); //limpio la pantalla
			
			Console.WriteLine("¡Tu mensaje se guardó en el archivo!");//me imprimo un mensaje de confirmación.
			
			
			//TextReader
			PARA LEER un archivo.
			
			TextReader leerArchivo;
			
			leerArchivo = new StreamReader("archivo.txt");//StreamReader para leer el archivo "x"
			
			//Para mostrar en pantalla todo lo que está leyendo
			//Console.WriteLine(leerArchivo.ReadLine()); -> lee UNA sola linea
			Console.WriteLine(leerArchivo.ReadToEnd()); // permite la lectura completa de los archivos.
			
			leerArchivo.Close();
		*/
			//StreamWriter crea una variable q lee un File y agrega Texto sobre el archivo "x.algo"
			StreamWriter archivo = File.AppendText("archivo.txt");
		
			string mensaje;
			mensaje = Console.ReadLine();//capta el mensaje escrito
			
			archivo.WriteLine(mensaje); //muestra el mensaje junto con el texto anteriormente agregado.
			
			archivo.Close();//cierro el archivo.
		
			Console.ReadKey();//cierro la aplicación.
		}
	}
}