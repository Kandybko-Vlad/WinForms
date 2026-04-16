namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private List<int> mineNumbers = new List<int>();
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            score = 0;
            this.Text = "Рахунок: 0";
            mineNumbers.Clear();

            Random rnd = new Random();
            while (mineNumbers.Count < 5)
            {
                int num = rnd.Next(1, 26);
                if (!mineNumbers.Contains(num)) mineNumbers.Add(num);
            }

            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                    c.BackColor = SystemColors.Control;
                    c.Text = "";
                }
            }
        }

        private void AnyButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            string name = clickedButton.Name.Replace("button", "");
            int num = int.Parse(name);

            if (mineNumbers.Contains(num))
            {
                clickedButton.BackColor = Color.Red;
                clickedButton.Text = "💣";
                MessageBox.Show("БАБАХ! Вы програли.");
                StartGame();
            }
            else
            {
                clickedButton.BackColor = Color.Green;
                clickedButton.Enabled = false;
                score++;
                this.Text = "Счёт: " + score;

                if (score == 7)
                {
                    MessageBox.Show("ПЕРЕМОГА! Ви знайшли 7 безпечних зон!");
                    StartGame();
                }
            }
        }
    }
}
