namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cau1 frm1 = new Cau1();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cau2 frm2 = new Cau2();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cau3 frm3 = new Cau3();
            frm3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cau4 frm4 = new Cau4();
            frm4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cau5 frm5 = new Cau5();
            frm5.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
