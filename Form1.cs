namespace Practica_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal1, cal2, cal3, cal4, prom;
            cal1 = double.Parse(textBox1.Text);
            cal2 = double.Parse(textBox2.Text);
            cal3 = double.Parse(textBox3.Text);
            cal4 = double.Parse(textBox4.Text);
            prom = (cal1 + cal2 + cal3 + cal4) / 4;
            textBox5.Text = prom.ToString();

            if (prom < 6) MessageBox.Show(" REPROBADO "); else MessageBox.Show(" APROBADO ");
            if (cal1 < 6) MessageBox.Show(" REPROBADO CAL1 ");
            if (cal2 < 6) MessageBox.Show(" REPROBADO CAL2 ");
            if (cal3 < 6) MessageBox.Show(" REPROBADO CAL3 ");
            if (cal4 < 6) MessageBox.Show(" REPROBADO CAL4 ");





        }
    }
}