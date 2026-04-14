namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        bool isPlayerTurn = true;
        int turnCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) { PlayMove(button1); }
        private void button2_Click(object sender, EventArgs e) { PlayMove(button2); }
        private void button3_Click(object sender, EventArgs e) { PlayMove(button3); }
        private void button4_Click(object sender, EventArgs e) { PlayMove(button4); }
        private void button5_Click(object sender, EventArgs e) { PlayMove(button5); }
        private void button6_Click(object sender, EventArgs e) { PlayMove(button6); }
        private void button7_Click(object sender, EventArgs e) { PlayMove(button7); }
        private void button8_Click(object sender, EventArgs e) { PlayMove(button8); }
        private void button9_Click(object sender, EventArgs e) { PlayMove(button9); }

        private void PlayMove(Button b)
        {
            if (b.Text != "") return; // Якщо кнопка зайнята — ігноруємо

            if (isPlayerTurn) b.Text = "X";
            else b.Text = "O";

            turnCount++;
            isPlayerTurn = !isPlayerTurn; // Зміна ходу
            b.Enabled = false;           // Вимикаємо кнопку

            CheckForWinner();
        }

        private void CheckForWinner()
        {
            bool win = false;

            // Горизонталі
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") win = true;
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "") win = true;
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "") win = true;
            // Вертикалі
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") win = true;
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") win = true;
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "") win = true;
            // Діагоналі
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") win = true;
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "") win = true;

            if (win)
            {
                string winner = !isPlayerTurn ? "X" : "O";
                MessageBox.Show("Переміг " + winner);
                Application.Restart(); // Перезапуск гри
            }
            else if (turnCount == 9)
            {
                MessageBox.Show("Нічия!");
                Application.Restart();
            }
        }
    }
}
