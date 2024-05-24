using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winformdle
{
    internal class Remove_Character
    {
        //REMOVECHAR METHOD (ENGLISH, EASY)
        public static void GM1EnglishRemoveCharEasy()
        {
            //loop for letters a-z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (game1EnglishEasy.attempt1)
                {
                    //attempt1 
                    if (game1EnglishEasy.attempt1Char5.Text.Contains(c.ToString()))
                    {
                        game1EnglishEasy.attempt1Char5.Text = "";

                    }
                    else if (game1EnglishEasy.attempt1Char4.Text.Contains(c.ToString()) && game1EnglishEasy.attempt1Char5.Text == "")
                    {
                        game1EnglishEasy.attempt1Char4.Text = "";

                    }
                    else if (game1EnglishEasy.attempt1Char3.Text.Contains(c.ToString()) && game1EnglishEasy.attempt1Char4.Text == "")
                    {
                        game1EnglishEasy.attempt1Char3.Text = "";

                    }
                    else if (game1EnglishEasy.attempt1Char2.Text.Contains(c.ToString()) && game1EnglishEasy.attempt1Char3.Text == "")
                    {
                        game1EnglishEasy.attempt1Char2.Text = "";

                    }
                    else if (game1EnglishEasy.attempt1Char1.Text.Contains(c.ToString()) && game1EnglishEasy.attempt1Char2.Text == "")
                    {
                        game1EnglishEasy.attempt1Char1.Text = "";

                    }
                }//endif attempt 1

                if (game1EnglishEasy.attempt2)
                {
                    //attempt2 
                    if (game1EnglishEasy.attempt2Char5.Text.Contains(c.ToString()))
                    {
                        game1EnglishEasy.attempt2Char5.Text = "";

                    }
                    else if (game1EnglishEasy.attempt2Char4.Text.Contains(c.ToString()) && game1EnglishEasy.attempt2Char5.Text == "")
                    {
                        game1EnglishEasy.attempt2Char4.Text = "";

                    }
                    else if (game1EnglishEasy.attempt2Char3.Text.Contains(c.ToString()) && game1EnglishEasy.attempt2Char4.Text == "")
                    {
                        game1EnglishEasy.attempt2Char3.Text = "";

                    }
                    else if (game1EnglishEasy.attempt2Char2.Text.Contains(c.ToString()) && game1EnglishEasy.attempt2Char3.Text == "")
                    {
                        game1EnglishEasy.attempt2Char2.Text = "";

                    }
                    else if (game1EnglishEasy.attempt2Char1.Text.Contains(c.ToString()) && game1EnglishEasy.attempt2Char2.Text == "")
                    {
                        game1EnglishEasy.attempt2Char1.Text = "";

                    }
                }//endif attempt 2

                if (game1EnglishEasy.attempt3)
                {
                    //attempt3 
                    if (game1EnglishEasy.attempt3Char5.Text.Contains(c.ToString()))
                    {
                        game1EnglishEasy.attempt3Char5.Text = "";

                    }
                    else if (game1EnglishEasy.attempt3Char4.Text.Contains(c.ToString()) && game1EnglishEasy.attempt3Char5.Text == "")
                    {
                        game1EnglishEasy.attempt3Char4.Text = "";

                    }
                    else if (game1EnglishEasy.attempt3Char3.Text.Contains(c.ToString()) && game1EnglishEasy.attempt3Char4.Text == "")
                    {
                        game1EnglishEasy.attempt3Char3.Text = "";

                    }
                    else if (game1EnglishEasy.attempt3Char2.Text.Contains(c.ToString()) && game1EnglishEasy.attempt3Char3.Text == "")
                    {
                        game1EnglishEasy.attempt3Char2.Text = "";

                    }
                    else if (game1EnglishEasy.attempt3Char1.Text.Contains(c.ToString()) && game1EnglishEasy.attempt3Char2.Text == "")
                    {
                        game1EnglishEasy.attempt3Char1.Text = "";

                    }
                }//endif attempt 3

                if (game1EnglishEasy.attempt4)
                {
                    //attempt4 
                    if (game1EnglishEasy.attempt4Char5.Text.Contains(c.ToString()))
                    {
                        game1EnglishEasy.attempt4Char5.Text = "";

                    }
                    else if (game1EnglishEasy.attempt4Char4.Text.Contains(c.ToString()) && game1EnglishEasy.attempt4Char5.Text == "")
                    {
                        game1EnglishEasy.attempt4Char4.Text = "";

                    }
                    else if (game1EnglishEasy.attempt4Char3.Text.Contains(c.ToString()) && game1EnglishEasy.attempt4Char4.Text == "")
                    {
                        game1EnglishEasy.attempt4Char3.Text = "";

                    }
                    else if (game1EnglishEasy.attempt4Char2.Text.Contains(c.ToString()) && game1EnglishEasy.attempt4Char3.Text == "")
                    {
                        game1EnglishEasy.attempt4Char2.Text = "";

                    }
                    else if (game1EnglishEasy.attempt4Char1.Text.Contains(c.ToString()) && game1EnglishEasy.attempt4Char2.Text == "")
                    {
                        game1EnglishEasy.attempt4Char1.Text = "";

                    }
                }//endif attempt 4

                if (game1EnglishEasy.attempt5)
                {
                    //attempt5 
                    if (game1EnglishEasy.attempt5Char5.Text.Contains(c.ToString()))
                    {
                        game1EnglishEasy.attempt5Char5.Text = "";

                    }
                    else if (game1EnglishEasy.attempt5Char4.Text.Contains(c.ToString()) && game1EnglishEasy.attempt5Char5.Text == "")
                    {
                        game1EnglishEasy.attempt5Char4.Text = "";

                    }
                    else if (game1EnglishEasy.attempt5Char3.Text.Contains(c.ToString()) && game1EnglishEasy.attempt5Char4.Text == "")
                    {
                        game1EnglishEasy.attempt5Char3.Text = "";

                    }
                    else if (game1EnglishEasy.attempt5Char2.Text.Contains(c.ToString()) && game1EnglishEasy.attempt5Char3.Text == "")
                    {
                        game1EnglishEasy.attempt5Char2.Text = "";

                    }
                    else if (game1EnglishEasy.attempt5Char1.Text.Contains(c.ToString()) && game1EnglishEasy.attempt5Char2.Text == "")
                    {
                        game1EnglishEasy.attempt5Char1.Text = "";

                    }
                }//endif attempt 5

                if (game1EnglishEasy.attempt6)
                {
                    //attempt6 
                    if (game1EnglishEasy.attempt6Char5.Text.Contains(c.ToString()))
                    {
                        game1EnglishEasy.attempt6Char5.Text = "";

                    }
                    else if (game1EnglishEasy.attempt6Char4.Text.Contains(c.ToString()) && game1EnglishEasy.attempt6Char5.Text == "")
                    {
                        game1EnglishEasy.attempt6Char4.Text = "";

                    }
                    else if (game1EnglishEasy.attempt6Char3.Text.Contains(c.ToString()) && game1EnglishEasy.attempt6Char4.Text == "")
                    {
                        game1EnglishEasy.attempt6Char3.Text = "";

                    }
                    else if (game1EnglishEasy.attempt6Char2.Text.Contains(c.ToString()) && game1EnglishEasy.attempt6Char3.Text == "")
                    {
                        game1EnglishEasy.attempt6Char2.Text = "";

                    }
                    else if (game1EnglishEasy.attempt6Char1.Text.Contains(c.ToString()) && game1EnglishEasy.attempt6Char2.Text == "")
                    {
                        game1EnglishEasy.attempt6Char1.Text = "";

                    }
                }//endif attempt 6
            }//end for loop
        }


        //REMOVECHAR METHOD (ENGLISH, MEDIUM)
        public static void GM1EnglishRemoveCharMedium()
        {
            //loop for letters a-z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (game1EnglishMedium.attempt1)
                {
                    //attempt1

                    if (game1EnglishMedium.attempt1Char6.Text.Contains(c.ToString()))
                    {
                        game1EnglishMedium.attempt1Char6.Text = "";

                    }
                    else if (game1EnglishMedium.attempt1Char5.Text.Contains(c.ToString()) && game1EnglishMedium.attempt1Char6.Text == "")
                    {
                        game1EnglishMedium.attempt1Char5.Text = "";

                    }
                    else if (game1EnglishMedium.attempt1Char4.Text.Contains(c.ToString()) && game1EnglishMedium.attempt1Char5.Text == "")
                    {
                        game1EnglishMedium.attempt1Char4.Text = "";

                    }
                    else if (game1EnglishMedium.attempt1Char3.Text.Contains(c.ToString()) && game1EnglishMedium.attempt1Char4.Text == "")
                    {
                        game1EnglishMedium.attempt1Char3.Text = "";

                    }
                    else if (game1EnglishMedium.attempt1Char2.Text.Contains(c.ToString()) && game1EnglishMedium.attempt1Char3.Text == "")
                    {
                        game1EnglishMedium.attempt1Char2.Text = "";

                    }
                    else if (game1EnglishMedium.attempt1Char1.Text.Contains(c.ToString()) && game1EnglishMedium.attempt1Char2.Text == "")
                    {
                        game1EnglishMedium.attempt1Char1.Text = "";

                    }

                }//endif attempt 1

                if (game1EnglishMedium.attempt2)
                {
                    //attempt2 
                    if (game1EnglishMedium.attempt2Char6.Text.Contains(c.ToString()))
                    {
                        game1EnglishMedium.attempt2Char6.Text = "";

                    }
                    else if (game1EnglishMedium.attempt2Char5.Text.Contains(c.ToString()) && game1EnglishMedium.attempt2Char6.Text == "")
                    {
                        game1EnglishMedium.attempt2Char5.Text = "";

                    }
                    else if (game1EnglishMedium.attempt2Char4.Text.Contains(c.ToString()) && game1EnglishMedium.attempt2Char5.Text == "")
                    {
                        game1EnglishMedium.attempt2Char4.Text = "";

                    }
                    else if (game1EnglishMedium.attempt2Char3.Text.Contains(c.ToString()) && game1EnglishMedium.attempt2Char4.Text == "")
                    {
                        game1EnglishMedium.attempt2Char3.Text = "";

                    }
                    else if (game1EnglishMedium.attempt2Char2.Text.Contains(c.ToString()) && game1EnglishMedium.attempt2Char3.Text == "")
                    {
                        game1EnglishMedium.attempt2Char2.Text = "";

                    }
                    else if (game1EnglishMedium.attempt2Char1.Text.Contains(c.ToString()) && game1EnglishMedium.attempt2Char2.Text == "")
                    {
                        game1EnglishMedium.attempt2Char1.Text = "";

                    }
                }//endif attempt 2

                if (game1EnglishMedium.attempt3)
                {
                    //attempt3 
                    if (game1EnglishMedium.attempt3Char6.Text.Contains(c.ToString()))
                    {
                        game1EnglishMedium.attempt3Char6.Text = "";

                    }
                    else if (game1EnglishMedium.attempt3Char5.Text.Contains(c.ToString()) && game1EnglishMedium.attempt3Char6.Text == "")
                    {
                        game1EnglishMedium.attempt3Char5.Text = "";

                    }
                    else if (game1EnglishMedium.attempt3Char4.Text.Contains(c.ToString()) && game1EnglishMedium.attempt3Char5.Text == "")
                    {
                        game1EnglishMedium.attempt3Char4.Text = "";

                    }
                    else if (game1EnglishMedium.attempt3Char3.Text.Contains(c.ToString()) && game1EnglishMedium.attempt3Char4.Text == "")
                    {
                        game1EnglishMedium.attempt3Char3.Text = "";

                    }
                    else if (game1EnglishMedium.attempt3Char2.Text.Contains(c.ToString()) && game1EnglishMedium.attempt3Char3.Text == "")
                    {
                        game1EnglishMedium.attempt3Char2.Text = "";

                    }
                    else if (game1EnglishMedium.attempt3Char1.Text.Contains(c.ToString()) && game1EnglishMedium.attempt3Char2.Text == "")
                    {
                        game1EnglishMedium.attempt3Char1.Text = "";

                    }
                }//endif attempt 3

                if (game1EnglishMedium.attempt4)
                {
                    //attempt4 
                    if (game1EnglishMedium.attempt4Char6.Text.Contains(c.ToString()))
                    {
                        game1EnglishMedium.attempt4Char6.Text = "";

                    }
                    else if (game1EnglishMedium.attempt4Char5.Text.Contains(c.ToString()) && game1EnglishMedium.attempt4Char6.Text == "")
                    {
                        game1EnglishMedium.attempt4Char5.Text = "";

                    }
                    else if (game1EnglishMedium.attempt4Char4.Text.Contains(c.ToString()) && game1EnglishMedium.attempt4Char5.Text == "")
                    {
                        game1EnglishMedium.attempt4Char4.Text = "";

                    }
                    else if (game1EnglishMedium.attempt4Char3.Text.Contains(c.ToString()) && game1EnglishMedium.attempt4Char4.Text == "")
                    {
                        game1EnglishMedium.attempt4Char3.Text = "";

                    }
                    else if (game1EnglishMedium.attempt4Char2.Text.Contains(c.ToString()) && game1EnglishMedium.attempt4Char3.Text == "")
                    {
                        game1EnglishMedium.attempt4Char2.Text = "";

                    }
                    else if (game1EnglishMedium.attempt4Char1.Text.Contains(c.ToString()) && game1EnglishMedium.attempt4Char2.Text == "")
                    {
                        game1EnglishMedium.attempt4Char1.Text = "";

                    }
                }//endif attempt 4

                if (game1EnglishMedium.attempt5)
                {
                    //attempt5 
                    if (game1EnglishMedium.attempt5Char6.Text.Contains(c.ToString()))
                    {
                        game1EnglishMedium.attempt5Char6.Text = "";

                    }
                    else if (game1EnglishMedium.attempt5Char5.Text.Contains(c.ToString()) && game1EnglishMedium.attempt5Char6.Text == "")
                    {
                        game1EnglishMedium.attempt5Char5.Text = "";

                    }
                    else if (game1EnglishMedium.attempt5Char4.Text.Contains(c.ToString()) && game1EnglishMedium.attempt5Char5.Text == "")
                    {
                        game1EnglishMedium.attempt5Char4.Text = "";

                    }
                    else if (game1EnglishMedium.attempt5Char3.Text.Contains(c.ToString()) && game1EnglishMedium.attempt5Char4.Text == "")
                    {
                        game1EnglishMedium.attempt5Char3.Text = "";

                    }
                    else if (game1EnglishMedium.attempt5Char2.Text.Contains(c.ToString()) && game1EnglishMedium.attempt5Char3.Text == "")
                    {
                        game1EnglishMedium.attempt5Char2.Text = "";

                    }
                    else if (game1EnglishMedium.attempt5Char1.Text.Contains(c.ToString()) && game1EnglishMedium.attempt5Char2.Text == "")
                    {
                        game1EnglishMedium.attempt5Char1.Text = "";

                    }
                }//endif attempt 5

                if (game1EnglishMedium.attempt6)
                {
                    //attempt6 
                    if (game1EnglishMedium.attempt6Char6.Text.Contains(c.ToString()))
                    {
                        game1EnglishMedium.attempt6Char6.Text = "";

                    }
                    else if (game1EnglishMedium.attempt6Char5.Text.Contains(c.ToString()) && game1EnglishMedium.attempt6Char6.Text == "")
                    {
                        game1EnglishMedium.attempt6Char5.Text = "";

                    }
                    else if (game1EnglishMedium.attempt6Char4.Text.Contains(c.ToString()) && game1EnglishMedium.attempt6Char5.Text == "")
                    {
                        game1EnglishMedium.attempt6Char4.Text = "";

                    }
                    else if (game1EnglishMedium.attempt6Char3.Text.Contains(c.ToString()) && game1EnglishMedium.attempt6Char4.Text == "")
                    {
                        game1EnglishMedium.attempt6Char3.Text = "";

                    }
                    else if (game1EnglishMedium.attempt6Char2.Text.Contains(c.ToString()) && game1EnglishMedium.attempt6Char3.Text == "")
                    {
                        game1EnglishMedium.attempt6Char2.Text = "";

                    }
                    else if (game1EnglishMedium.attempt6Char1.Text.Contains(c.ToString()) && game1EnglishMedium.attempt6Char2.Text == "")
                    {
                        game1EnglishMedium.attempt6Char1.Text = "";

                    }
                }//endif attempt 6
            }//end for loop
        }

        //REMOVECHAR METHOD
        public static void GM1EnglishRemoveCharHard()
        {
            //loop for letters a-z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (game1EnglishHard.attempt1)
                {
                    //attempt1

                    if (game1EnglishHard.attempt1Char7.Text.Contains(c.ToString()))
                    {
                        game1EnglishHard.attempt1Char7.Text = "";

                    }
                    else if (game1EnglishHard.attempt1Char6.Text.Contains(c.ToString()) && game1EnglishHard.attempt1Char7.Text == "")
                    {
                        game1EnglishHard.attempt1Char6.Text = "";

                    }
                    else if (game1EnglishHard.attempt1Char5.Text.Contains(c.ToString()) && game1EnglishHard.attempt1Char6.Text == "")
                    {
                        game1EnglishHard.attempt1Char5.Text = "";

                    }
                    else if (game1EnglishHard.attempt1Char4.Text.Contains(c.ToString()) && game1EnglishHard.attempt1Char5.Text == "")
                    {
                        game1EnglishHard.attempt1Char4.Text = "";

                    }
                    else if (game1EnglishHard.attempt1Char3.Text.Contains(c.ToString()) && game1EnglishHard.attempt1Char4.Text == "")
                    {
                        game1EnglishHard.attempt1Char3.Text = "";

                    }
                    else if (game1EnglishHard.attempt1Char2.Text.Contains(c.ToString()) && game1EnglishHard.attempt1Char3.Text == "")
                    {
                        game1EnglishHard.attempt1Char2.Text = "";

                    }
                    else if (game1EnglishHard.attempt1Char1.Text.Contains(c.ToString()) && game1EnglishHard.attempt1Char2.Text == "")
                    {
                        game1EnglishHard.attempt1Char1.Text = "";

                    }

                }//endif attempt 1

                if (game1EnglishHard.attempt2)
                {
                    //attempt2 
                    if (game1EnglishHard.attempt2Char7.Text.Contains(c.ToString()))
                    {
                        game1EnglishHard.attempt2Char7.Text = "";

                    }
                    else if (game1EnglishHard.attempt2Char6.Text.Contains(c.ToString()) && game1EnglishHard.attempt2Char7.Text == "")
                    {
                        game1EnglishHard.attempt2Char6.Text = "";

                    }
                    else if (game1EnglishHard.attempt2Char5.Text.Contains(c.ToString()) && game1EnglishHard.attempt2Char6.Text == "")
                    {
                        game1EnglishHard.attempt2Char5.Text = "";

                    }
                    else if (game1EnglishHard.attempt2Char4.Text.Contains(c.ToString()) && game1EnglishHard.attempt2Char5.Text == "")
                    {
                        game1EnglishHard.attempt2Char4.Text = "";

                    }
                    else if (game1EnglishHard.attempt2Char3.Text.Contains(c.ToString()) && game1EnglishHard.attempt2Char4.Text == "")
                    {
                        game1EnglishHard.attempt2Char3.Text = "";

                    }
                    else if (game1EnglishHard.attempt2Char2.Text.Contains(c.ToString()) && game1EnglishHard.attempt2Char3.Text == "")
                    {
                        game1EnglishHard.attempt2Char2.Text = "";

                    }
                    else if (game1EnglishHard.attempt2Char1.Text.Contains(c.ToString()) && game1EnglishHard.attempt2Char2.Text == "")
                    {
                        game1EnglishHard.attempt2Char1.Text = "";

                    }
                }//endif attempt 2

                if (game1EnglishHard.attempt3)
                {
                    //attempt3 
                    if (game1EnglishHard.attempt3Char7.Text.Contains(c.ToString()))
                    {
                        game1EnglishHard.attempt3Char7.Text = "";

                    }
                    else if (game1EnglishHard.attempt3Char6.Text.Contains(c.ToString()) && game1EnglishHard.attempt3Char7.Text == "")
                    {
                        game1EnglishHard.attempt3Char6.Text = "";

                    }
                    else if (game1EnglishHard.attempt3Char5.Text.Contains(c.ToString()) && game1EnglishHard.attempt3Char6.Text == "")
                    {
                        game1EnglishHard.attempt3Char5.Text = "";

                    }
                    else if (game1EnglishHard.attempt3Char4.Text.Contains(c.ToString()) && game1EnglishHard.attempt3Char5.Text == "")
                    {
                        game1EnglishHard.attempt3Char4.Text = "";

                    }
                    else if (game1EnglishHard.attempt3Char3.Text.Contains(c.ToString()) && game1EnglishHard.attempt3Char4.Text == "")
                    {
                        game1EnglishHard.attempt3Char3.Text = "";

                    }
                    else if (game1EnglishHard.attempt3Char2.Text.Contains(c.ToString()) && game1EnglishHard.attempt3Char3.Text == "")
                    {
                        game1EnglishHard.attempt3Char2.Text = "";

                    }
                    else if (game1EnglishHard.attempt3Char1.Text.Contains(c.ToString()) && game1EnglishHard.attempt3Char2.Text == "")
                    {
                        game1EnglishHard.attempt3Char1.Text = "";

                    }
                }//endif attempt 3

                if (game1EnglishHard.attempt4)
                {
                    //attempt4 
                    if (game1EnglishHard.attempt4Char7.Text.Contains(c.ToString()))
                    {
                        game1EnglishHard.attempt4Char7.Text = "";

                    }
                    else if (game1EnglishHard.attempt4Char6.Text.Contains(c.ToString()) && game1EnglishHard.attempt4Char7.Text == "")
                    {
                        game1EnglishHard.attempt4Char6.Text = "";

                    }
                    else if (game1EnglishHard.attempt4Char5.Text.Contains(c.ToString()) && game1EnglishHard.attempt4Char6.Text == "")
                    {
                        game1EnglishHard.attempt4Char5.Text = "";

                    }
                    else if (game1EnglishHard.attempt4Char4.Text.Contains(c.ToString()) && game1EnglishHard.attempt4Char5.Text == "")
                    {
                        game1EnglishHard.attempt4Char4.Text = "";

                    }
                    else if (game1EnglishHard.attempt4Char3.Text.Contains(c.ToString()) && game1EnglishHard.attempt4Char4.Text == "")
                    {
                        game1EnglishHard.attempt4Char3.Text = "";

                    }
                    else if (game1EnglishHard.attempt4Char2.Text.Contains(c.ToString()) && game1EnglishHard.attempt4Char3.Text == "")
                    {
                        game1EnglishHard.attempt4Char2.Text = "";

                    }
                    else if (game1EnglishHard.attempt4Char1.Text.Contains(c.ToString()) && game1EnglishHard.attempt4Char2.Text == "")
                    {
                        game1EnglishHard.attempt4Char1.Text = "";

                    }
                }//endif attempt 4

                if (game1EnglishHard.attempt5)
                {
                    //attempt5 
                    if (game1EnglishHard.attempt5Char7.Text.Contains(c.ToString()))
                    {
                        game1EnglishHard.attempt5Char7.Text = "";

                    }
                    else if (game1EnglishHard.attempt5Char6.Text.Contains(c.ToString()) && game1EnglishHard.attempt5Char7.Text == "")
                    {
                        game1EnglishHard.attempt5Char6.Text = "";

                    }
                    else if (game1EnglishHard.attempt5Char5.Text.Contains(c.ToString()) && game1EnglishHard.attempt5Char6.Text == "")
                    {
                        game1EnglishHard.attempt5Char5.Text = "";

                    }
                    else if (game1EnglishHard.attempt5Char4.Text.Contains(c.ToString()) && game1EnglishHard.attempt5Char5.Text == "")
                    {
                        game1EnglishHard.attempt5Char4.Text = "";

                    }
                    else if (game1EnglishHard.attempt5Char3.Text.Contains(c.ToString()) && game1EnglishHard.attempt5Char4.Text == "")
                    {
                        game1EnglishHard.attempt5Char3.Text = "";

                    }
                    else if (game1EnglishHard.attempt5Char2.Text.Contains(c.ToString()) && game1EnglishHard.attempt5Char3.Text == "")
                    {
                        game1EnglishHard.attempt5Char2.Text = "";

                    }
                    else if (game1EnglishHard.attempt5Char1.Text.Contains(c.ToString()) && game1EnglishHard.attempt5Char2.Text == "")
                    {
                        game1EnglishHard.attempt5Char1.Text = "";

                    }
                }//endif attempt 5

                if (game1EnglishHard.attempt6)
                {
                    //attempt6 
                    if (game1EnglishHard.attempt6Char7.Text.Contains(c.ToString()))
                    {
                        game1EnglishHard.attempt6Char7.Text = "";

                    }
                    else if (game1EnglishHard.attempt6Char6.Text.Contains(c.ToString()) && game1EnglishHard.attempt6Char7.Text == "")
                    {
                        game1EnglishHard.attempt6Char6.Text = "";

                    }
                    else if (game1EnglishHard.attempt6Char5.Text.Contains(c.ToString()) && game1EnglishHard.attempt6Char6.Text == "")
                    {
                        game1EnglishHard.attempt6Char5.Text = "";

                    }
                    else if (game1EnglishHard.attempt6Char4.Text.Contains(c.ToString()) && game1EnglishHard.attempt6Char5.Text == "")
                    {
                        game1EnglishHard.attempt6Char4.Text = "";

                    }
                    else if (game1EnglishHard.attempt6Char3.Text.Contains(c.ToString()) && game1EnglishHard.attempt6Char4.Text == "")
                    {
                        game1EnglishHard.attempt6Char3.Text = "";

                    }
                    else if (game1EnglishHard.attempt6Char2.Text.Contains(c.ToString()) && game1EnglishHard.attempt6Char3.Text == "")
                    {
                        game1EnglishHard.attempt6Char2.Text = "";

                    }
                    else if (game1EnglishHard.attempt6Char1.Text.Contains(c.ToString()) && game1EnglishHard.attempt6Char2.Text == "")
                    {
                        game1EnglishHard.attempt6Char1.Text = "";

                    }
                }//endif attempt 6
            }//end for loop
        }

        //REMOVECHAR METHOD (ENGLISH, EASY)
        public static void GM1FilipinoRemoveCharEasy()
        {
            //loop for letters a-z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (game1FilipinoEasy.attempt1)
                {
                    //attempt1 
                    if (game1FilipinoEasy.attempt1Char5.Text.Contains(c.ToString()))
                    {
                        game1FilipinoEasy.attempt1Char5.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt1Char4.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt1Char5.Text == "")
                    {
                        game1FilipinoEasy.attempt1Char4.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt1Char3.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt1Char4.Text == "")
                    {
                        game1FilipinoEasy.attempt1Char3.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt1Char2.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt1Char3.Text == "")
                    {
                        game1FilipinoEasy.attempt1Char2.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt1Char1.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt1Char2.Text == "")
                    {
                        game1FilipinoEasy.attempt1Char1.Text = "";

                    }
                }//endif attempt 1

                if (game1FilipinoEasy.attempt2)
                {
                    //attempt2 
                    if (game1FilipinoEasy.attempt2Char5.Text.Contains(c.ToString()))
                    {
                        game1FilipinoEasy.attempt2Char5.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt2Char4.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt2Char5.Text == "")
                    {
                        game1FilipinoEasy.attempt2Char4.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt2Char3.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt2Char4.Text == "")
                    {
                        game1FilipinoEasy.attempt2Char3.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt2Char2.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt2Char3.Text == "")
                    {
                        game1FilipinoEasy.attempt2Char2.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt2Char1.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt2Char2.Text == "")
                    {
                        game1FilipinoEasy.attempt2Char1.Text = "";

                    }
                }//endif attempt 2

                if (game1FilipinoEasy.attempt3)
                {
                    //attempt3 
                    if (game1FilipinoEasy.attempt3Char5.Text.Contains(c.ToString()))
                    {
                        game1FilipinoEasy.attempt3Char5.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt3Char4.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt3Char5.Text == "")
                    {
                        game1FilipinoEasy.attempt3Char4.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt3Char3.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt3Char4.Text == "")
                    {
                        game1FilipinoEasy.attempt3Char3.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt3Char2.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt3Char3.Text == "")
                    {
                        game1FilipinoEasy.attempt3Char2.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt3Char1.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt3Char2.Text == "")
                    {
                        game1FilipinoEasy.attempt3Char1.Text = "";

                    }
                }//endif attempt 3

                if (game1FilipinoEasy.attempt4)
                {
                    //attempt4 
                    if (game1FilipinoEasy.attempt4Char5.Text.Contains(c.ToString()))
                    {
                        game1FilipinoEasy.attempt4Char5.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt4Char4.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt4Char5.Text == "")
                    {
                        game1FilipinoEasy.attempt4Char4.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt4Char3.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt4Char4.Text == "")
                    {
                        game1FilipinoEasy.attempt4Char3.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt4Char2.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt4Char3.Text == "")
                    {
                        game1FilipinoEasy.attempt4Char2.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt4Char1.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt4Char2.Text == "")
                    {
                        game1FilipinoEasy.attempt4Char1.Text = "";

                    }
                }//endif attempt 4

                if (game1FilipinoEasy.attempt5)
                {
                    //attempt5 
                    if (game1FilipinoEasy.attempt5Char5.Text.Contains(c.ToString()))
                    {
                        game1FilipinoEasy.attempt5Char5.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt5Char4.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt5Char5.Text == "")
                    {
                        game1FilipinoEasy.attempt5Char4.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt5Char3.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt5Char4.Text == "")
                    {
                        game1FilipinoEasy.attempt5Char3.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt5Char2.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt5Char3.Text == "")
                    {
                        game1FilipinoEasy.attempt5Char2.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt5Char1.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt5Char2.Text == "")
                    {
                        game1FilipinoEasy.attempt5Char1.Text = "";

                    }
                }//endif attempt 5

                if (game1FilipinoEasy.attempt6)
                {
                    //attempt6 
                    if (game1FilipinoEasy.attempt6Char5.Text.Contains(c.ToString()))
                    {
                        game1FilipinoEasy.attempt6Char5.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt6Char4.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt6Char5.Text == "")
                    {
                        game1FilipinoEasy.attempt6Char4.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt6Char3.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt6Char4.Text == "")
                    {
                        game1FilipinoEasy.attempt6Char3.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt6Char2.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt6Char3.Text == "")
                    {
                        game1FilipinoEasy.attempt6Char2.Text = "";

                    }
                    else if (game1FilipinoEasy.attempt6Char1.Text.Contains(c.ToString()) && game1FilipinoEasy.attempt6Char2.Text == "")
                    {
                        game1FilipinoEasy.attempt6Char1.Text = "";

                    }
                }//endif attempt 6
            }//end for loop
        }












        //GAMEMODE 2




        public static void GM2EnglishRemoveCharEasy()
        {
            //loop for letters a-z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (game2EnglishEasy.attempt1)
                {
                    //attempt1 
                    if (game2EnglishEasy.attempt1Char5.Text.Contains(c.ToString()))
                    {
                        game2EnglishEasy.attempt1Char5.Text = "";

                    }
                    else if (game2EnglishEasy.attempt1Char4.Text.Contains(c.ToString()) && game2EnglishEasy.attempt1Char5.Text == "")
                    {
                        game2EnglishEasy.attempt1Char4.Text = "";

                    }
                    else if (game2EnglishEasy.attempt1Char3.Text.Contains(c.ToString()) && game2EnglishEasy.attempt1Char4.Text == "")
                    {
                        game2EnglishEasy.attempt1Char3.Text = "";

                    }
                    else if (game2EnglishEasy.attempt1Char2.Text.Contains(c.ToString()) && game2EnglishEasy.attempt1Char3.Text == "")
                    {
                        game2EnglishEasy.attempt1Char2.Text = "";

                    }
                    else if (game2EnglishEasy.attempt1Char1.Text.Contains(c.ToString()) && game2EnglishEasy.attempt1Char2.Text == "")
                    {
                        game2EnglishEasy.attempt1Char1.Text = "";

                    }
                }//endif attempt 1

                if (game2EnglishEasy.attempt2)
                {
                    //attempt2 
                    if (game2EnglishEasy.attempt2Char5.Text.Contains(c.ToString()))
                    {
                        game2EnglishEasy.attempt2Char5.Text = "";

                    }
                    else if (game2EnglishEasy.attempt2Char4.Text.Contains(c.ToString()) && game2EnglishEasy.attempt2Char5.Text == "")
                    {
                        game2EnglishEasy.attempt2Char4.Text = "";

                    }
                    else if (game2EnglishEasy.attempt2Char3.Text.Contains(c.ToString()) && game2EnglishEasy.attempt2Char4.Text == "")
                    {
                        game2EnglishEasy.attempt2Char3.Text = "";

                    }
                    else if (game2EnglishEasy.attempt2Char2.Text.Contains(c.ToString()) && game2EnglishEasy.attempt2Char3.Text == "")
                    {
                        game2EnglishEasy.attempt2Char2.Text = "";

                    }
                    else if (game2EnglishEasy.attempt2Char1.Text.Contains(c.ToString()) && game2EnglishEasy.attempt2Char2.Text == "")
                    {
                        game2EnglishEasy.attempt2Char1.Text = "";

                    }
                }//endif attempt 2

                if (game2EnglishEasy.attempt3)
                {
                    //attempt3 
                    if (game2EnglishEasy.attempt3Char5.Text.Contains(c.ToString()))
                    {
                        game2EnglishEasy.attempt3Char5.Text = "";

                    }
                    else if (game2EnglishEasy.attempt3Char4.Text.Contains(c.ToString()) && game2EnglishEasy.attempt3Char5.Text == "")
                    {
                        game2EnglishEasy.attempt3Char4.Text = "";

                    }
                    else if (game2EnglishEasy.attempt3Char3.Text.Contains(c.ToString()) && game2EnglishEasy.attempt3Char4.Text == "")
                    {
                        game2EnglishEasy.attempt3Char3.Text = "";

                    }
                    else if (game2EnglishEasy.attempt3Char2.Text.Contains(c.ToString()) && game2EnglishEasy.attempt3Char3.Text == "")
                    {
                        game2EnglishEasy.attempt3Char2.Text = "";

                    }
                    else if (game2EnglishEasy.attempt3Char1.Text.Contains(c.ToString()) && game2EnglishEasy.attempt3Char2.Text == "")
                    {
                        game2EnglishEasy.attempt3Char1.Text = "";

                    }
                }//endif attempt 3

                if (game2EnglishEasy.attempt4)
                {
                    //attempt4 
                    if (game2EnglishEasy.attempt4Char5.Text.Contains(c.ToString()))
                    {
                        game2EnglishEasy.attempt4Char5.Text = "";

                    }
                    else if (game2EnglishEasy.attempt4Char4.Text.Contains(c.ToString()) && game2EnglishEasy.attempt4Char5.Text == "")
                    {
                        game2EnglishEasy.attempt4Char4.Text = "";

                    }
                    else if (game2EnglishEasy.attempt4Char3.Text.Contains(c.ToString()) && game2EnglishEasy.attempt4Char4.Text == "")
                    {
                        game2EnglishEasy.attempt4Char3.Text = "";

                    }
                    else if (game2EnglishEasy.attempt4Char2.Text.Contains(c.ToString()) && game2EnglishEasy.attempt4Char3.Text == "")
                    {
                        game2EnglishEasy.attempt4Char2.Text = "";

                    }
                    else if (game2EnglishEasy.attempt4Char1.Text.Contains(c.ToString()) && game2EnglishEasy.attempt4Char2.Text == "")
                    {
                        game2EnglishEasy.attempt4Char1.Text = "";

                    }
                }//endif attempt 4

                if (game2EnglishEasy.attempt5)
                {
                    //attempt5 
                    if (game2EnglishEasy.attempt5Char5.Text.Contains(c.ToString()))
                    {
                        game2EnglishEasy.attempt5Char5.Text = "";

                    }
                    else if (game2EnglishEasy.attempt5Char4.Text.Contains(c.ToString()) && game2EnglishEasy.attempt5Char5.Text == "")
                    {
                        game2EnglishEasy.attempt5Char4.Text = "";

                    }
                    else if (game2EnglishEasy.attempt5Char3.Text.Contains(c.ToString()) && game2EnglishEasy.attempt5Char4.Text == "")
                    {
                        game2EnglishEasy.attempt5Char3.Text = "";

                    }
                    else if (game2EnglishEasy.attempt5Char2.Text.Contains(c.ToString()) && game2EnglishEasy.attempt5Char3.Text == "")
                    {
                        game2EnglishEasy.attempt5Char2.Text = "";

                    }
                    else if (game2EnglishEasy.attempt5Char1.Text.Contains(c.ToString()) && game2EnglishEasy.attempt5Char2.Text == "")
                    {
                        game2EnglishEasy.attempt5Char1.Text = "";

                    }
                }//endif attempt 5

                if (game2EnglishEasy.attempt6)
                {
                    //attempt6 
                    if (game2EnglishEasy.attempt6Char5.Text.Contains(c.ToString()))
                    {
                        game2EnglishEasy.attempt6Char5.Text = "";

                    }
                    else if (game2EnglishEasy.attempt6Char4.Text.Contains(c.ToString()) && game2EnglishEasy.attempt6Char5.Text == "")
                    {
                        game2EnglishEasy.attempt6Char4.Text = "";

                    }
                    else if (game2EnglishEasy.attempt6Char3.Text.Contains(c.ToString()) && game2EnglishEasy.attempt6Char4.Text == "")
                    {
                        game2EnglishEasy.attempt6Char3.Text = "";

                    }
                    else if (game2EnglishEasy.attempt6Char2.Text.Contains(c.ToString()) && game2EnglishEasy.attempt6Char3.Text == "")
                    {
                        game2EnglishEasy.attempt6Char2.Text = "";

                    }
                    else if (game2EnglishEasy.attempt6Char1.Text.Contains(c.ToString()) && game2EnglishEasy.attempt6Char2.Text == "")
                    {
                        game2EnglishEasy.attempt6Char1.Text = "";

                    }
                }//endif attempt 6
            }//end for loop
        }


        //GAMEMODE 2 ENGLISH, MEDIUM
        //REMOVECHAR METHOD (ENGLISH, MEDIUM)
        public static void GM2EnglishRemoveCharMedium()
        {
            //loop for letters a-z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (game2EnglishMedium.attempt1)
                {
                    //attempt1

                    if (game2EnglishMedium.attempt1Char6.Text.Contains(c.ToString()))
                    {
                        game2EnglishMedium.attempt1Char6.Text = "";

                    }
                    else if (game2EnglishMedium.attempt1Char5.Text.Contains(c.ToString()) && game2EnglishMedium.attempt1Char6.Text == "")
                    {
                        game2EnglishMedium.attempt1Char5.Text = "";

                    }
                    else if (game2EnglishMedium.attempt1Char4.Text.Contains(c.ToString()) && game2EnglishMedium.attempt1Char5.Text == "")
                    {
                        game2EnglishMedium.attempt1Char4.Text = "";

                    }
                    else if (game2EnglishMedium.attempt1Char3.Text.Contains(c.ToString()) && game2EnglishMedium.attempt1Char4.Text == "")
                    {
                        game2EnglishMedium.attempt1Char3.Text = "";

                    }
                    else if (game2EnglishMedium.attempt1Char2.Text.Contains(c.ToString()) && game2EnglishMedium.attempt1Char3.Text == "")
                    {
                        game2EnglishMedium.attempt1Char2.Text = "";

                    }
                    else if (game2EnglishMedium.attempt1Char1.Text.Contains(c.ToString()) && game2EnglishMedium.attempt1Char2.Text == "")
                    {
                        game2EnglishMedium.attempt1Char1.Text = "";

                    }

                }//endif attempt 1

                if (game2EnglishMedium.attempt2)
                {
                    //attempt2 
                    if (game2EnglishMedium.attempt2Char6.Text.Contains(c.ToString()))
                    {
                        game2EnglishMedium.attempt2Char6.Text = "";

                    }
                    else if (game2EnglishMedium.attempt2Char5.Text.Contains(c.ToString()) && game2EnglishMedium.attempt2Char6.Text == "")
                    {
                        game2EnglishMedium.attempt2Char5.Text = "";

                    }
                    else if (game2EnglishMedium.attempt2Char4.Text.Contains(c.ToString()) && game2EnglishMedium.attempt2Char5.Text == "")
                    {
                        game2EnglishMedium.attempt2Char4.Text = "";

                    }
                    else if (game2EnglishMedium.attempt2Char3.Text.Contains(c.ToString()) && game2EnglishMedium.attempt2Char4.Text == "")
                    {
                        game2EnglishMedium.attempt2Char3.Text = "";

                    }
                    else if (game2EnglishMedium.attempt2Char2.Text.Contains(c.ToString()) && game2EnglishMedium.attempt2Char3.Text == "")
                    {
                        game2EnglishMedium.attempt2Char2.Text = "";

                    }
                    else if (game2EnglishMedium.attempt2Char1.Text.Contains(c.ToString()) && game2EnglishMedium.attempt2Char2.Text == "")
                    {
                        game2EnglishMedium.attempt2Char1.Text = "";

                    }
                }//endif attempt 2

                if (game2EnglishMedium.attempt3)
                {
                    //attempt3 
                    if (game2EnglishMedium.attempt3Char6.Text.Contains(c.ToString()))
                    {
                        game2EnglishMedium.attempt3Char6.Text = "";

                    }
                    else if (game2EnglishMedium.attempt3Char5.Text.Contains(c.ToString()) && game2EnglishMedium.attempt3Char6.Text == "")
                    {
                        game2EnglishMedium.attempt3Char5.Text = "";

                    }
                    else if (game2EnglishMedium.attempt3Char4.Text.Contains(c.ToString()) && game2EnglishMedium.attempt3Char5.Text == "")
                    {
                        game2EnglishMedium.attempt3Char4.Text = "";

                    }
                    else if (game2EnglishMedium.attempt3Char3.Text.Contains(c.ToString()) && game2EnglishMedium.attempt3Char4.Text == "")
                    {
                        game2EnglishMedium.attempt3Char3.Text = "";

                    }
                    else if (game2EnglishMedium.attempt3Char2.Text.Contains(c.ToString()) && game2EnglishMedium.attempt3Char3.Text == "")
                    {
                        game2EnglishMedium.attempt3Char2.Text = "";

                    }
                    else if (game2EnglishMedium.attempt3Char1.Text.Contains(c.ToString()) && game2EnglishMedium.attempt3Char2.Text == "")
                    {
                        game2EnglishMedium.attempt3Char1.Text = "";

                    }
                }//endif attempt 3

                if (game2EnglishMedium.attempt4)
                {
                    //attempt4 
                    if (game2EnglishMedium.attempt4Char6.Text.Contains(c.ToString()))
                    {
                        game2EnglishMedium.attempt4Char6.Text = "";

                    }
                    else if (game2EnglishMedium.attempt4Char5.Text.Contains(c.ToString()) && game2EnglishMedium.attempt4Char6.Text == "")
                    {
                        game2EnglishMedium.attempt4Char5.Text = "";

                    }
                    else if (game2EnglishMedium.attempt4Char4.Text.Contains(c.ToString()) && game2EnglishMedium.attempt4Char5.Text == "")
                    {
                        game2EnglishMedium.attempt4Char4.Text = "";

                    }
                    else if (game2EnglishMedium.attempt4Char3.Text.Contains(c.ToString()) && game2EnglishMedium.attempt4Char4.Text == "")
                    {
                        game2EnglishMedium.attempt4Char3.Text = "";

                    }
                    else if (game2EnglishMedium.attempt4Char2.Text.Contains(c.ToString()) && game2EnglishMedium.attempt4Char3.Text == "")
                    {
                        game2EnglishMedium.attempt4Char2.Text = "";

                    }
                    else if (game2EnglishMedium.attempt4Char1.Text.Contains(c.ToString()) && game2EnglishMedium.attempt4Char2.Text == "")
                    {
                        game2EnglishMedium.attempt4Char1.Text = "";

                    }
                }//endif attempt 4

                if (game2EnglishMedium.attempt5)
                {
                    //attempt5 
                    if (game2EnglishMedium.attempt5Char6.Text.Contains(c.ToString()))
                    {
                        game2EnglishMedium.attempt5Char6.Text = "";

                    }
                    else if (game2EnglishMedium.attempt5Char5.Text.Contains(c.ToString()) && game2EnglishMedium.attempt5Char6.Text == "")
                    {
                        game2EnglishMedium.attempt5Char5.Text = "";

                    }
                    else if (game2EnglishMedium.attempt5Char4.Text.Contains(c.ToString()) && game2EnglishMedium.attempt5Char5.Text == "")
                    {
                        game2EnglishMedium.attempt5Char4.Text = "";

                    }
                    else if (game2EnglishMedium.attempt5Char3.Text.Contains(c.ToString()) && game2EnglishMedium.attempt5Char4.Text == "")
                    {
                        game2EnglishMedium.attempt5Char3.Text = "";

                    }
                    else if (game2EnglishMedium.attempt5Char2.Text.Contains(c.ToString()) && game2EnglishMedium.attempt5Char3.Text == "")
                    {
                        game2EnglishMedium.attempt5Char2.Text = "";

                    }
                    else if (game2EnglishMedium.attempt5Char1.Text.Contains(c.ToString()) && game2EnglishMedium.attempt5Char2.Text == "")
                    {
                        game2EnglishMedium.attempt5Char1.Text = "";

                    }
                }//endif attempt 5

                if (game2EnglishMedium.attempt6)
                {
                    //attempt6 
                    if (game2EnglishMedium.attempt6Char6.Text.Contains(c.ToString()))
                    {
                        game2EnglishMedium.attempt6Char6.Text = "";

                    }
                    else if (game2EnglishMedium.attempt6Char5.Text.Contains(c.ToString()) && game2EnglishMedium.attempt6Char6.Text == "")
                    {
                        game2EnglishMedium.attempt6Char5.Text = "";

                    }
                    else if (game2EnglishMedium.attempt6Char4.Text.Contains(c.ToString()) && game2EnglishMedium.attempt6Char5.Text == "")
                    {
                        game2EnglishMedium.attempt6Char4.Text = "";

                    }
                    else if (game2EnglishMedium.attempt6Char3.Text.Contains(c.ToString()) && game2EnglishMedium.attempt6Char4.Text == "")
                    {
                        game2EnglishMedium.attempt6Char3.Text = "";

                    }
                    else if (game2EnglishMedium.attempt6Char2.Text.Contains(c.ToString()) && game2EnglishMedium.attempt6Char3.Text == "")
                    {
                        game2EnglishMedium.attempt6Char2.Text = "";

                    }
                    else if (game2EnglishMedium.attempt6Char1.Text.Contains(c.ToString()) && game2EnglishMedium.attempt6Char2.Text == "")
                    {
                        game2EnglishMedium.attempt6Char1.Text = "";

                    }
                }//endif attempt 6
            }//end for loop
        }


        //ENGLISH HARD
        public static void GM2EnglishRemoveCharHard()
        {
            //loop for letters a-z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (game2EnglishHard.attempt1)
                {
                    //attempt1

                    if (game2EnglishHard.attempt1Char7.Text.Contains(c.ToString()))
                    {
                        game2EnglishHard.attempt1Char7.Text = "";

                    }
                    else if (game2EnglishHard.attempt1Char6.Text.Contains(c.ToString()) && game2EnglishHard.attempt1Char7.Text == "")
                    {
                        game2EnglishHard.attempt1Char6.Text = "";

                    }
                    else if (game1EnglishHard.attempt1Char5.Text.Contains(c.ToString()) && game2EnglishHard.attempt1Char6.Text == "")
                    {
                        game2EnglishHard.attempt1Char5.Text = "";

                    }
                    else if (game2EnglishHard.attempt1Char4.Text.Contains(c.ToString()) && game2EnglishHard.attempt1Char5.Text == "")
                    {
                        game2EnglishHard.attempt1Char4.Text = "";

                    }
                    else if (game2EnglishHard.attempt1Char3.Text.Contains(c.ToString()) && game2EnglishHard.attempt1Char4.Text == "")
                    {
                        game2EnglishHard.attempt1Char3.Text = "";

                    }
                    else if (game2EnglishHard.attempt1Char2.Text.Contains(c.ToString()) && game2EnglishHard.attempt1Char3.Text == "")
                    {
                        game2EnglishHard.attempt1Char2.Text = "";

                    }
                    else if (game2EnglishHard.attempt1Char1.Text.Contains(c.ToString()) && game2EnglishHard.attempt1Char2.Text == "")
                    {
                        game2EnglishHard.attempt1Char1.Text = "";

                    }

                }//endif attempt 1

                if (game2EnglishHard.attempt2)
                {
                    //attempt2 
                    if (game2EnglishHard.attempt2Char7.Text.Contains(c.ToString()))
                    {
                        game2EnglishHard.attempt2Char7.Text = "";

                    }
                    else if (game2EnglishHard.attempt2Char6.Text.Contains(c.ToString()) && game2EnglishHard.attempt2Char7.Text == "")
                    {
                        game2EnglishHard.attempt2Char6.Text = "";

                    }
                    else if (game2EnglishHard.attempt2Char5.Text.Contains(c.ToString()) && game2EnglishHard.attempt2Char6.Text == "")
                    {
                        game2EnglishHard.attempt2Char5.Text = "";

                    }
                    else if (game2EnglishHard.attempt2Char4.Text.Contains(c.ToString()) && game2EnglishHard.attempt2Char5.Text == "")
                    {
                        game2EnglishHard.attempt2Char4.Text = "";

                    }
                    else if (game2EnglishHard.attempt2Char3.Text.Contains(c.ToString()) && game2EnglishHard.attempt2Char4.Text == "")
                    {
                        game2EnglishHard.attempt2Char3.Text = "";

                    }
                    else if (game2EnglishHard.attempt2Char2.Text.Contains(c.ToString()) && game2EnglishHard.attempt2Char3.Text == "")
                    {
                        game2EnglishHard.attempt2Char2.Text = "";

                    }
                    else if (game2EnglishHard.attempt2Char1.Text.Contains(c.ToString()) && game2EnglishHard.attempt2Char2.Text == "")
                    {
                        game2EnglishHard.attempt2Char1.Text = "";

                    }
                }//endif attempt 2

                if (game2EnglishHard.attempt3)
                {
                    //attempt3 
                    if (game2EnglishHard.attempt3Char7.Text.Contains(c.ToString()))
                    {
                        game2EnglishHard.attempt3Char7.Text = "";

                    }
                    else if (game2EnglishHard.attempt3Char6.Text.Contains(c.ToString()) && game2EnglishHard.attempt3Char7.Text == "")
                    {
                        game2EnglishHard.attempt3Char6.Text = "";

                    }
                    else if (game2EnglishHard.attempt3Char5.Text.Contains(c.ToString()) && game2EnglishHard.attempt3Char6.Text == "")
                    {
                        game2EnglishHard.attempt3Char5.Text = "";

                    }
                    else if (game2EnglishHard.attempt3Char4.Text.Contains(c.ToString()) && game2EnglishHard.attempt3Char5.Text == "")
                    {
                        game2EnglishHard.attempt3Char4.Text = "";

                    }
                    else if (game2EnglishHard.attempt3Char3.Text.Contains(c.ToString()) && game2EnglishHard.attempt3Char4.Text == "")
                    {
                        game2EnglishHard.attempt3Char3.Text = "";

                    }
                    else if (game2EnglishHard.attempt3Char2.Text.Contains(c.ToString()) && game2EnglishHard.attempt3Char3.Text == "")
                    {
                        game2EnglishHard.attempt3Char2.Text = "";

                    }
                    else if (game2EnglishHard.attempt3Char1.Text.Contains(c.ToString()) && game2EnglishHard.attempt3Char2.Text == "")
                    {
                        game2EnglishHard.attempt3Char1.Text = "";

                    }
                }//endif attempt 3

                if (game2EnglishHard.attempt4)
                {
                    //attempt4 
                    if (game2EnglishHard.attempt4Char7.Text.Contains(c.ToString()))
                    {
                        game2EnglishHard.attempt4Char7.Text = "";

                    }
                    else if (game2EnglishHard.attempt4Char6.Text.Contains(c.ToString()) && game2EnglishHard.attempt4Char7.Text == "")
                    {
                        game2EnglishHard.attempt4Char6.Text = "";

                    }
                    else if (game2EnglishHard.attempt4Char5.Text.Contains(c.ToString()) && game2EnglishHard.attempt4Char6.Text == "")
                    {
                        game2EnglishHard.attempt4Char5.Text = "";

                    }
                    else if (game2EnglishHard.attempt4Char4.Text.Contains(c.ToString()) && game2EnglishHard.attempt4Char5.Text == "")
                    {
                        game2EnglishHard.attempt4Char4.Text = "";

                    }
                    else if (game2EnglishHard.attempt4Char3.Text.Contains(c.ToString()) && game2EnglishHard.attempt4Char4.Text == "")
                    {
                        game2EnglishHard.attempt4Char3.Text = "";

                    }
                    else if (game2EnglishHard.attempt4Char2.Text.Contains(c.ToString()) && game2EnglishHard.attempt4Char3.Text == "")
                    {
                        game2EnglishHard.attempt4Char2.Text = "";

                    }
                    else if (game2EnglishHard.attempt4Char1.Text.Contains(c.ToString()) && game2EnglishHard.attempt4Char2.Text == "")
                    {
                        game2EnglishHard.attempt4Char1.Text = "";

                    }
                }//endif attempt 4

                if (game2EnglishHard.attempt5)
                {
                    //attempt5 
                    if (game2EnglishHard.attempt5Char7.Text.Contains(c.ToString()))
                    {
                        game2EnglishHard.attempt5Char7.Text = "";

                    }
                    else if (game2EnglishHard.attempt5Char6.Text.Contains(c.ToString()) && game2EnglishHard.attempt5Char7.Text == "")
                    {
                        game2EnglishHard.attempt5Char6.Text = "";

                    }
                    else if (game2EnglishHard.attempt5Char5.Text.Contains(c.ToString()) && game2EnglishHard.attempt5Char6.Text == "")
                    {
                        game2EnglishHard.attempt5Char5.Text = "";

                    }
                    else if (game2EnglishHard.attempt5Char4.Text.Contains(c.ToString()) && game2EnglishHard.attempt5Char5.Text == "")
                    {
                        game2EnglishHard.attempt5Char4.Text = "";

                    }
                    else if (game2EnglishHard.attempt5Char3.Text.Contains(c.ToString()) && game2EnglishHard.attempt5Char4.Text == "")
                    {
                        game2EnglishHard.attempt5Char3.Text = "";

                    }
                    else if (game2EnglishHard.attempt5Char2.Text.Contains(c.ToString()) && game2EnglishHard.attempt5Char3.Text == "")
                    {
                        game2EnglishHard.attempt5Char2.Text = "";

                    }
                    else if (game2EnglishHard.attempt5Char1.Text.Contains(c.ToString()) && game2EnglishHard.attempt5Char2.Text == "")
                    {
                        game2EnglishHard.attempt5Char1.Text = "";

                    }
                }//endif attempt 5

                if (game2EnglishHard.attempt6)
                {
                    //attempt6 
                    if (game2EnglishHard.attempt6Char7.Text.Contains(c.ToString()))
                    {
                        game2EnglishHard.attempt6Char7.Text = "";

                    }
                    else if (game2EnglishHard.attempt6Char6.Text.Contains(c.ToString()) && game2EnglishHard.attempt6Char7.Text == "")
                    {
                        game2EnglishHard.attempt6Char6.Text = "";

                    }
                    else if (game2EnglishHard.attempt6Char5.Text.Contains(c.ToString()) && game2EnglishHard.attempt6Char6.Text == "")
                    {
                        game2EnglishHard.attempt6Char5.Text = "";

                    }
                    else if (game2EnglishHard.attempt6Char4.Text.Contains(c.ToString()) && game2EnglishHard.attempt6Char5.Text == "")
                    {
                        game2EnglishHard.attempt6Char4.Text = "";

                    }
                    else if (game2EnglishHard.attempt6Char3.Text.Contains(c.ToString()) && game2EnglishHard.attempt6Char4.Text == "")
                    {
                        game2EnglishHard.attempt6Char3.Text = "";

                    }
                    else if (game2EnglishHard.attempt6Char2.Text.Contains(c.ToString()) && game2EnglishHard.attempt6Char3.Text == "")
                    {
                        game2EnglishHard.attempt6Char2.Text = "";

                    }
                    else if (game2EnglishHard.attempt6Char1.Text.Contains(c.ToString()) && game2EnglishHard.attempt6Char2.Text == "")
                    {
                        game2EnglishHard.attempt6Char1.Text = "";

                    }
                }//endif attempt 6
            }//end for loop
        }


        //FILIPINO EASY
        public static void GM2FilipinoRemoveCharEasy()
        {
            //loop for letters a-z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (game2FilipinoEasy.attempt1)
                {
                    //attempt1 
                    if (game2FilipinoEasy.attempt1Char5.Text.Contains(c.ToString()))
                    {
                        game2FilipinoEasy.attempt1Char5.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt1Char4.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt1Char5.Text == "")
                    {
                        game2FilipinoEasy.attempt1Char4.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt1Char3.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt1Char4.Text == "")
                    {
                        game2FilipinoEasy.attempt1Char3.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt1Char2.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt1Char3.Text == "")
                    {
                        game2FilipinoEasy.attempt1Char2.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt1Char1.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt1Char2.Text == "")
                    {
                        game2FilipinoEasy.attempt1Char1.Text = "";

                    }
                }//endif attempt 1

                if (game2FilipinoEasy.attempt2)
                {
                    //attempt2 
                    if (game2FilipinoEasy.attempt2Char5.Text.Contains(c.ToString()))
                    {
                        game2FilipinoEasy.attempt2Char5.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt2Char4.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt2Char5.Text == "")
                    {
                        game2FilipinoEasy.attempt2Char4.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt2Char3.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt2Char4.Text == "")
                    {
                        game2FilipinoEasy.attempt2Char3.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt2Char2.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt2Char3.Text == "")
                    {
                        game2FilipinoEasy.attempt2Char2.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt2Char1.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt2Char2.Text == "")
                    {
                        game2FilipinoEasy.attempt2Char1.Text = "";

                    }
                }//endif attempt 2

                if (game2FilipinoEasy.attempt3)
                {
                    //attempt3 
                    if (game2FilipinoEasy.attempt3Char5.Text.Contains(c.ToString()))
                    {
                        game2FilipinoEasy.attempt3Char5.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt3Char4.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt3Char5.Text == "")
                    {
                        game2FilipinoEasy.attempt3Char4.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt3Char3.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt3Char4.Text == "")
                    {
                        game2FilipinoEasy.attempt3Char3.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt3Char2.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt3Char3.Text == "")
                    {
                        game2FilipinoEasy.attempt3Char2.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt3Char1.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt3Char2.Text == "")
                    {
                        game2FilipinoEasy.attempt3Char1.Text = "";

                    }
                }//endif attempt 3

                if (game2FilipinoEasy.attempt4)
                {
                    //attempt4 
                    if (game2FilipinoEasy.attempt4Char5.Text.Contains(c.ToString()))
                    {
                        game2FilipinoEasy.attempt4Char5.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt4Char4.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt4Char5.Text == "")
                    {
                        game2FilipinoEasy.attempt4Char4.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt4Char3.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt4Char4.Text == "")
                    {
                        game2FilipinoEasy.attempt4Char3.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt4Char2.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt4Char3.Text == "")
                    {
                        game2FilipinoEasy.attempt4Char2.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt4Char1.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt4Char2.Text == "")
                    {
                        game2FilipinoEasy.attempt4Char1.Text = "";

                    }
                }//endif attempt 4

                if (game2FilipinoEasy.attempt5)
                {
                    //attempt5 
                    if (game2FilipinoEasy.attempt5Char5.Text.Contains(c.ToString()))
                    {
                        game2FilipinoEasy.attempt5Char5.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt5Char4.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt5Char5.Text == "")
                    {
                        game2FilipinoEasy.attempt5Char4.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt5Char3.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt5Char4.Text == "")
                    {
                        game2FilipinoEasy.attempt5Char3.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt5Char2.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt5Char3.Text == "")
                    {
                        game2FilipinoEasy.attempt5Char2.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt5Char1.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt5Char2.Text == "")
                    {
                        game2FilipinoEasy.attempt5Char1.Text = "";

                    }
                }//endif attempt 5

                if (game2FilipinoEasy.attempt6)
                {
                    //attempt6 
                    if (game2FilipinoEasy.attempt6Char5.Text.Contains(c.ToString()))
                    {
                        game2FilipinoEasy.attempt6Char5.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt6Char4.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt6Char5.Text == "")
                    {
                        game2FilipinoEasy.attempt6Char4.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt6Char3.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt6Char4.Text == "")
                    {
                        game2FilipinoEasy.attempt6Char3.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt6Char2.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt6Char3.Text == "")
                    {
                        game2FilipinoEasy.attempt6Char2.Text = "";

                    }
                    else if (game2FilipinoEasy.attempt6Char1.Text.Contains(c.ToString()) && game2FilipinoEasy.attempt6Char2.Text == "")
                    {
                        game2FilipinoEasy.attempt6Char1.Text = "";

                    }
                }//endif attempt 6
            }//end for loop
        }


        //GAMEMODE 2 FLIPINO, MEDIUM
        public static void GM2FilipinoRemoveCharMedium()
        {
            //loop for letters a-z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (game2FilipinoMedium.attempt1)
                {
                    //attempt1

                    if (game2FilipinoMedium.attempt1Char6.Text.Contains(c.ToString()))
                    {
                        game2FilipinoMedium.attempt1Char6.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt1Char5.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt1Char6.Text == "")
                    {
                        game2FilipinoMedium.attempt1Char5.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt1Char4.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt1Char5.Text == "")
                    {
                        game2FilipinoMedium.attempt1Char4.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt1Char3.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt1Char4.Text == "")
                    {
                        game2FilipinoMedium.attempt1Char3.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt1Char2.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt1Char3.Text == "")
                    {
                        game2FilipinoMedium.attempt1Char2.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt1Char1.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt1Char2.Text == "")
                    {
                        game2FilipinoMedium.attempt1Char1.Text = "";

                    }

                }//endif attempt 1

                if (game2FilipinoMedium.attempt2)
                {
                    //attempt2 
                    if (game2FilipinoMedium.attempt2Char6.Text.Contains(c.ToString()))
                    {
                        game2FilipinoMedium.attempt2Char6.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt2Char5.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt2Char6.Text == "")
                    {
                        game2FilipinoMedium.attempt2Char5.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt2Char4.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt2Char5.Text == "")
                    {
                        game2FilipinoMedium.attempt2Char4.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt2Char3.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt2Char4.Text == "")
                    {
                        game2FilipinoMedium.attempt2Char3.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt2Char2.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt2Char3.Text == "")
                    {
                        game2FilipinoMedium.attempt2Char2.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt2Char1.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt2Char2.Text == "")
                    {
                        game2FilipinoMedium.attempt2Char1.Text = "";

                    }
                }//endif attempt 2

                if (game2FilipinoMedium.attempt3)
                {
                    //attempt3 
                    if (game2FilipinoMedium.attempt3Char6.Text.Contains(c.ToString()))
                    {
                        game2FilipinoMedium.attempt3Char6.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt3Char5.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt3Char6.Text == "")
                    {
                        game2FilipinoMedium.attempt3Char5.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt3Char4.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt3Char5.Text == "")
                    {
                        game2FilipinoMedium.attempt3Char4.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt3Char3.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt3Char4.Text == "")
                    {
                        game2FilipinoMedium.attempt3Char3.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt3Char2.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt3Char3.Text == "")
                    {
                        game2FilipinoMedium.attempt3Char2.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt3Char1.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt3Char2.Text == "")
                    {
                        game2FilipinoMedium.attempt3Char1.Text = "";

                    }
                }//endif attempt 3

                if (game2FilipinoMedium.attempt4)
                {
                    //attempt4 
                    if (game2FilipinoMedium.attempt4Char6.Text.Contains(c.ToString()))
                    {
                        game2FilipinoMedium.attempt4Char6.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt4Char5.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt4Char6.Text == "")
                    {
                        game2FilipinoMedium.attempt4Char5.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt4Char4.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt4Char5.Text == "")
                    {
                        game2FilipinoMedium.attempt4Char4.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt4Char3.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt4Char4.Text == "")
                    {
                        game2FilipinoMedium.attempt4Char3.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt4Char2.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt4Char3.Text == "")
                    {
                        game2FilipinoMedium.attempt4Char2.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt4Char1.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt4Char2.Text == "")
                    {
                        game2FilipinoMedium.attempt4Char1.Text = "";

                    }
                }//endif attempt 4

                if (game2FilipinoMedium.attempt5)
                {
                    //attempt5 
                    if (game2FilipinoMedium.attempt5Char6.Text.Contains(c.ToString()))
                    {
                        game2FilipinoMedium.attempt5Char6.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt5Char5.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt5Char6.Text == "")
                    {
                        game2FilipinoMedium.attempt5Char5.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt5Char4.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt5Char5.Text == "")
                    {
                        game2FilipinoMedium.attempt5Char4.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt5Char3.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt5Char4.Text == "")
                    {
                        game2FilipinoMedium.attempt5Char3.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt5Char2.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt5Char3.Text == "")
                    {
                        game2FilipinoMedium.attempt5Char2.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt5Char1.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt5Char2.Text == "")
                    {
                        game2FilipinoMedium.attempt5Char1.Text = "";

                    }
                }//endif attempt 5

                if (game2FilipinoMedium.attempt6)
                {
                    //attempt6 
                    if (game2FilipinoMedium.attempt6Char6.Text.Contains(c.ToString()))
                    {
                        game2FilipinoMedium.attempt6Char6.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt6Char5.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt6Char6.Text == "")
                    {
                        game2FilipinoMedium.attempt6Char5.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt6Char4.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt6Char5.Text == "")
                    {
                        game2FilipinoMedium.attempt6Char4.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt6Char3.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt6Char4.Text == "")
                    {
                        game2FilipinoMedium.attempt6Char3.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt6Char2.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt6Char3.Text == "")
                    {
                        game2FilipinoMedium.attempt6Char2.Text = "";

                    }
                    else if (game2FilipinoMedium.attempt6Char1.Text.Contains(c.ToString()) && game2FilipinoMedium.attempt6Char2.Text == "")
                    {
                        game2FilipinoMedium.attempt6Char1.Text = "";

                    }
                }//endif attempt 6
            }//end for loop
        }


        //FILIPINO, HARD
        public static void GM2FilipinoRemoveCharHard()
        {
            //loop for letters a-z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (game2FilipinoHard.attempt1)
                {
                    //attempt1

                    if (game2FilipinoHard.attempt1Char7.Text.Contains(c.ToString()))
                    {
                        game2FilipinoHard.attempt1Char7.Text = "";

                    }
                    else if (game2FilipinoHard.attempt1Char6.Text.Contains(c.ToString()) && game2FilipinoHard.attempt1Char7.Text == "")
                    {
                        game2FilipinoHard.attempt1Char6.Text = "";

                    }
                    else if (game1EnglishHard.attempt1Char5.Text.Contains(c.ToString()) && game2FilipinoHard.attempt1Char6.Text == "")
                    {
                        game2FilipinoHard.attempt1Char5.Text = "";

                    }
                    else if (game2FilipinoHard.attempt1Char4.Text.Contains(c.ToString()) && game2FilipinoHard.attempt1Char5.Text == "")
                    {
                        game2FilipinoHard.attempt1Char4.Text = "";

                    }
                    else if (game2FilipinoHard.attempt1Char3.Text.Contains(c.ToString()) && game2FilipinoHard.attempt1Char4.Text == "")
                    {
                        game2FilipinoHard.attempt1Char3.Text = "";

                    }
                    else if (game2FilipinoHard.attempt1Char2.Text.Contains(c.ToString()) && game2FilipinoHard.attempt1Char3.Text == "")
                    {
                        game2FilipinoHard.attempt1Char2.Text = "";

                    }
                    else if (game2FilipinoHard.attempt1Char1.Text.Contains(c.ToString()) && game2FilipinoHard.attempt1Char2.Text == "")
                    {
                        game2FilipinoHard.attempt1Char1.Text = "";

                    }

                }//endif attempt 1

                if (game2FilipinoHard.attempt2)
                {
                    //attempt2 
                    if (game2FilipinoHard.attempt2Char7.Text.Contains(c.ToString()))
                    {
                        game2FilipinoHard.attempt2Char7.Text = "";

                    }
                    else if (game2FilipinoHard.attempt2Char6.Text.Contains(c.ToString()) && game2FilipinoHard.attempt2Char7.Text == "")
                    {
                        game2FilipinoHard.attempt2Char6.Text = "";

                    }
                    else if (game2FilipinoHard.attempt2Char5.Text.Contains(c.ToString()) && game2FilipinoHard.attempt2Char6.Text == "")
                    {
                        game2FilipinoHard.attempt2Char5.Text = "";

                    }
                    else if (game2FilipinoHard.attempt2Char4.Text.Contains(c.ToString()) && game2FilipinoHard.attempt2Char5.Text == "")
                    {
                        game2FilipinoHard.attempt2Char4.Text = "";

                    }
                    else if (game2FilipinoHard.attempt2Char3.Text.Contains(c.ToString()) && game2FilipinoHard.attempt2Char4.Text == "")
                    {
                        game2FilipinoHard.attempt2Char3.Text = "";

                    }
                    else if (game2FilipinoHard.attempt2Char2.Text.Contains(c.ToString()) && game2FilipinoHard.attempt2Char3.Text == "")
                    {
                        game2FilipinoHard.attempt2Char2.Text = "";

                    }
                    else if (game2FilipinoHard.attempt2Char1.Text.Contains(c.ToString()) && game2FilipinoHard.attempt2Char2.Text == "")
                    {
                        game2FilipinoHard.attempt2Char1.Text = "";

                    }
                }//endif attempt 2

                if (game2FilipinoHard.attempt3)
                {
                    //attempt3 
                    if (game2FilipinoHard.attempt3Char7.Text.Contains(c.ToString()))
                    {
                        game2FilipinoHard.attempt3Char7.Text = "";

                    }
                    else if (game2FilipinoHard.attempt3Char6.Text.Contains(c.ToString()) && game2FilipinoHard.attempt3Char7.Text == "")
                    {
                        game2FilipinoHard.attempt3Char6.Text = "";

                    }
                    else if (game2FilipinoHard.attempt3Char5.Text.Contains(c.ToString()) && game2FilipinoHard.attempt3Char6.Text == "")
                    {
                        game2FilipinoHard.attempt3Char5.Text = "";

                    }
                    else if (game2FilipinoHard.attempt3Char4.Text.Contains(c.ToString()) && game2FilipinoHard.attempt3Char5.Text == "")
                    {
                        game2FilipinoHard.attempt3Char4.Text = "";

                    }
                    else if (game2FilipinoHard.attempt3Char3.Text.Contains(c.ToString()) && game2FilipinoHard.attempt3Char4.Text == "")
                    {
                        game2FilipinoHard.attempt3Char3.Text = "";

                    }
                    else if (game2FilipinoHard.attempt3Char2.Text.Contains(c.ToString()) && game2FilipinoHard.attempt3Char3.Text == "")
                    {
                        game2FilipinoHard.attempt3Char2.Text = "";

                    }
                    else if (game2FilipinoHard.attempt3Char1.Text.Contains(c.ToString()) && game2FilipinoHard.attempt3Char2.Text == "")
                    {
                        game2FilipinoHard.attempt3Char1.Text = "";

                    }
                }//endif attempt 3

                if (game2FilipinoHard.attempt4)
                {
                    //attempt4 
                    if (game2FilipinoHard.attempt4Char7.Text.Contains(c.ToString()))
                    {
                        game2FilipinoHard.attempt4Char7.Text = "";

                    }
                    else if (game2FilipinoHard.attempt4Char6.Text.Contains(c.ToString()) && game2FilipinoHard.attempt4Char7.Text == "")
                    {
                        game2FilipinoHard.attempt4Char6.Text = "";

                    }
                    else if (game2FilipinoHard.attempt4Char5.Text.Contains(c.ToString()) && game2FilipinoHard.attempt4Char6.Text == "")
                    {
                        game2FilipinoHard.attempt4Char5.Text = "";

                    }
                    else if (game2FilipinoHard.attempt4Char4.Text.Contains(c.ToString()) && game2FilipinoHard.attempt4Char5.Text == "")
                    {
                        game2FilipinoHard.attempt4Char4.Text = "";

                    }
                    else if (game2FilipinoHard.attempt4Char3.Text.Contains(c.ToString()) && game2FilipinoHard.attempt4Char4.Text == "")
                    {
                        game2FilipinoHard.attempt4Char3.Text = "";

                    }
                    else if (game2FilipinoHard.attempt4Char2.Text.Contains(c.ToString()) && game2FilipinoHard.attempt4Char3.Text == "")
                    {
                        game2FilipinoHard.attempt4Char2.Text = "";

                    }
                    else if (game2FilipinoHard.attempt4Char1.Text.Contains(c.ToString()) && game2FilipinoHard.attempt4Char2.Text == "")
                    {
                        game2FilipinoHard.attempt4Char1.Text = "";

                    }
                }//endif attempt 4

                if (game2FilipinoHard.attempt5)
                {
                    //attempt5 
                    if (game2FilipinoHard.attempt5Char7.Text.Contains(c.ToString()))
                    {
                        game2FilipinoHard.attempt5Char7.Text = "";

                    }
                    else if (game2FilipinoHard.attempt5Char6.Text.Contains(c.ToString()) && game2FilipinoHard.attempt5Char7.Text == "")
                    {
                        game2FilipinoHard.attempt5Char6.Text = "";

                    }
                    else if (game2FilipinoHard.attempt5Char5.Text.Contains(c.ToString()) && game2FilipinoHard.attempt5Char6.Text == "")
                    {
                        game2FilipinoHard.attempt5Char5.Text = "";

                    }
                    else if (game2FilipinoHard.attempt5Char4.Text.Contains(c.ToString()) && game2FilipinoHard.attempt5Char5.Text == "")
                    {
                        game2FilipinoHard.attempt5Char4.Text = "";

                    }
                    else if (game2FilipinoHard.attempt5Char3.Text.Contains(c.ToString()) && game2FilipinoHard.attempt5Char4.Text == "")
                    {
                        game2FilipinoHard.attempt5Char3.Text = "";

                    }
                    else if (game2FilipinoHard.attempt5Char2.Text.Contains(c.ToString()) && game2FilipinoHard.attempt5Char3.Text == "")
                    {
                        game2FilipinoHard.attempt5Char2.Text = "";

                    }
                    else if (game2FilipinoHard.attempt5Char1.Text.Contains(c.ToString()) && game2FilipinoHard.attempt5Char2.Text == "")
                    {
                        game2FilipinoHard.attempt5Char1.Text = "";

                    }
                }//endif attempt 5

                if (game2FilipinoHard.attempt6)
                {
                    //attempt6 
                    if (game2FilipinoHard.attempt6Char7.Text.Contains(c.ToString()))
                    {
                        game2FilipinoHard.attempt6Char7.Text = "";

                    }
                    else if (game2FilipinoHard.attempt6Char6.Text.Contains(c.ToString()) && game2FilipinoHard.attempt6Char7.Text == "")
                    {
                        game2FilipinoHard.attempt6Char6.Text = "";

                    }
                    else if (game2FilipinoHard.attempt6Char5.Text.Contains(c.ToString()) && game2FilipinoHard.attempt6Char6.Text == "")
                    {
                        game2FilipinoHard.attempt6Char5.Text = "";

                    }
                    else if (game2FilipinoHard.attempt6Char4.Text.Contains(c.ToString()) && game2FilipinoHard.attempt6Char5.Text == "")
                    {
                        game2FilipinoHard.attempt6Char4.Text = "";

                    }
                    else if (game2FilipinoHard.attempt6Char3.Text.Contains(c.ToString()) && game2FilipinoHard.attempt6Char4.Text == "")
                    {
                        game2FilipinoHard.attempt6Char3.Text = "";

                    }
                    else if (game2FilipinoHard.attempt6Char2.Text.Contains(c.ToString()) && game2FilipinoHard.attempt6Char3.Text == "")
                    {
                        game2FilipinoHard.attempt6Char2.Text = "";

                    }
                    else if (game2FilipinoHard.attempt6Char1.Text.Contains(c.ToString()) && game2FilipinoHard.attempt6Char2.Text == "")
                    {
                        game2FilipinoHard.attempt6Char1.Text = "";

                    }
                }//endif attempt 6
            }//end for loop
        }
    }
}


