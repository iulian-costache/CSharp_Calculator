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
	public partial class Calculator : Form
	{
		private int stanga;
		private int dreapta;
		public Calculator()
		{
			InitializeComponent();
		}

		public void modificaTextBox()
		{
			if (tBoxInput.Text == "0")
			{
				tBoxInput.Text = string.Empty;
			}
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			modificaTextBox();
			tBoxInput.Text += "1";

		}

		private void button2_Click(object sender, EventArgs e)
		{
			modificaTextBox();
			tBoxInput.Text += "2";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			modificaTextBox();
			tBoxInput.Text += "3";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			modificaTextBox();
			tBoxInput.Text += "4";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			modificaTextBox();
			tBoxInput.Text += "5";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			modificaTextBox();
			tBoxInput.Text += "6";
		}

		private void button7_Click(object sender, EventArgs e)
		{
			modificaTextBox();
			tBoxInput.Text += "7";
		}

		private void button8_Click(object sender, EventArgs e)
		{
			modificaTextBox();
			tBoxInput.Text += "8";
		}

		private void button9_Click(object sender, EventArgs e)
		{
			modificaTextBox();
			tBoxInput.Text += "9";
		}

		private void buttonPlus_Click(object sender, EventArgs e)
		{
			try
			{
				this.stanga = int.Parse(tBoxInput.Text);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
			labelRez.Text = this.stanga.ToString() + " + ";
			tBoxInput.Text = "0";
		}

		private void button0_Click(object sender, EventArgs e)
		{

			if (tBoxInput.Text != "0")
			{
				tBoxInput.Text += "0";
			}
		}

		private void buttonEquals_Click(object sender, EventArgs e)
		{
			try
			{
				this.dreapta = int.Parse(tBoxInput.Text);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
			int rezultat = this.stanga + this.dreapta;
			tBoxInput.Text = rezultat.ToString();
			//labelRez.Text = string.Empty;
			labelRez.Text += this.dreapta.ToString() + " = " + rezultat.ToString();
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			tBoxInput.Text = "0";
			labelRez.Text = string.Empty;
		}

		private void Calculator_Load(object sender, EventArgs e)
		{
			tBoxInput.Text = "0";
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			modificaTextBox();
			tBoxInput.Text=tBoxInput.Text.Remove(tBoxInput.Text.Length - 1, 1);
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			new About().Show();
			this.Hide();
		}

		private void changeCalculatorColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Color(this).Show();
		}
	}
}
