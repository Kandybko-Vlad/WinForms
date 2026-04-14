namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();
        public Form1()
        {
            InitializeComponent();
            button1.MouseEnter += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxWidth = this.ClientSize.Width - button1.Width;
            int maxHeight = this.ClientSize.Height - button1.Height;
            
            int nextX = _random.Next(0, Math.Max(0, maxWidth));
            int nextY = _random.Next(0, Math.Max(0, maxHeight));

            button1.Location = new Point(nextX, nextY);
        }
    }
}
