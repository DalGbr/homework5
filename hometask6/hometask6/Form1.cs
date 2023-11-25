namespace hometask6
{
    public partial class Form1 : Form
    {
        int generatedChoice;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            computerChoice number = new computerChoice();
            generatedChoice = number.returnChoice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int playerChoice = int.Parse(textBox1.Text);

            if ((generatedChoice == 1 && playerChoice == 3) || (generatedChoice == 3 && playerChoice == 1))
            {
                label3.Text = generatedChoice.ToString();
                label4.Text = "Rock smashes scissors";
            }
            else if ((generatedChoice == 3 && playerChoice == 2) || (generatedChoice == 2 && playerChoice == 3))
            {
                label3.Text = generatedChoice.ToString();
                label4.Text = "Scissors cuts paper";
            }
            else if ((generatedChoice == 2 && playerChoice == 1) || (generatedChoice == 1 && playerChoice == 2))
            {
                label3.Text = generatedChoice.ToString();
                label4.Text = "Paper wraps rock";
            }
            else
            {
                label3.Text = generatedChoice.ToString();
                label4.Text = "Tie";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }

    class computerChoice
    {
        int choice;
        public computerChoice()
        {
            Random rnd = new Random();
            choice = rnd.Next(1, 4);
        }

        public int returnChoice()
        {
            return choice;
        }
    }
}