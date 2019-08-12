using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class hangmanGame : Form
    {
        private string[] words =
        {
            "computer", "gamer", "programmer", "life", "cookie", "hangman", "semester", "novelo", "technology",
            "arizona"
        };

        private string theWord;
        public string hint;

        public bool aPresent,
            bPresent,
            cPresent,
            dPresent,
            ePresent,
            fPresent,
            gPresent,
            hPresent,
            iPresent,
            jPresent,
            kPresent,
            lPresent,
            mPresent,
            nPresent,
            oPresent,
            pPresent,
            qPresent,
            rPresent,
            sPresent,
            tPresent,
            uPresent,
            vPresent,
            wPresent,
            xPresent,
            yPresent,
            zPresent;

        private void buttonZ_Click(object sender, EventArgs e)
        {
            if (theWord == "arizona")
            {
                letter4.Text = "Z";
            }
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            if (theWord == "technology")
            {
                letter10.Text = "Y";
            }
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            if (theWord == "novelo")
            {
                letter3.Text = "V";
            }
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            if (theWord == "computer")
            {
                letter6.Text = "T";
            }
            if (theWord == "semester")
            {
                letter6.Text = "T";
            }
            if (theWord == "tech")
            {
                letter1.Text = "T";
            }
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            if (theWord == "semester")
            {
                letter1.Text = "S";
                letter5.Text = "S";
            }
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            if (theWord == "gamer")
            {
                letter5.Text = "R";
            }
            if (theWord == "computer")
            {
                letter8.Text = "R";
            }
            if (theWord == "programmer")
            {
                letter5.Text = "R";
                letter9.Text = "R";
            }
            if (theWord == "semester")
            {
                letter8.Text = "R";
            }
            if (theWord == "arizona")
            {
                letter2.Text = "R";
            }
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            if (theWord == "computer")
            {
                letter4.Text = "P";
            }
            if (theWord == "programmer")
            {
                letter1.Text = "P";
            }
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            if (theWord == "novelo")
            {
                letter1.Text = "N";
            }
            if (theWord == "technology")
            {
                letter5.Text = "N";
            }
            if (theWord == "hangman")
            {
                letter3.Text = "N";
                letter7.Text = "N";
            }
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            if (theWord == "computer")
            {
                letter3.Text = "M";
            }
            if (theWord == "gamer")
            {
                letter3.Text = "M";
            }
            if (theWord == "programmer")
            {
                letter7.Text = "M";
                letter8.Text = "M";
            }
            if (theWord == "hangman")
            {
                letter5.Text = "M";
            }
            if (theWord == "semester")
            {
                letter3.Text = "M";
            }
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            if (theWord == "life")
            {
                letter1.Text = "L";
            }
            if (theWord == "technology")
            {
                letter7.Text = "L";
            }
            if (theWord == "novelo")
            {
                letter5.Text = "L";
            }
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            if (theWord == "cookie")
            {
                letter4.Text = "K";
            }
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            if (theWord == "hangman")
            {
                letter1.Text = "H";
            }
            if (theWord == "technology")
            {
                letter4.Text = "H";
            }
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            if (theWord == "gamer")
            {
                letter1.Text = "G";
            }
            if (theWord == "programmer")
            {
                letter4.Text = "G";
            }
            if (theWord == "hangman")
            {
                letter4.Text = "G";
            }
            if (theWord == "technology")
            {
                letter8.Text = "G";
            }
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            if (theWord == "life")
            {
                letter3.Text = "F";
            }
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            if (theWord == "computer")
            {
                letter5.Text = "U";
            }
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            if (theWord == "computer")
            {
                letter2.Text = "O";
            }
            if (theWord == "programmer")
            {
                letter3.Text = "O";
            }
            if (theWord == "cookie")
            {
                letter2.Text = "O";
                letter3.Text = "O";
            }
            if (theWord == "novelo")
            {
                letter2.Text = "O";
                letter6.Text = "O";
            }
            if (theWord == "technology")
            {
                letter6.Text = "O";
                letter8.Text = "O";
            }
            if (theWord == "arizona")
            {
                letter5.Text = "O";
            }
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            if (theWord == "life")
            {
                letter2.Text = "I";
            }
            if (theWord == "cookie")
            {
                letter5.Text = "I";
            }
            if (theWord == "arizona")
            {
                letter3.Text = "I";
            }
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (theWord == "computer")
            {
                letter7.Text = "E";
            }
            if (theWord == "gamer")
            {
                letter4.Text = "E";
            }
            if (theWord == "programmer")
            {
                letter9.Text = "E";
            }
            if (theWord == "life")
            {
                letter4.Text = "E";
            }
            if (theWord == "cookie")
            {
                letter6.Text = "E";
            }
            if (theWord == "semester")
            {
                letter2.Text = "E";
                letter4.Text = "E";
                letter7.Text = "E";
            }
            if (theWord == "technology")
            {
                letter2.Text = "E";
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (theWord == "computer")
            {
                letter1.Text = "C";
            }
            if (theWord == "cookie")
            {
                letter1.Text = "C";
            }
            if (theWord == "technology")
            {
                letter3.Text = "C";
            }
        }

        public hangmanGame()
        {
            InitializeComponent();
            StartGame();
        }

        private void startRound_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        public void ResetGame()
        {
            aPresent = false;
            bPresent = false;
            cPresent = false;
            dPresent = false;
            ePresent = false;
            fPresent = false;
            gPresent = false;
            hPresent = false;
            iPresent = false;
            jPresent = false;
            kPresent = false;
            lPresent = false;
            mPresent = false;
            nPresent = false;
            oPresent = false;
            pPresent = false;
            qPresent = false;
            rPresent = false;
            sPresent = false;
            tPresent = false;
            uPresent = false;
            vPresent = false;
            wPresent = false;
            xPresent = false;
            yPresent = false;
            zPresent = false;

            line1.Visible = false;
            line2.Visible = false;
            line3.Visible = false;
            line4.Visible = false;
            line5.Visible = false;
            line6.Visible = false;
            line7.Visible = false;
            line8.Visible = false;
            line9.Visible = false;
            line10.Visible = false;

            StartGame();
        }

        public void StartGame()
        {
            Random rand = new Random();
            int index = rand.Next(words.Length);

            if (words[index] == "computer")
            {
                hint = "Something used for surfing the web, programming, and using this application.";
                theWord = words[index];
                line1.Visible = true;
                line2.Visible = true;
                line3.Visible = true;
                line4.Visible = true;
                line5.Visible = true;
                line6.Visible = true;
                line7.Visible = true;
                line8.Visible = true;
                line9.Visible = false;
                line10.Visible = false;

                cPresent = true;
                oPresent = true;
                mPresent = true;
                pPresent = true;
                uPresent = true;
                tPresent = true;
                ePresent = true;
                rPresent = true;
            }

            if (words[index] == "gamer")
            {
                hint = "A super epic person that plays games.";
                theWord = words[index];
                line1.Visible = true;
                line2.Visible = true;
                line3.Visible = true;
                line4.Visible = true;
                line5.Visible = true;
                line6.Visible = false;
                line7.Visible = false;
                line8.Visible = false;
                line9.Visible = false;
                line10.Visible = false;

                gPresent = true;
                aPresent = true;
                mPresent = true;
                ePresent = true;
                rPresent = true;
            }

            if (words[index] == "programmer")
            {
                hint = "The people who had to create these assignments.";
                theWord = words[index];
                line1.Visible = true;
                line2.Visible = true;
                line3.Visible = true;
                line4.Visible = true;
                line5.Visible = true;
                line6.Visible = true;
                line7.Visible = true;
                line8.Visible = true;
                line9.Visible = true;
                line10.Visible = true;

                pPresent = true;
                rPresent = true;
                oPresent = true;
                gPresent = true;
                rPresent = true;
                aPresent = true;
                mPresent = true;
                ePresent = true;
            }

            if (words[index] == "life")
            {
                hint = "Noone knows the meaning of this.";
                theWord = words[index];
                line1.Visible = true;
                line2.Visible = true;
                line3.Visible = true;
                line4.Visible = true;
                line5.Visible = false;
                line6.Visible = false;
                line7.Visible = false;
                line8.Visible = false;
                line9.Visible = false;
                line10.Visible = false;

                lPresent = true;
                iPresent = true;
                fPresent = true;
                ePresent = true;
            }

            if (words[index] == "cookie")
            {
                hint = "PUT THE ____ DOWN!";
                theWord = words[index];
                line1.Visible = true;
                line2.Visible = true;
                line3.Visible = true;
                line4.Visible = true;
                line5.Visible = true;
                line6.Visible = true;
                line7.Visible = false;
                line8.Visible = false;
                line9.Visible = false;
                line10.Visible = false;

                cPresent = true;
                oPresent = true;
                kPresent = true;
                iPresent = true;
                ePresent = true;
            }

            if (words[index] == "hangman")
            {
                hint = "The game you're playing right now.";
                theWord = words[index];
                line1.Visible = true;
                line2.Visible = true;
                line3.Visible = true;
                line4.Visible = true;
                line5.Visible = true;
                line6.Visible = true;
                line7.Visible = true;
                line8.Visible = false;
                line9.Visible = false;
                line10.Visible = false;

                hPresent = true;
                aPresent = true;
                nPresent = true;
                gPresent = true;
                mPresent = true;
                nPresent = true;
            }

            if (words[index] == "semester")
            {
                hint = "There's two of these in a year, one of which is ending soon.";
                theWord = words[index];
                line1.Visible = true;
                line2.Visible = true;
                line3.Visible = true;
                line4.Visible = true;
                line5.Visible = true;
                line6.Visible = true;
                line7.Visible = true;
                line8.Visible = true;
                line9.Visible = false;
                line10.Visible = false;

                sPresent = true;
                ePresent = true;
                mPresent = true;
                tPresent = true;
                rPresent = true;
            }

            if (words[index] == "novelo")
            {
                hint = "Last name of the teacher for this class.";
                theWord = words[index];
                line1.Visible = true;
                line2.Visible = true;
                line3.Visible = true;
                line4.Visible = true;
                line5.Visible = true;
                line6.Visible = true;
                line7.Visible = false;
                line8.Visible = false;
                line9.Visible = false;
                line10.Visible = false;

                nPresent = true;
                oPresent = true;
                vPresent = true;
                ePresent = true;
                lPresent = true;
            }

            if (words[index] == "technology")
            {
                hint = "Univeristy of Advancing ____.";
                theWord = words[index];
                line1.Visible = true;
                line2.Visible = true;
                line3.Visible = true;
                line4.Visible = true;
                line5.Visible = true;
                line6.Visible = true;
                line7.Visible = true;
                line8.Visible = true;
                line9.Visible = true;
                line10.Visible = true;

                tPresent = true;
                ePresent = true;
                cPresent = true;
                hPresent = true;
                nPresent = true;
                oPresent = true;
                lPresent = true;
                gPresent = true;
                yPresent = true;
            }

            if (words[index] == "arizona")
            {
                hint = "A super hot state next to California";
                theWord = words[index];
                line1.Visible = true;
                line2.Visible = true;
                line3.Visible = true;
                line4.Visible = true;
                line5.Visible = true;
                line6.Visible = true;
                line7.Visible = true;
                line8.Visible = false;
                line9.Visible = false;
                line10.Visible = false;

                aPresent = true;
                rPresent = true;
                iPresent = true;
                zPresent = true;
                oPresent = true;
                nPresent = true;
            }
        }

        private void hintButton_Click(object sender, EventArgs e)
        {
            hintBox.Text = hint;
        }

        private void letterChoices_Enter(object sender, EventArgs e)
        {
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (theWord == "gamer")
            {
                letter2.Text = "A";
            }

            if (theWord == "programmer")
            {
                letter6.Text = "A";
            }

            if (theWord == "hangman")
            {
                letter2.Text = "A";
            }

            if (theWord == "arizona")
            {
                letter1.Text = "A";
                letter7.Text = "A";
            }
        }


    }
}
