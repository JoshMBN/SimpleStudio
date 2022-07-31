namespace DungeonCrawler
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
           panel1.Visible = true;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            playButton.Image = DungeonCrawler.Properties.Resources.playHover;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            playButton.Image = DungeonCrawler.Properties.Resources.playButton;
        }

        private void loadButton_MouseHover(object sender, EventArgs e)
        {
            loadButton.Image = DungeonCrawler.Properties.Resources.loadHover;
        }

        private void loadButton_MouseLeave(object sender, EventArgs e)
        {
            loadButton.Image = DungeonCrawler.Properties.Resources.loadButton;
        }

        private void optionsButton_MouseHover(object sender, EventArgs e)
        {
            optionsButton.Image = DungeonCrawler.Properties.Resources.optionsHover;
        }

        private void optionsButton_MouseLeave(object sender, EventArgs e)
        {
            optionsButton.Image = DungeonCrawler.Properties.Resources.optionsButton;
        }

        private void exitButton_MouseHover(object sender, EventArgs e)
        {
            exitButton.Image = DungeonCrawler.Properties.Resources.exitHover;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.Image = DungeonCrawler.Properties.Resources.exitButton;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }

        private void loadButton_Click(object sender, EventArgs e)
        {

        }

        private void optionsButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }
    }
}