using System.Diagnostics;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            InitializeComponent();
            stopwatch.Stop();
            TimeSpan timeElapsed = stopwatch.Elapsed;


            if (timeElapsed.TotalMilliseconds > 10)
            {
                EventLog.WriteEntry("Application", $"Czas inicjalizacji przekroczy³ 10 ms: {timeElapsed.TotalMilliseconds} ms", System.Diagnostics.EventLogEntryType.Warning);
            }
           
        }
        private double val = 0;
        private string operation = "";

        private void Num_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text += button.Text;
        }

        private void Dzial_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            val = double.Parse(label1.Text);
            label1.Text = "";
        }

        private void Wynik_Click(object sender, EventArgs e)
        {
            double liczba_2 = double.Parse(label1.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = val + liczba_2;
                    break;
                case "-":
                    result = val - liczba_2;
                    break;
                case "*":
                    result = val * liczba_2;
                    break;
                case "/":
                    if (liczba_2 != 0)
                        result = val / liczba_2;
                    else
                    {

                        System.Diagnostics.EventLog.WriteEntry("Application", "Dzielenie przez zero", System.Diagnostics.EventLogEntryType.Error);
                        MessageBox.Show("Nie mo¿na dzieliæ przez zero.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }

            label1.Text = result.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            val = 0;
            operation = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
