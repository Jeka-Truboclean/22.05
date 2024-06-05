namespace _22._05
{
    public partial class Form1 : Form
    {
        private int speed;
        public Form1()
        {
            InitializeComponent();
            CenterButton();
            speed = hScrollBar1.Value;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }
        private void CenterButton()
        {
            button1.Left = (this.ClientSize.Width - button1.Width) / 2;
            button1.Top = (this.ClientSize.Height - button1.Height) / 2;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            button1.Left -= speed;
            if (button1.Left < 0)
            {
                button1.Left = this.ClientSize.Width - button1.Width;
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            speed = hScrollBar1.Value;
        }
    }
}
