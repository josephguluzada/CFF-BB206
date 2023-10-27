namespace ProgressBarApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 10000;
            progressBar2.Maximum = 10000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Fill1);
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Fill2);
            thread.Start();
        }

        private void Fill1()
        {
            for (int i = 0; i < 10000; i++)
            {
                progressBar1.Value = i;
            }
        }

        private void Fill2()
        {
            for (int i = 0; i < 10000; i++)
            {
                progressBar2.Value = i;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Thread thread1 = new Thread(Fill1);
            //thread1.Start();

            //Thread thread2 = new Thread(Fill2);
            //thread2.Start();
            Fill1();
            Fill2();
        }
    }
}