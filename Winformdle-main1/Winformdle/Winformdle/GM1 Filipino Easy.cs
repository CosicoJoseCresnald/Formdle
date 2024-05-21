using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winformdle
{
    public partial class game1FilipinoEasy : Form
    {
        public game1FilipinoEasy()
        {
            InitializeComponent();
        }

        //CHECKS WHAT ATTEMPT THE USER IS IN
        static bool attempt1 = true;
        static bool attempt2 = false;
        static bool attempt3 = false;
        static bool attempt4 = false;
        static bool attempt5 = false;
        static bool attempt6 = false;

        public static string[] wordInventory ={ "AGILA", "ABAKA", "ABONO", "AGHAM", "AGWAT", "AGILA", "ALYAS", "ANTIK", "AKALA", "AKLAT", "AKTOR", "AKYAT", "ALAGA", "ALYAS",
"AMBAG", "ALAGA", "AMBON", "BABAE", "BAHAY", "BATIS", "BATOK", "BANGO", "BASAG", "BENTA", "BUTAS", "BAGYO", "BINHI", "BUHAY", "BUKID", "BULAK", "BALOT", "BATOK", "BAKAL",
"BANSA", "BALDE", "BASAG", "BENTE", "DAGSA", "DANAS", "DAHON", "DAPAT", "DIKTA", "DASAL", "DAGAT", "DAGTA", "DAPIT", "DUWAG", "DROGA", "EPIKO", "ETIKA", "GANTI", "GABOK",
"GANDA", "GALIT", "GALAW", "GABAY", "GAMIT", "GUSTO", "GINTO", "GULAT", "GILID", "GANSA", "GUHIT", "GRIPO", "GAANO", "GALON", "GANAP", "GAPOS", "GATAS", "GAWAD", "GAYAK",
"GINOO", "GUBAT", "GUSOT", "GUTOM", "HABAG", "HABAS", "HALIK", "HATID", "HAPDI", "HAWAK", "HANGA", "HANDA", "HARAP", "HABAG", "HABOL", "HALAW", "HAMOG", "HALOS", "HANAY",
"HAMON", "HALOS", "HANDA", "HAPAG", "HAPON", "HAWIG", "HAYOP", "HENYO", "HIBLA", "HIGAD", "HIKAW", "HILOT", "HINGA", "HINOG", "HIRIT", "IMAHE", "IDOLO", "ITLOG", "IGLAP",
"INDAK", "IGLAS", "IMBAK", "ILONG", "IMBIS", "INGAY", "IMPOK", "JAKOL", "LAMIG", "LINTA", "LUGAW", "LIGAW", "LABAS", "LABAG", "LIBAG", "LABAN", "LAGOT", "LAHAT", "LAHOK",
"LAKAS", "LALIM", "LAMAN", "LAMON", "LAMOK", "LANTA", "LASON", "LAWAY", "LISTO", "LIBOG", "LIBRO", "LIHIM", "MANOK", "MADRE", "MADLA", "MAHAL", "MALAY", "MARSO", "MERON",
"MORGE", "MOTOR", "MULTO", "MULAT", "MUNTI", "MUTYA", "NANAY", "NEGRO", "NIYOG", "NOBYA", "NOBYO", "NUNAL", "OPERA", "PATAY", "PALIT", "PALDO", "PAGOD", "PADRE", "PAKAY",
"PAKSA", "PALAD", "PALAY", "PALDA", "PANIG", "PANYO", "PAPEL", "PATAG", "PATOK", "RABIS", "RAMPA", "RASON", "RADYO", "ROSAS", "SAKIT", "SANTO", "SAKAL", "SOBRA", "SIKAT",
"SUKAT", "SABON", "SABOG", "SAGOT", "SANIB", "SAHOG", "SAKIT", "SAKOP", "SAMPO", "SANDO", "SANHI", "SAPAT", "SAPOT", "SARSA", "SEPAK", "SIBOL", "SIBIL", "SIGLA", "SIKAP",
 "WASER"  };

        //Guessword Randomizer
        public static Random random = new Random();

        public static int randomGuessWord = random.Next(wordInventory.Length);
        //public static string guessWord = wordInventory[randomGuessWord];
        public static string guessWord = wordInventory[randomGuessWord];

        //WHEN USER CLICKS Q BUTTON
        private void qBtn_Click(object sender, EventArgs e)
        {
            //attempt1 
            Inputkey("Q");

        }
        //WHEN USER CLICKS W BUTTON
        private void wBtn_Click(object sender, EventArgs e)
        {
            Inputkey("W");
        }
        //WHEN USER CLICKS E BUTTON
        private void eBtn_Click(object sender, EventArgs e)
        {
            Inputkey("E");
        }
        //WHEN USER CLICKS R BUTTON
        private void rBtn_Click(object sender, EventArgs e)
        {
            Inputkey("R");
        }
        //WHEN USER CLICKS T BUTTON
        private void tBtn_Click(object sender, EventArgs e)
        {
            Inputkey("T");
        }
        //WHEN USER CLICKS Y BUTTON
        private void yBtn_Click(object sender, EventArgs e)
        {
            Inputkey("Y");
        }
        //WHEN USER CLICKS U BUTTON
        private void uBtn_Click(object sender, EventArgs e)
        {
            Inputkey("U");
        }
        //WHEN USER CLICKS I BUTTON
        private void iBtn_Click(object sender, EventArgs e)
        {
            Inputkey("I");
        }
        //WHEN USER CLICKS O BUTTON
        private void oBtn_Click(object sender, EventArgs e)
        {
            Inputkey("O");
        }
        //WHEN USER CLICKS P BUTTON
        private void pBtn_Click(object sender, EventArgs e)
        {
            Inputkey("P");
        }
        //WHEN USER CLICKS A BUTTON
        private void aBtn_Click(object sender, EventArgs e)
        {
            Inputkey("A");
        }
        //WHEN USER CLICKS S BUTTON
        private void sBtn_Click(object sender, EventArgs e)
        {
            Inputkey("S");
        }
        //WHEN USER CLICKS D BUTTON
        private void dBtn_Click(object sender, EventArgs e)
        {
            Inputkey("D");
        }
        //WHEN USER CLICKS F BUTTON
        private void fBtn_Click(object sender, EventArgs e)
        {
            Inputkey("F");
        }
        //WHEN USER CLICKS G BUTTON
        private void gBtn_Click(object sender, EventArgs e)
        {
            Inputkey("G");
        }
        //WHEN USER CLICKS H BUTTON
        private void hBtn_Click(object sender, EventArgs e)
        {
            Inputkey("H");
        }
        //WHEN USER CLICKS J BUTTON
        private void jBtn_Click(object sender, EventArgs e)
        {
            Inputkey("J");
        }
        //WHEN USER CLICKS K BUTTON
        private void kBtn_Click(object sender, EventArgs e)
        {
            Inputkey("K");
        }
        //WHEN USER CLICKS L BUTTON
        private void lBtn_Click(object sender, EventArgs e)
        {
            Inputkey("L");
        }
        //WHEN USER CLICKS Z BUTTON
        private void zBtn_Click(object sender, EventArgs e)
        {
            Inputkey("Z");
        }
        //WHEN USER CLICKS X BUTTON
        private void xBtn_Click(object sender, EventArgs e)
        {
            Inputkey("X");
        }
        //WHEN USER CLICKS C BUTTON
        private void cBtn_Click(object sender, EventArgs e)
        {
            Inputkey("C");
        }
        //WHEN USER CLICKS V BUTTON
        private void vBtn_Click(object sender, EventArgs e)
        {
            Inputkey("V");
        }
        //WHEN USER CLICKS B BUTTON
        private void bBtn_Click(object sender, EventArgs e)
        {
            Inputkey("B");
        }
        //WHEN USER CLICKS N BUTTON
        private void nBtn_Click(object sender, EventArgs e)
        {
            Inputkey("N");
        }
        //WHEN USER CLICKS M BUTTON
        private void mBtn_Click(object sender, EventArgs e)
        {
            Inputkey("M");
        }
        //WHEN USER CLICKS BACKSPACE BUTTON
        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            RemoveChar();
        }

        //WHEN USER CLICKS ENTER BUTTON
        private void enterBtn_Click(object sender, EventArgs e)
        {
            //IF 
            //attempt1
            if (attempt1)
            {
                string attemptWord = attempt1Char1.Text + attempt1Char2.Text + attempt1Char3.Text + attempt1Char4.Text + attempt1Char5.Text;
                if (attemptWord.Length == 5)
                {
                    if (guessWord[0].ToString() == attempt1Char1.Text)
                    {
                        attempt1Char1.BackColor = Color.LightGreen;
                    }
                    if (attemptWord == guessWord)
                    {

                        var win = new WinScreen(guessWord);
                        this.Close();
                        win.Show();
                        attempt1 = true;
                    }
                    else
                    {
                        attempt1 = false;
                        attempt2 = true;
                    }
                }
                else
                {
                    MessageBox.Show("Kulang ang mga letra! Limang(5) Letra lamang!");
                }
            }
            //attempt2
            else if (attempt2)
            {
                string attemptWord = attempt2Char1.Text + attempt2Char2.Text + attempt2Char3.Text + attempt2Char4.Text + attempt2Char5.Text;
                if (attemptWord.Length == 5)
                {
                    if (attemptWord == guessWord)
                    {
                        var win = new WinScreen(guessWord);
                        this.Close();
                        win.Show();
                        attempt1 = true;
                        attempt2 = false;
                    }
                    else
                    {
                        attempt2 = false;
                        attempt3 = true;
                    }
                }
                else
                {
                    MessageBox.Show("Kulang ang mga letra! Limang(5) Letra lamang!");
                }
            }
            //attempt3
            else if (attempt3)
            {
                string attemptWord = attempt3Char1.Text + attempt3Char2.Text + attempt3Char3.Text + attempt3Char4.Text + attempt3Char5.Text;
                if (attemptWord.Length == 5)
                {
                    if (attemptWord == guessWord)
                    {
                        var win = new WinScreen(guessWord);
                        this.Close();
                        win.Show();
                        attempt1 = true;
                        attempt3 = false;
                    }
                    else
                    {
                        attempt3 = false;
                        attempt4 = true;
                    }
                }
                else
                {
                    MessageBox.Show("Kulang ang mga letra! Limang(5) Letra lamang!");
                }
            }
            //attempt4
            else if (attempt4)
            {
                string attemptWord = attempt4Char1.Text + attempt4Char2.Text + attempt4Char3.Text + attempt4Char4.Text + attempt4Char5.Text;
                if (attemptWord.Length == 5)
                {
                    if (attemptWord == guessWord)
                    {
                        var win = new WinScreen(guessWord);
                        this.Close();
                        win.Show();
                        attempt1 = true;
                        attempt4 = false;
                    }
                    else
                    {
                        attempt4 = false;
                        attempt5 = true;
                    }
                }
                else
                {
                    MessageBox.Show("Kulang ang mga letra! Limang(5) Letra lamang!");
                }
            }
            //attempt5
            else if (attempt5)
            {
                string attemptWord = attempt4Char1.Text + attempt4Char2.Text + attempt4Char3.Text + attempt4Char4.Text + attempt4Char5.Text;
                if (attemptWord.Length == 5)
                {
                    if (attemptWord == guessWord)
                    {
                        var win = new WinScreen(guessWord);
                        this.Close();
                        win.Show();
                        attempt1 = true;
                        attempt5 = false;
                    }
                    else
                    {
                        attempt5 = false;
                        attempt6 = true;
                    }
                }
                else
                {
                    MessageBox.Show("Kulang ang mga letra! Limang(5) Letra lamang!");
                }
            }
            //attempt6
            else if (attempt6)
            {
                string attemptWord = attempt6Char1.Text + attempt6Char2.Text + attempt6Char3.Text + attempt6Char4.Text + attempt6Char5.Text;
                if (attemptWord.Length == 5)
                {
                    if (attemptWord == guessWord)
                    {
                        var win = new WinScreen(guessWord);
                        this.Close();
                        win.Show();
                        attempt1 = true;
                        attempt6 = false;
                    }
                    else
                    {
                        Form form4 = new LoseScreen(guessWord);
                        this.Close();
                        form4.Show();
                        attempt1 = true;
                        attempt2 = false;
                        attempt3 = false;
                        attempt4 = false;
                        attempt5 = false;
                        attempt6 = false;
                    }
                }
                else
                {
                    MessageBox.Show("Kulang ang mga letra! Limang(5) Letra lamang!");
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void attempt1Char1_TextChanged(object sender, EventArgs e)
        {

        }

        //INPUTKEY METHOD
        private void Inputkey(string a)
        {
            if (attempt1)
            {
                //attempt1 
                if (attempt1Char1.Text == "")
                {
                    attempt1Char1.Text = a;
                }
                else if (attempt1Char2.Text == "" && attempt1Char1.Text != "")
                {
                    attempt1Char2.Text = a;
                }
                else if (attempt1Char3.Text == "" && attempt1Char2.Text != "")
                {
                    attempt1Char3.Text = a;
                }
                else if (attempt1Char4.Text == "" && attempt1Char3.Text != "")
                {
                    attempt1Char4.Text = a;
                }
                else if (attempt1Char5.Text == "" && attempt1Char4.Text != "")
                {
                    attempt1Char5.Text = a;
                }
            }//endif attempt 1

            else if (attempt2)
            {
                //attempt2 
                if (attempt2Char1.Text == "")
                {
                    attempt2Char1.Text = a;
                }
                else if (attempt2Char2.Text == "" && attempt2Char1.Text != "")
                {
                    attempt2Char2.Text = a;
                }
                else if (attempt2Char3.Text == "" && attempt2Char2.Text != "")
                {
                    attempt2Char3.Text = a;
                }
                else if (attempt2Char4.Text == "" && attempt2Char3.Text != "")
                {
                    attempt2Char4.Text = a;
                }
                else if (attempt2Char5.Text == "" && attempt2Char4.Text != "")
                {
                    attempt2Char5.Text = a;
                }
            }//endif attempt 2

            else if (attempt3)
            {
                //attempt3 
                if (attempt3Char1.Text == "")
                {
                    attempt3Char1.Text = a;
                }
                else if (attempt3Char2.Text == "" && attempt3Char1.Text != "")
                {
                    attempt3Char2.Text = a;
                }
                else if (attempt3Char3.Text == "" && attempt3Char2.Text != "")
                {
                    attempt3Char3.Text = a;
                }
                else if (attempt3Char4.Text == "" && attempt3Char3.Text != "")
                {
                    attempt3Char4.Text = a;
                }
                else if (attempt3Char5.Text == "" && attempt3Char4.Text != "")
                {
                    attempt3Char5.Text = a;
                }
            }//endif attempt 3

            else if (attempt4)
            {
                //attempt4 
                if (attempt4Char1.Text == "")
                {
                    attempt4Char1.Text = a;
                }
                else if (attempt4Char2.Text == "" && attempt4Char1.Text != "")
                {
                    attempt4Char2.Text = a;
                }
                else if (attempt4Char3.Text == "" && attempt4Char2.Text != "")
                {
                    attempt4Char3.Text = a;
                }
                else if (attempt4Char4.Text == "" && attempt4Char3.Text != "")
                {
                    attempt4Char4.Text = a;
                }
                else if (attempt4Char5.Text == "" && attempt4Char4.Text != "")
                {
                    attempt4Char5.Text = a;
                }
            }//endif attempt 4

            else if (attempt5)
            {
                //attempt5 
                if (attempt5Char1.Text == "")
                {
                    attempt5Char1.Text = a;
                }
                else if (attempt5Char2.Text == "" && attempt5Char1.Text != "")
                {
                    attempt5Char2.Text = a;
                }
                else if (attempt5Char3.Text == "" && attempt5Char2.Text != "")
                {
                    attempt5Char3.Text = a;
                }
                else if (attempt5Char4.Text == "" && attempt5Char3.Text != "")
                {
                    attempt5Char4.Text = a;
                }
                else if (attempt5Char5.Text == "" && attempt5Char4.Text != "")
                {
                    attempt5Char5.Text = a;
                }
            }//endif attempt 5

            else if (attempt6)
            {
                //attempt6 
                if (attempt6Char1.Text == "")
                {
                    attempt6Char1.Text = a;
                }
                else if (attempt6Char2.Text == "" && attempt6Char1.Text != "")
                {
                    attempt6Char2.Text = a;
                }
                else if (attempt6Char3.Text == "" && attempt6Char2.Text != "")
                {
                    attempt6Char3.Text = a;
                }
                else if (attempt6Char4.Text == "" && attempt6Char3.Text != "")
                {
                    attempt6Char4.Text = a;
                }
                else if (attempt6Char5.Text == "" && attempt6Char4.Text != "")
                {
                    attempt6Char5.Text = a;
                }
            }//endif attempt 6

        }//method end

        //REMOVECHAR METHOD
        private void RemoveChar()
        {
            //loop for letters a-z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (attempt1)
                {
                    //attempt1 
                    if (attempt1Char5.Text.Contains(c.ToString()))
                    {
                        attempt1Char5.Text = "";

                    }
                    else if (attempt1Char4.Text.Contains(c.ToString()) && attempt1Char5.Text == "")
                    {
                        attempt1Char4.Text = "";

                    }
                    else if (attempt1Char3.Text.Contains(c.ToString()) && attempt1Char4.Text == "")
                    {
                        attempt1Char3.Text = "";

                    }
                    else if (attempt1Char2.Text.Contains(c.ToString()) && attempt1Char3.Text == "")
                    {
                        attempt1Char2.Text = "";

                    }
                    else if (attempt1Char1.Text.Contains(c.ToString()) && attempt1Char2.Text == "")
                    {
                        attempt1Char1.Text = "";

                    }
                }//endif attempt 1

                if (attempt2)
                {
                    //attempt2 
                    if (attempt2Char5.Text.Contains(c.ToString()))
                    {
                        attempt2Char5.Text = "";

                    }
                    else if (attempt2Char4.Text.Contains(c.ToString()) && attempt2Char5.Text == "")
                    {
                        attempt2Char4.Text = "";

                    }
                    else if (attempt2Char3.Text.Contains(c.ToString()) && attempt2Char4.Text == "")
                    {
                        attempt2Char3.Text = "";

                    }
                    else if (attempt2Char2.Text.Contains(c.ToString()) && attempt2Char3.Text == "")
                    {
                        attempt2Char2.Text = "";

                    }
                    else if (attempt2Char1.Text.Contains(c.ToString()) && attempt2Char2.Text == "")
                    {
                        attempt2Char1.Text = "";

                    }
                }//endif attempt 2

                if (attempt3)
                {
                    //attempt3 
                    if (attempt3Char5.Text.Contains(c.ToString()))
                    {
                        attempt3Char5.Text = "";

                    }
                    else if (attempt3Char4.Text.Contains(c.ToString()) && attempt3Char5.Text == "")
                    {
                        attempt3Char4.Text = "";

                    }
                    else if (attempt3Char3.Text.Contains(c.ToString()) && attempt3Char4.Text == "")
                    {
                        attempt3Char3.Text = "";

                    }
                    else if (attempt3Char2.Text.Contains(c.ToString()) && attempt3Char3.Text == "")
                    {
                        attempt3Char2.Text = "";

                    }
                    else if (attempt3Char1.Text.Contains(c.ToString()) && attempt3Char2.Text == "")
                    {
                        attempt3Char1.Text = "";

                    }
                }//endif attempt 3

                if (attempt4)
                {
                    //attempt4 
                    if (attempt4Char5.Text.Contains(c.ToString()))
                    {
                        attempt4Char5.Text = "";

                    }
                    else if (attempt4Char4.Text.Contains(c.ToString()) && attempt4Char5.Text == "")
                    {
                        attempt4Char4.Text = "";

                    }
                    else if (attempt4Char3.Text.Contains(c.ToString()) && attempt4Char4.Text == "")
                    {
                        attempt4Char3.Text = "";

                    }
                    else if (attempt4Char2.Text.Contains(c.ToString()) && attempt4Char3.Text == "")
                    {
                        attempt4Char2.Text = "";

                    }
                    else if (attempt4Char1.Text.Contains(c.ToString()) && attempt4Char2.Text == "")
                    {
                        attempt4Char1.Text = "";

                    }
                }//endif attempt 4

                if (attempt5)
                {
                    //attempt5 
                    if (attempt5Char5.Text.Contains(c.ToString()))
                    {
                        attempt5Char5.Text = "";

                    }
                    else if (attempt5Char4.Text.Contains(c.ToString()) && attempt5Char5.Text == "")
                    {
                        attempt5Char4.Text = "";

                    }
                    else if (attempt5Char3.Text.Contains(c.ToString()) && attempt5Char4.Text == "")
                    {
                        attempt5Char3.Text = "";

                    }
                    else if (attempt5Char2.Text.Contains(c.ToString()) && attempt5Char3.Text == "")
                    {
                        attempt5Char2.Text = "";

                    }
                    else if (attempt5Char1.Text.Contains(c.ToString()) && attempt5Char2.Text == "")
                    {
                        attempt5Char1.Text = "";

                    }
                }//endif attempt 5

                if (attempt6)
                {
                    //attempt6 
                    if (attempt6Char5.Text.Contains(c.ToString()))
                    {
                        attempt6Char5.Text = "";

                    }
                    else if (attempt6Char4.Text.Contains(c.ToString()) && attempt6Char5.Text == "")
                    {
                        attempt6Char4.Text = "";

                    }
                    else if (attempt6Char3.Text.Contains(c.ToString()) && attempt6Char4.Text == "")
                    {
                        attempt6Char3.Text = "";

                    }
                    else if (attempt6Char2.Text.Contains(c.ToString()) && attempt6Char3.Text == "")
                    {
                        attempt6Char2.Text = "";

                    }
                    else if (attempt6Char1.Text.Contains(c.ToString()) && attempt6Char2.Text == "")
                    {
                        attempt6Char1.Text = "";

                    }
                }//endif attempt 5
            }//end for loop
        }
    }
}
