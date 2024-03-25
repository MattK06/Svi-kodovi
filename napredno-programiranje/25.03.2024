using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25032024
{
        public partial class Form1 : Form
        {
                public Form1()
                {
                        InitializeComponent();

                }
                List<DateTime> listDatum = new List<DateTime>();
                List<string> listNaziv = new List<string>();
                List<string> listKorisnik = new List<string>();
                private void buttonUnos_Click(object sender, EventArgs e)
                {
                        listDatum.Add(dateTimePicker1.Value.Date);
                        listNaziv.Add(textBox1.Text);
                        listBox1.Items.Add(textBox1.Text + " " + dateTimePicker1.Text + ";");

                }

                private void buttonSpremi_Click(object sender, EventArgs e)
                {
                        int indeks = listBox2.SelectedIndex;
                        string putanja = "";
                        try
                        {
                                putanja = "C:\\3. RT\\" + listBox2.Items[indeks].ToString() + ".txt";
                        }
                        catch
                        {
                                MessageBox.Show("Nisi odabrao korisnika");
                        }
                        string tekst = "";
                        DateTime zamjenaD;
                        string zamjenaT;
                        for(int i = 0; i < listDatum.Count; i++)
                        {
                                for(int j = 0; j < listDatum.Count; j++)
                                {
                                        if (listDatum[i] < listDatum[j])
                                        {
                                                zamjenaD = listDatum[i];
                                                listDatum[i] = listDatum[j];
                                                listDatum[j] = zamjenaD;
                                                zamjenaT = listNaziv[i];
                                                listNaziv[i] = listNaziv[j];
                                                listNaziv[j] = zamjenaT;
                                        }
                                }
                        }
                        for(int i=0; i < listDatum.Count; i++)
                        {
                                tekst += listNaziv[i] + " " + listDatum[i] + ";" + "\n";
                        }
                        try
                        {
                                File.WriteAllText(putanja, tekst);
                        }
                        catch
                        {

                        }

                }

                private void buttonUcitaj_Click(object sender, EventArgs e)
                {
                        listBox1.Items.Clear();
                        int indeks = listBox2.SelectedIndex;
                        string tekst = "";
                        try
                        {
                                 tekst = File.ReadAllText("C:\\3. RT\\" + listBox2.Items[indeks].ToString() + ".txt");
                        }
                        catch
                        {
                                MessageBox.Show("Nisi odabrao korisnika");
                        }
                        string tempr = "";
                        for(int i=0; i < tekst.Length; i++)
                        {
                                Console.WriteLine(tekst[i]);
                                if (tekst[i].Equals(';'))
                                {
                                        listBox1.Items.Add(tempr);
                                        tempr = "";
                                }
                                else
                                    tempr += tekst[i];
                        }
                        
                }

                private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
                {
                        
                        int indeks = listBox1.SelectedIndex;
                        string provjera = "";
                        try
                        {
                                 provjera = listBox1.Items[indeks].ToString();
                        }
                        catch
                        {

                        }
                        string tekst = "";
                        if (provjera.Contains("(ZAVRŠENO)"))
                        {
                                tekst = provjera.Remove(0, 11);
                                try
                                {
                                        listNaziv[indeks] = provjera.Remove(0, 11);
                                }
                                catch { }
                        }
                        else
                        {
                                try
                                {
                                        tekst = "(ZAVRŠENO) " + listBox1.Items[indeks];
                                }
                                catch { }
                                try
                                {
                                        listBox1.Items[indeks] = tekst;
                                }
                                catch { }
                                try
                                {
                                        listNaziv[indeks] = "(ZAVRŠENO) " + listNaziv[indeks];
                                }
                                catch { }
                        }
                }

                private void buttonDodaj_Click(object sender, EventArgs e)
                {
                        listBox2.Items.Add(textBox2.Text);
                        listKorisnik.Add(textBox2.Text);

                }
        }
}
