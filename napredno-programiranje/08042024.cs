using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08042024
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}
		
		List<string> proizvodi = new List<string>();
		List<DateTime> rok_trajanja = new List<DateTime>();
		string putanje = "C:\\3. RT\\povijest_proizvoda.txt";
		private void buttonKupi_Click(object sender, EventArgs e)
		{
			if (textBoxProizvod.Text == "" || textBoxProizvod.Text == " " || textBoxProizvod.Text == "  ") { }
			else
			{
				int PROVJERA2 = 0;
				for (int i = 0; i < listBoxPovijest.Items.Count; i++)
				{
					if (listBoxPovijest.Items[i].ToString() == textBoxProizvod.Text)
						PROVJERA2 = 1;
				}
				if (PROVJERA2 == 0)
					File.AppendAllText(putanje, textBoxProizvod.Text + ";");

			}
			if (textBoxProizvod.Text=="" || textBoxProizvod.Text == " " || textBoxProizvod.Text == "  ")
			{
				MessageBox.Show("Niste unesli proizvod");
			}
			else
			{
				int PROVJERA = 0;
				proizvodi.Add(textBoxProizvod.Text);
				listBoxProizvod.Items.Add(textBoxProizvod.Text);
				for (int i = 0; i < listBoxPovijest.Items.Count; i++)
				{
					if (listBoxPovijest.Items[i].ToString() == textBoxProizvod.Text)
						PROVJERA = 1;
				}
				if(PROVJERA == 0)
					listBoxPovijest.Items.Add(textBoxProizvod.Text);
			}
			DateTime datumSedam = DateTime.Today.AddDays(7);
			if (textBoxProizvod.Text == "" || textBoxProizvod.Text == " " || textBoxProizvod.Text == "  ") { }
			else
			{
				if (dateTimePickerRokTrajanja.Value <= DateTime.Today)
				{

					listBoxIsteklo.Items.Add(textBoxProizvod.Text + " " + dateTimePickerRokTrajanja.Value.ToShortDateString());
				}
				if (dateTimePickerRokTrajanja.Value > DateTime.Today && dateTimePickerRokTrajanja.Value <= datumSedam)
				{
					listBoxDani.Items.Add(textBoxProizvod.Text + " " + dateTimePickerRokTrajanja.Value.ToShortDateString());
				}
			}

		}

		private void buttonKupiOpet_Click(object sender, EventArgs e)
		{
			DateTime datumSedam = DateTime.Today.AddDays(7);
			try
			{
				int indeks = listBoxPovijest.SelectedIndex;
				proizvodi.Add(listBoxPovijest.Items[indeks].ToString());
				listBoxProizvod.Items.Add(listBoxPovijest.Items[indeks].ToString());
				if (textBoxProizvod.Text == "" || textBoxProizvod.Text == " " || textBoxProizvod.Text == "  ") { }
				else
				{
					if (dateTimePickerRokTrajanja2.Value <= DateTime.Today)
					{

						listBoxIsteklo.Items.Add(listBoxPovijest.Items[indeks].ToString() + " " + dateTimePickerRokTrajanja2.Value.ToShortDateString());
					}
					if (dateTimePickerRokTrajanja2.Value > DateTime.Today && dateTimePickerRokTrajanja2.Value <= datumSedam)
					{
						listBoxDani.Items.Add(listBoxPovijest.Items[indeks].ToString() + " " + dateTimePickerRokTrajanja2.Value.ToShortDateString());
					}
				}
			}
			catch
			{
				MessageBox.Show("Niste odabrali koji proizvod želite opet kupit");
			}
			

		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			File.WriteAllText(putanje, "");
			listBoxPovijest.Items.Clear();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string putanje = "C:\\3. RT\\povijest_proizvoda.txt";
			string tekst = File.ReadAllText(putanje);
			string tempr = "";
			for (int i = 0; i < tekst.Length; i++)
			{
				if (tekst[i].Equals(';'))
				{
					listBoxPovijest.Items.Add(tempr);
					tempr = "";
				}
				else
					tempr += tekst[i];

			}
		}

		
	}
}
