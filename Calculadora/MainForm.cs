using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		Button soma = new Button();
		Button Subtração = new Button();
		Button Multiplicação = new Button();
		Button Divisão = new Button();
		TextBox valor1 = new TextBox();
		TextBox valor2 = new TextBox();
		Label tempo = new Label();
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
			tempo.Parent = this;
			tempo.Text ="Estou Aqui";
			
			//---------------------------------------------------------//
			valor1.Parent = this;
			valor1.Height = 25;
			valor1.Width = 120;
			valor1.Top = 50;
			valor1.Left = 30;
			valor1.Name = "textbox1";
			//---------------------------------------------------------//
			valor2.Parent = this;
			valor2.Height = 25;
			valor2.Width = 120;
			valor2.Top = 50;
			valor2.Left = 180;
			valor2.Name = "textbox2";
			//---------------------------------------------------------//
			soma.Parent = this;
			soma.Text = "Somar";
			soma.Height = 50;
			soma.Width = 120;
			soma.Top = 170;
			soma.Left = 20;
			//--------------------------------------------------------//
			Subtração.Parent = this;
			Subtração.Text = "Subtrair";
			Subtração.Height = 50;
			Subtração.Width = 120;
			Subtração.Top = 170;
			Subtração.Left = 170;
			//--------------------------------------------------------//
			Multiplicação.Parent = this;
			Multiplicação.Text = "Multiplicar";
			Multiplicação.Height = 50;
			Multiplicação.Width = 120;
			Multiplicação.Top = 250;
			Multiplicação.Left = 170;
			//-------------------------------------------------------//
			Divisão.Parent = this;
			Divisão.Text = "Dividir";
			Divisão.Height = 50;
			Divisão.Width = 120;
			Divisão.Top = 250;
			Divisão.Left = 20;
		}
		void somaClick(object sender, EventArgs e){
			tempo.Text = int.Parse(valor1.Text) + int.Parse(valor2.Text).ToString();
 		}
	}
}
