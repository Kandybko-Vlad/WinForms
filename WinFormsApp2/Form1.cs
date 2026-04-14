namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines("prices.txt");
                double[] prices = lines.Select(x => double.Parse(x)).ToArray();

                double sum = prices.Sum();
                double average = prices.Average();
                double max = prices.Max();
                double min = prices.Min();
                int countOver100 = prices.Count(x => x > 100);

                MessageBox.Show(
                    "Сума: " + sum + "\n" +
                    "Середнє: " + average + "\n" +
                    "Максимум: " + max + "\n" +
                    "Мінімум: " + min + "\n" +
                    "Дорожче 100 грн: " + countOver100
                );
            }
            catch
            {
                MessageBox.Show("Помилка при читанні файлу!");
            }
        }
    }
}
