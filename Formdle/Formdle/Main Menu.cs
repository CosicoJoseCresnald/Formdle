using System.Security.Policy;

namespace Winformdle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int gameModePick = 0;
        public static int languagePick = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            pnlMainMenu.Visible = false;
            pnlLanguage.Visible = false;
            pnlDifficulty.Visible = false;
            pnlGameMode.Visible = true;

        }

        private void lblChooseDifficulty_Click(object sender, EventArgs e)
        {

        }

        //Difficulty
        //EASY
        private void btnEasy_Click(object sender, EventArgs e)
        {
            //GAMEMODE 1
            if (languagePick == 1 && gameModePick == 1)
            {
                this.Hide();
                game1EnglishEasy game1EnglishEasy = new game1EnglishEasy();
                game1EnglishEasy.Show();
            }
            if (languagePick == 2 && gameModePick == 1)
            {
                this.Hide();
                game1FilipinoEasy game1FilipinoEasy = new game1FilipinoEasy();
                game1FilipinoEasy.Show();
            }

            //GAMEMODE 2
            if (languagePick == 1 && gameModePick == 2)
            {
                this.Hide();
                game2EnglishEasy game2EnglishEasy = new game2EnglishEasy();
                game2EnglishEasy.Show();
            }
            if (languagePick == 2 && gameModePick == 2)
            {
                this.Hide();
                game2FilipinoEasy game2FilipinoEasy = new game2FilipinoEasy();
                game2FilipinoEasy.Show();
            }

        }
        //MEDIUM
        private void btnMedium_Click(object sender, EventArgs e)
        {
            //GAMEMODE 1
            if (languagePick == 1 && gameModePick == 1)
            {
                this.Hide();
                game1EnglishMedium game1EnglishMedium = new game1EnglishMedium();
                game1EnglishMedium.Show();
            }
            if (languagePick == 2 && gameModePick == 1)
            {
                this.Hide();
                game1FilipinoMedium game1FilipinoMedium = new game1FilipinoMedium();
                game1FilipinoMedium.Show();
            }



            //GAMEMODE 2
            if (languagePick == 1 && gameModePick == 2)
            {
                this.Hide();
                game2EnglishMedium game2EnglishMedium = new game2EnglishMedium();
                game2EnglishMedium.Show();
            }
            if (languagePick == 2 && gameModePick == 2)
            {
                this.Hide();
                game2FilipinoMedium game2FilipinoMedium = new game2FilipinoMedium();
                game2FilipinoMedium.Show();
            }

        }

        //HARD
        private void btnHard_Click(object sender, EventArgs e)
        {
            //GAMEMODE 1
            if (languagePick == 1 && gameModePick == 1)
            {
                this.Hide();
                game1EnglishHard game1EnglishHard = new game1EnglishHard();
                game1EnglishHard.Show();
            }
            if (languagePick == 2 && gameModePick == 1)
            {
                this.Hide();
                game1FilipinoHard game1FilipinoHard = new game1FilipinoHard();
                game1FilipinoHard.Show();
            }



            //GAMEMODE 2
            if (languagePick == 1 && gameModePick == 2)
            {
                this.Hide();
                game2EnglishHard game2EnglishHard = new game2EnglishHard();
                game2EnglishHard.Show();
            }
            if (languagePick == 2 && gameModePick == 2)
            {
                this.Hide();
                game2FilipinoHard game2FilipinoHard = new game2FilipinoHard();
                game2FilipinoHard.Show();
            }
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            languagePick = 1;
            pnlLanguage.Visible = false;
            pnlDifficulty.Visible = true;
        }

        private void btnTagalog_Click1(object sender, EventArgs e)
        {
            languagePick = 2;
            pnlLanguage.Visible = false;
            pnlDifficulty.Visible = true;
        }

        private void pnlLanguage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1Player_Click(object sender, EventArgs e)
        {
            gameModePick = 1;
            pnlGameMode.Visible = false;
            pnlMainMenu.Visible = false;
            pnlLanguage.Visible = true;
            pnlDifficulty.Visible =false;
        }

        private void btn2Player_Click(object sender, EventArgs e)
        {
            gameModePick = 2;
            pnlGameMode.Visible = false;
            pnlMainMenu.Visible = false;
            pnlLanguage.Visible = true;
            pnlDifficulty.Visible = false;
        }
    }
}
