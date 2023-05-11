namespace Moja_2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int suma = 0;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            suma = (int)numericUpDown1.Value;
            suma += (int)numericUpDown2.Value;
            label1.Text = "Suma: " + suma.ToString();
            if (suma > 10)
            {
                label1.ForeColor = Color.Pink;
            }
            if (suma > 30)
            {
                label1.ForeColor = Color.Black;
            }
            if (suma > 50)
            {
                label1.ForeColor = Color.Green;
            }
            if (suma > 70)
            {
                label1.ForeColor = Color.Blue;
            }
            if (suma > 80)
            {
                label1.ForeColor = Color.Gold;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            suma = (int)numericUpDown1.Value;
            suma += (int)numericUpDown2.Value;
            label1.Text = "Suma: " + suma.ToString();
            if (suma > 10)
            {
                label1.ForeColor = Color.Pink;
            }
            if (suma > 30)
            {
                label1.ForeColor = Color.Black;
            }
            if (suma > 50)
            {
                label1.ForeColor = Color.Green;
            }
            if (suma > 70)
            {
                label1.ForeColor = Color.Blue;
            }
            if (suma > 80)
            {
                label1.ForeColor = Color.Gold;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
        }
    }
}