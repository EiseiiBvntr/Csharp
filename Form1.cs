namespace Activity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int a = int.Parse(textBox1.Text);
            for (int i = a; i >= 1; i--)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
           int mul = int.Parse(txtmultbl.Text);
            for (int i = 1; i <= 10; i++) {
                
                listBox2.Items.Add(mul+"x"+i+"="+mul*i);
            
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            int a = int.Parse(textBox3.Text);
            int ngek = 1;
            int num2 = 3;
            while (a >= 1)
            {
                listBox3.Items.Add(ngek);
                ngek += num2;
                num2 += 2;
                a--;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {



        }
    }
}

