using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
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
            "computer", "gamer", "programmers", "life", "cookie", "hangman", "semester", "novelo", "technology",
            "arizona"
        };
        
        public bool compC, compO, compM, compP, compU, compT, compE, compR;
        public bool gamerG, gamerA, gamerM, gamerE, gamerR;
        public bool proP, proR, proO, proG, proRR, proA, proM, proMM, proE, proRRR, proS;
        public bool lifeL, lifeI, lifeF, lifeE;
        public bool cookC, cookO, cookOO, cookK, cookI, cookE;
        public bool hangH, hangA, hangN, hangG, hangM, hangAA, hangNN;
        public bool semS, semE, semM, semEE, semSS, semT, semEEE, semR;
        public bool novN, novO, novV, novE, novL, novOO;
        public bool tecT, tecE, tecC, tecH, tecN, tecO, tecL, tecOO, tecG, tecY;
        public bool ariA, ariR, ariI, ariZ, ariO, ariN, ariAA;

        private string theWord;
        public string hint;
        public int counterBoi;

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
                ariZ = true;
                WinCheck();
            }

            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            if (theWord == "technology")
            {
                letter10.Text = "Y";
                tecY = true;
                WinCheck();
            }
            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            if (theWord == "novelo")
            {
                letter3.Text = "V";
                novV = true;
                WinCheck();
            }

            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            if (theWord == "computer")
            {
                letter6.Text = "T";
                compT = true;
                WinCheck();
            }
            else if (theWord == "semester")
            {
                letter6.Text = "T";
                semT = true;
                WinCheck();
            }
            else if (theWord == "technology")
            {
                letter1.Text = "T";
                tecT = true;
                WinCheck();
            }
            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            if (theWord == "semester")
            {
                letter1.Text = "S";
                letter5.Text = "S";
                semS = true;
                semSS = true;
                WinCheck();
            }
            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            if (theWord == "gamer")
            {
                letter5.Text = "R";
                gamerR = true;
                WinCheck();
            }

            else if (theWord == "computer")
            {
                letter8.Text = "R";
                compR = true;
                WinCheck();
            }
            else if (theWord == "programmers")
            {
                letter2.Text = "R";
                letter5.Text = "R";
                letter9.Text = "R";
                proR = true;
                proRR = true;
                proRRR = true;
                WinCheck();
            }
            else if (theWord == "semester")
            {
                letter8.Text = "R";
                semR = true;
                WinCheck();
            }
            else if (theWord == "arizona")
            {
                letter2.Text = "R";
                ariR = true;
                WinCheck();
            }
            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            if (theWord == "computer")
            {
                letter4.Text = "P";
                compP = true;
                WinCheck();
            }
            else if (theWord == "programmers")
            {
                letter1.Text = "P";
                proP = true;
                WinCheck();
            }
            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            if (theWord == "novelo")
            {
                letter1.Text = "N";
                novN = true;
                WinCheck();
            }
            else if (theWord == "technology")
            {
                letter5.Text = "N";
                tecN = true;
                WinCheck();
            }
            else if (theWord == "hangman")
            {
                letter3.Text = "N";
                letter7.Text = "N";
                hangN = true;
                hangNN = true;
                WinCheck();
            }
            else if (theWord == "arizona")
            {
                letter6.Text = "N";
                ariN = true;
                WinCheck();
            }
            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            if (theWord == "computer")
            {
                letter3.Text = "M";
                compM = true;
                WinCheck();
            }
            else if (theWord == "gamer")
            {
                letter3.Text = "M";
                gamerM = true;
                WinCheck();
            }
            else if (theWord == "programmers")
            {
                letter7.Text = "M";
                letter8.Text = "M";
                proM = true;
                proMM = true;
                WinCheck();
            }
            else if (theWord == "hangman")
            {
                letter5.Text = "M";
                hangM = true;
                WinCheck();
            }
            else if (theWord == "semester")
            {
                letter3.Text = "M";
                semM = true;
                WinCheck();
            }
            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            if (theWord == "life")
            {
                letter1.Text = "L";
                lifeL = true;
                WinCheck();
            }
            else if (theWord == "technology")
            {
                letter7.Text = "L";
                tecL = true;
                WinCheck();
            }
            else if (theWord == "novelo")
            {
                letter5.Text = "L";
                novL = true;
                WinCheck();
            }
            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            if (theWord == "cookie")
            {
                letter4.Text = "K";
                cookK = true;
                WinCheck();
            }
            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            if (theWord == "hangman")
            {
                letter1.Text = "H";
                hangH = true;
                WinCheck();
            }
            else if (theWord == "technology")
            {
                letter4.Text = "H";
                tecH = true;
                WinCheck();
            }
            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            if (theWord == "gamer")
            {
                letter1.Text = "G";
                gamerG = true;
                WinCheck();
            }
            else if (theWord == "programmers")
            {
                letter4.Text = "G";
                proG = true;
                WinCheck();
            }
            else if (theWord == "hangman")
            {
                letter4.Text = "G";
                hangG = true;
                WinCheck();
            }
            else if (theWord == "technology")
            {
                letter8.Text = "G";
                tecG = true;
                WinCheck();
            }
            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            if (theWord == "life")
            {
                letter3.Text = "F";
                lifeF = true;
                WinCheck();
            }
            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            if (theWord == "computer")
            {
                letter5.Text = "U";
                compU = true;
                WinCheck();
            }
            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            if (theWord == "computer")
            {
                letter2.Text = "O";
                compO = true;
                WinCheck();
            }
            else if (theWord == "programmers")
            {
                letter3.Text = "O";
                proO = true;
                WinCheck();
            }
            else if (theWord == "cookie")
            {
                letter2.Text = "O";
                letter3.Text = "O";
                cookO = true;
                cookOO = true;
                WinCheck();
            }
            else if (theWord == "novelo")
            {
                letter2.Text = "O";
                letter6.Text = "O";
                novO = true;
                novOO = true;
                WinCheck();
            }
            else if (theWord == "technology")
            {
                letter6.Text = "O";
                letter8.Text = "O";
                tecO = true;
                tecOO = true;
                WinCheck();
            }
            else if (theWord == "arizona")
            {
                letter5.Text = "O";
                ariO = true;
                WinCheck();
            }
            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            if (theWord == "life")
            {
                letter2.Text = "I";
                lifeI = true;
                WinCheck();
            }
            else if (theWord == "cookie")
            {
                letter5.Text = "I";
                cookI = true;
                WinCheck();
            }
            else if (theWord == "arizona")
            {
                letter3.Text = "I";
                ariI = true;
                WinCheck();
            }
            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (theWord == "computer")
            {
                letter7.Text = "E";
                compE = true;
                WinCheck();
            }
            else if (theWord == "gamer")
            {
                letter4.Text = "E";
                gamerE = true;
                WinCheck();
            }
            else if (theWord == "programmers")
            {
                letter9.Text = "E";
                proE = true;
                WinCheck();
            }
            else if (theWord == "life")
            {
                letter4.Text = "E";
                lifeE = true;
                WinCheck();
            }
            else if (theWord == "cookie")
            {
                letter6.Text = "E";
                cookE = true;
                WinCheck();
            }
            else if (theWord == "semester")
            {
                letter2.Text = "E";
                letter4.Text = "E";
                letter7.Text = "E";
                semE = true;
                semEE = true;
                semEEE = true;
                WinCheck();
            }
            else if (theWord == "technology")
            {
                letter2.Text = "E";
                tecE = true;
                WinCheck();
            }
            else if (theWord == "novelo")
            {
                letter4.Text = "E";
                novE = true;
                WinCheck();
            }
            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (theWord == "computer")
            {
                letter1.Text = "C";
                compC = true;
                WinCheck();
            }
            else if (theWord == "cookie")
            {
                letter1.Text = "C";
                cookC = true;
                WinCheck();
            }
            else if (theWord == "technology")
            {
                letter3.Text = "C";
                tecC = true;
                WinCheck();
            }
            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }

        public hangmanGame()
        {
            InitializeComponent();
            StartGame();
        }

        private void startRound_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        public void WinCheck()
        {
            if (theWord == "computer")
            {
                if (compC == true && compO == true && compM == true && compP == true && compU == true && compT == true && compE == true && compR == true)
                {
                    YouWin();
                }
            }
            if (theWord == "gamer")
            {
                if (gamerG == true && gamerA == true && gamerM == true && gamerE == true && gamerR == true)
                {
                    YouWin();
                }
            }
            if (theWord == "programmers")
            {
                if (proP == true && proR == true && proO == true && proG == true && proRR == true && proA == true && proM == true && proMM == true && proE == true && proRRR == true)
                {
                    YouWin();
                }
            }
            if (theWord == "life")
            {
                if (lifeL == true && lifeI == true && lifeF == true && lifeE == true)
                {
                    YouWin();
                }
            }
            if (theWord == "cookie")
            {
                if (cookC == true && cookO == true && cookOO == true && cookI == true && cookE == true)
                {
                    YouWin();
                }
            }
            if (theWord == "hangman")
            {
                if (hangH == true && hangA == true && hangN == true && hangG == true && hangM == true && hangAA == true && hangNN == true)
                {
                    YouWin();
                }
            }
            if (theWord == "semester")
            {
                if (semS == true && semE == true && semM == true && semEE == true && semSS == true && semT == true && semEEE == true && semR == true)
                {
                    YouWin();
                }
            }
            if (theWord == "novelo")
            {
                if (novN == true && novO == true && novV == true && novE == true && novL == true && novOO == true)
                {
                    YouWin();
                }
            }
            if (theWord == "technology")
            {
                if (tecT == true && tecE == true && tecC == true && tecH == true && tecN == true && tecO == true && tecL == true && tecOO == true && tecG == true && tecY == true)
                {
                    YouWin();
                }
            }
            if (theWord == "arizona")
            {
                if (ariA == true && ariR == true && ariI == true && ariZ == true && ariO == true && ariN == true && ariAA == true)
                {
                    YouWin();
                }
            }
            else
            {
                return;
            }
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
            
            compC = false;
            compO = false;
            compM = false;
            compP = false;
            compU = false;
            compT = false;
            compE = false;
            compR = false;
            gamerG = false;
            gamerA = false;
            gamerM = false;
            gamerE = false;
            gamerR = false;
            proP = false;
            proR = false;
            proO = false;
            proG = false;
            proRR = false;
            proA = false;
            proM = false;
            proMM = false;
            proE = false;
            proRRR = false;
            proS = false;
            lifeL = false;
            lifeI = false;
            lifeF = false;
            lifeE = false;
            cookC = false;
            cookO = false; cookOO = false; cookK = false; cookI = false; cookE = false;
            hangH = false; hangA = false; hangN = false; hangG = false; hangM = false; hangA = false; hangN = false;
            semS = false; semE = false; semM = false; semEE = false; semSS = false; semT = false; semEEE = false; semR = false;
            novN = false; novO = false; novL = false; novE = false; novL = false; novOO = false;
            tecT = false; tecE = false; tecC = false; tecH = false; tecN = false; tecO = false; tecL = false; tecOO = false; tecG = false; tecY = false;
            ariA = false; ariR = false; ariI = false; ariZ = false; ariO = false; ariN = false; ariAA = false;

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

            letter1.Text = "";
            letter2.Text = "";
            letter3.Text = "";
            letter4.Text = "";
            letter5.Text = "";
            letter6.Text = "";
            letter7.Text = "";
            letter8.Text = "";
            letter9.Text = "";
            letter10.Text = "";

            conGrats.Text = "";

            wrong1.Text = "";
            wrong2.Text = "";
            wrong3.Text = "";
            wrong4.Text = "";
            wrong5.Text = "";

            hintBox.Text = "";

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

            if (words[index] == "programmers")
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

        public void YouWin()
        {
            conGrats.Text = "You win!  Hit 'Play' for a new word!";
        }

        public void WrongAnswer()
        {
            if (counterBoi == 5)
            {
                wrong5.Text = "X";
                LoseGame();
            }

            else if (counterBoi == 4)
            {
                wrong4.Text = "X";
                return;
            }

            else if (counterBoi == 3)
            {
                wrong3.Text = "X";
                return;
            }

            else if (counterBoi == 2)
            {
                wrong2.Text = "X";
                return;
            }

            if (counterBoi == 1)
            {
                wrong1.Text = "X";
                return;
            }
        }

        public void LoseGame()
        {
            conGrats.Text = "You lose!  Hit play for a new word.";
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (theWord == "gamer")
            {
                letter2.Text = "A";
                gamerA = true;
                WinCheck();
            }

            else if (theWord == "programmers")
            {
                letter6.Text = "A";
                proA = true;
                WinCheck();
            }

            else if (theWord == "hangman")
            {
                letter2.Text = "A";
                letter6.Text = "A";
                hangA = true;
                hangAA = true;
                WinCheck();
            }

            else if (theWord == "arizona")
            {
                letter1.Text = "A";
                letter7.Text = "A";
                ariA = true;
                ariAA = true;
                WinCheck();
            }

            else
            {
                counterBoi++;
                WrongAnswer();
            }
        }


    }
}
