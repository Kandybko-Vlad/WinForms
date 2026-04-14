namespace WinFormsApp3
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
                string word = textBox1.Text;

                // перевірка чи введено слово
                if (string.IsNullOrWhiteSpace(word))
                {
                    MessageBox.Show("Введіть слово для пошуку!");
                    return;
                }

                string[] lines = File.ReadAllLines("text.txt");

                int count = 0;
                string foundLines = "";

                foreach (string line in lines)
                {
                    int occurrences = line.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                                          .Count(w => w.Equals(word, StringComparison.OrdinalIgnoreCase));

                    if (occurrences > 0)
                    {
                        count += occurrences;
                        foundLines += line + "\n";
                    }
                }

                if (count > 0)
                {
                    MessageBox.Show(
                        "Слово знайдено!\n" +
                        "Кількість: " + count + "\n\n" +
                        "Рядки:\n" + foundLines
                    );
                }
                else
                {
                    MessageBox.Show("Слово не знайдено.");
                }
            }
            catch
            {
                MessageBox.Show("Помилка при читанні файлу!");
            }
        }
    }
}
