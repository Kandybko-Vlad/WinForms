namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        string fileName = "text.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileName))
            {
                textBox1.Text = File.ReadAllText(fileName);
            }
            else
            {
                MessageBox.Show("‘айл text.txt не знайдено в папц≥ з програмою!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fileName, textBox1.Text);
            MessageBox.Show("«бережено!");
        }
    }
}
