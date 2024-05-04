using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dzielenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double wynik =0;
                double liczbaA = double.Parse(textBox1.Text);
                double liczbaB = double.Parse(textBox2.Text);   

                if ( liczbaB == 0)
                {
                    throw new DivideByZeroException("Próba dzielenia przez zero niedopuszczalna");
                }

                wynik = liczbaA/liczbaB;
                label1.Text = wynik.ToString();

            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Nie dzielimy przez zero");
                EventLog.WriteEntry("Application", "Błąd próba dzielenia przez zero");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wpisz w pola liczby");
                EventLog.WriteEntry("Application", "Błąd danych nieprawidłowy format");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Coś poszło nie tak Error");
                EventLog.WriteEntry("Application", "Błąd Niespodziewany problem");
            }
        }

    



    //Właściwie to tak można by to zrobić bez obsługi try catch
    internal bool checkNumber(object checkValue)
        {
            if ( checkValue != null) 
            { 
             if ( checkValue.GetType() == typeof(int) ) 
                {
                    return true;
                }
             else
                {
                    return false;
                }

            }
            return false;
        }
    }
}
