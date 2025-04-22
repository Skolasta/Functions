namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        double diameter, radius, circumferenceOfTheCircle, Area;
        const double pi = 3.14;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            diameter = Convert.ToDouble(textBox5.Text);
            radius = diameter / 2;
            label7.Text = radius.ToString();
            circumferenceOfTheCircle = 2 * pi * radius;
            label8.Text = Math.Round(cir, 2).ToString();
            Area = pi * radius * radius;
            label9.Text = Area.ToString();



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
