namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string[] images = {
        "Images/1.jpg", "Images/2.jpg", "Images/3.jpg", "Images/4.jpg", "Images/5.jpg", "Images/6.jpg"};
        private int currentIndex = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.ImageLocation = images[currentIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = images.Length - 1;
            }
            pictureBox1.ImageLocation = images[currentIndex];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= images.Length)
            {
                currentIndex = 0;
            }
            pictureBox1.ImageLocation = images[currentIndex];
        }
    }
}
