using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Color : Form
	{
		private Calculator calculator;
		public Color()
		{
			InitializeComponent();
		}
		public Color(Calculator c)
		{
			InitializeComponent();
			this.calculator = c;
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonBlue.Checked)
			{
				this.calculator.BackColor = System.Drawing.Color.Blue;

			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonGreen.Checked)
			{
				this.calculator.BackColor = System.Drawing.Color.Green;

			}
		}

		private void radioButtonRed_CheckedChanged_1(object sender, EventArgs e)
		{
			if (radioButtonRed.Checked && dateTimePicker1.Value.Year==2022)
			{
				this.calculator.BackColor = System.Drawing.Color.Red;

			}
			else if(radioButtonRed.Checked && dateTimePicker1.Value.Year != 2022)
			{
				this.calculator.BackColor = System.Drawing.Color.Yellow;
			}
		}

		private void Color_Load(object sender, EventArgs e)
		{

		}

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			this.Close();
			this.calculator.BackColor = Color.DefaultBackColor;
		}
	}
}
