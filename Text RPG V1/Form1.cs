using System.Security.Cryptography;

namespace Text_RPG_V1
{
    public partial class Game : Form
    {
        public string playerName;
        public bool playerNameIsSet = false, gameHasStarted = false, roomEventHasFinished = true, playerIsAlive = true;
        public int playerHealth, playerMana, currentRoomNumber, goldCount;
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            txtOutputGame.Text = "Welcome! Please select a name, confirm it and then press Start!";
        }

        private void txtInputName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmName_Click(object sender, EventArgs e)
        {
            playerName = txtInputName.Text;

            if (playerName.Length == 0)
            {
                txtOutputGame.Text += Environment.NewLine + "ERROR: You haven't entered a name, try again!";
            }
            else
            {
                txtOutputGame.Text += Environment.NewLine + "Name changed to [" + playerName + "] succesfully!";
                playerNameIsSet = true;
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtOutputPlayerHealth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOutputPlayerMana_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (playerNameIsSet == false)
            {
                txtOutputGame.Text += Environment.NewLine + "ERROR: You haven't selected a name yet! Type in a name and press Start again.";
                return;
            }

            gameHasStarted = true;

            playerHealth = 100;
            playerMana = 100;
            currentRoomNumber = 0;
            goldCount = 0;

            txtOutputPlayerHealth.Text = playerHealth.ToString();
            txtOutputPlayerMana.Text = playerMana.ToString();
            txtOutputCurrentRoom.Text = currentRoomNumber.ToString();
            txtOutputGoldCount.Text = goldCount.ToString();

            txtOutputGame.Text += Environment.NewLine;
            txtOutputGame.Text += Environment.NewLine + "Your name is " + playerName + ", and you decide to step into a dungeon that is rumoured full of wonders and treasures.";
            txtOutputGame.Text += Environment.NewLine + "You go inside the dungeon and see that all the rooms and doors are the same.";
            txtOutputGame.Text += Environment.NewLine + "You accept your fate and properly enter the dungeon...";
        }

        private void updateStatCounter(RichTextBox textBox, ref int counter, string operation, int updateValue)         //Function updates the counter AND the actual value.
        {
            if (operation == "+")
            {
                counter = counter + updateValue;
            }
            else 
            {
                counter = counter - updateValue;
            }

            textBox.Text = counter.ToString();
        }

        private void btnGoNextRoom_Click(object sender, EventArgs e)
        {
            if (gameHasStarted == false)
            {
                txtOutputGame.Text += Environment.NewLine + "ERROR: Game hasn't started yet!";
                return;
            }
            else if (roomEventHasFinished == false)
            {
                txtOutputGame.Text += Environment.NewLine + "ERROR: Room event hasn't finished yet!";
                return;
            }
            else if (playerIsAlive == false) 
            {
                txtOutputGame.Text += Environment.NewLine + "ERROR: You are dead!";
                return;
            }

            roomEventHasFinished = false;

            updateStatCounter(txtOutputCurrentRoom, ref currentRoomNumber, "+", 1);

            txtOutputGame.Text += Environment.NewLine;
            txtOutputGame.Text += Environment.NewLine + "You entered into the next room...";

            roomEvent();

            roomEventHasFinished = true;
        }

        private int numberGenerator(int a, int b)       //This works perfectly, it was tested too.
        {
            Random random = new Random();

            int randomNumber = random.Next(a, b);

            return randomNumber;
        }

        private void roomEvent()
        {
            int eventId = numberGenerator(1, currentRoomNumber);

            switch (eventId)
            {
                case 1:     //you find 50 gold.
                    txtOutputGame.Text += Environment.NewLine + "You found 50 gold.";
                    updateStatCounter(txtOutputGoldCount, ref goldCount, "+", 50);
                    break;

                case 2:     //you find 25 gold.
                    txtOutputGame.Text += Environment.NewLine + "You found 25 gold.";
                    updateStatCounter(txtOutputGoldCount, ref goldCount, "+", 25);
                    break;

                case 3:     //you find 10 gold.
                    txtOutputGame.Text += Environment.NewLine + "You found 10 gold.";
                    updateStatCounter(txtOutputGoldCount, ref goldCount, "+", 10);
                    break;

                case 4:     //you find 2 gold.
                    txtOutputGame.Text += Environment.NewLine + "You found 10 gold.";
                    updateStatCounter(txtOutputGoldCount, ref goldCount, "+", 10);
                    break;

                case 5:
                    txtOutputGame.Text += Environment.NewLine + "You found a single gold coin.";
                    updateStatCounter(txtOutputGoldCount, ref goldCount, "+", 1);
                    break;

                case 6:
                    txtOutputGame.Text += Environment.NewLine + "You found DEATH.";
                    playerHealth = 0;
                    playerIsAlive = false;
                    playerDeathEvent();
                    break;
            }

        }

        private void playerDeathEvent()
        {
            playerHealth = 0;

            txtOutputGame.Text += Environment.NewLine + "X - - YOU DIED!- - X";
            txtOutputGame.Text += Environment.NewLine;

            txtOutputPlayerHealth.Text = "0";
            
        }

    }
}
