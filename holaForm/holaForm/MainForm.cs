using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//los using son librerias q contienen clases, y esas clases tienen funciones que podemos usar.

namespace holaForm
{
	//La clase nombrada MainForm está heredando las propiedades/funciones de Form. Y Form viene de WindowsForm.
	public partial class MainForm : Form
	{
		public MainForm() // -> Tiene (), es una funcion, con el mismo nombre q la clase, entonces es un 'constructor' 
		{
			InitializeComponent(); // método heredado de Form. Inicializa un componente visual. 
		}
		
		//metodo q referencia al botón 1
		//en este caso es void pero puede ser int,float,etc
		//object -> es una declaración como void o int.
		//sender -> variable que será tratada como un objeto
		//EventArgs -> indica q espera eventos
		//esos eventos serán guardados en 'e'
		private void Button1Click(object sender, EventArgs e)
		{
			//this -> hace referencia a la clase sobre la q se está trabajando. En este caso es MainForm
			//con el . aparecen los metodos/atributos disponibles de usar
			this.Close(); //ahora cuando dé click se cierra la ventana.
		}
	}
}
