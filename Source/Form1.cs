namespace Source
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_timer.Text = DateTime.Now.ToLongTimeString();

            if(progressBar1.Value == progressBar1.Maximum)
                progressBar1.Value = progressBar1.Minimum;

            progressBar1.PerformStep();
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            statusLabel.Text = e.Location.ToString();
        }
    }
}