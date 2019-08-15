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
        
        public bool compC, compO, compM, compP, compU, compT, compE, compR;
        public bool gamerG, gamerA, gamerM, gamerE, gamerR;
        public bool proP, proO, proG, proR, proA, proM, proMM, proE, proR;
        public bool lifeL, lifeI, lifeF, lifeE;
        public bool cookC, cookO, cookOO, cookK, cookI, cookE;
        public bool hangH, hangA, hangN, hangG, hangM, hangA, hangNN;
        public bool semS, semE, semM, semEE, semSS, semT, semEEE, semR;
        public bool novN, novO, novL, novE, novL, novOO;
        public bool tecT, tecE, tecC, tecH, tecN, tecO, tecL, tecOO, tecG, tecY;
        public bool ariA, ariR, ariI, ariZ, ariO, ariN, ariAA;

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
                ariZ = true;
                WinCheck();
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
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            if (theWord == "novelo")
            {
                letter3.Text = "V";
                novV = true;
                WinCheck();
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
            if (theWord == "semester")
            {
                letter6.Text = "T";
                semT = true;
                WinCheck();
            }
            if (theWord == "tech")
            {
                letter1.Text = "T";
                tecT = true;
                WinCheck();
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
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            if (theWord == "gamer")
            {
                letter5.Text = "R";
                gamerR = true;
                WinCheck();
            }
            if (theWord == "computer")
            {
                letter8.Text = "R";
                compR = true;
                WinCheck();
            }
            if (theWord == "programmer")
            {
                letter5.Text = "R";
                letter9.Text = "R";
                proR = true;
                proRR = true;
                WinCheck();
            }
            if (theWord == "semester")
            {
                letter8.Text = "R";
                semR = true;
                WinCheck();
            }
            if (theWord == "arizona")
            {
                letter2.Text = "R";
                ariR = true;
                WinCheck();
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
            if (theWord == "programmer")
            {
                letter1.Text = "P";
                proP = true;
                WinCheck();
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
            if (theWord == "technology")
            {
                letter5.Text = "N";
                tecN = true;
                WinCheck();
            }
            if (theWord == "hangman")
            {
                letter3.Text = "N";
                letter7.Text = "N";
                hangN = true;
                hangNN = true;
                WinCheck();
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
            if (theWord == "gamer")
            {
                letter3.Text = "M";
                gamerM = true;
                WinCheck();
            }
            if (theWord == "programmer")
            {
                letter7.Text = "M";
                letter8.Text = "M";
                proM = true;
                proMM = true;
                WinCheck();
            }
            if (theWord == "hangman")
            {
                letter5.Text = "M";
                hangM = true;
                WinCheck();
            }
            if (theWord == "semester")
            {
                letter3.Text = "M";
                semM = true;
                WinCheck();
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
            if (theWord == "technology")
            {
                letter7.Text = "L";
                tecL = true;
                WinCheck();
            }
            if (theWord == "novelo")
            {
                letter5.Text = "L";
                novL = true;
                WinCheck();
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
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            if (theWord == "hangman")
            {
                letter1.Text = "H";
                hangH = true;
                WinCheck();
            }
            if (theWord == "technology")
            {
                letter4.Text = "H";
                tecH = true;
                WinCheck();
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
            if (theWord == "programmer")
            {
                letter4.Text = "G";
                proG = true;
                WinCheck();
            }
            if (theWord == "hangman")
            {
                letter4.Text = "G";
                hangG = true;
                WinCheck();
            }
            if (theWord == "technology")
            {
                letter8.Text = "G";
                tecG = true;
                WinCheck();
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
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            if (theWord == "computer")
            {
                letter5.Text = "U";
                compU = true;
                WinCheck();
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
            if (theWord == "programmer")
            {
                letter3.Text = "O";
                proO = true;
                WinCheck();
            }
            if (theWord == "cookie")
            {
                letter2.Text = "O";
                letter3.Text = "O";
                cookO = true;
                cookOO = true;
                WinCheck();
            }
            if (theWord == "novelo")
            {
                letter2.Text = "O";
                letter6.Text = "O";
                novO = true;
                novOO = true;
                WinCheck();
            }
            if (theWord == "technology")
            {
                letter6.Text = "O";
                letter8.Text = "O";
                tecO = true;
                tecOO = true;
                WinCheck();
            }
            if (theWord == "arizona")
            {
                letter5.Text = "O";
                ariO = true;
                WinCheck();
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
            if (theWord == "cookie")
            {
                letter5.Text = "I";
                cookI = true;
                WinCheck();
            }
            if (theWord == "arizona")
            {
                letter3.Text = "I";
                ariI = true;
                WinCheck();
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
            if (theWord == "gamer")
            {
                letter4.Text = "E";
                gamerE = true;
                WinCheck();
            }
            if (theWord == "programmer")
            {
                letter9.Text = "E";
                proE = true;
                WinCheck();
            }
            if (theWord == "life")
            {
                letter4.Text = "E";
                lifeE = true;
                WinCheck();
            }
            if (theWord == "cookie")
            {
                letter6.Text = "E";
                cookE = true;
                WinCheck();
            }
            if (theWord == "semester")
            {
                letter2.Text = "E";
                letter4.Text = "E";
                letter7.Text = "E";
                semE = true;
                semEE = true;
                semEEE = true;
                WinCheck();
            }
            if (theWord == "technology")
            {
                letter2.Text = "E";
                tecE = true;
                WinCheck();
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
            if (theWord == "cookie")
            {
                letter1.Text = "C";
                cookC = true;
                WinCheck();
            }
            if (theWord == "technology")
            {
                letter3.Text = "C";
                tecC = true;
                WinCheck();
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

        public void WinCheck()
        {
            if (theWord = "computer")
            {
                if (compC == true && compO == true && compM == true && compP == true && compU == true && compT == true && compE == true && compR == true)
                {
                
                }
            }
            if (theWord = "gamer")
            {
                if (gamerG = true && gamerA = true && gamerM = true && gamerE = true && gamerR = true)
                {
                
                }
            }
            if (theWord = "programmer")
            {
                if (proP = true && proO = true && proG = true && proR = true && proA = true && proM = true && proMM = true && proE = true && proR = true)
                {
                
                }
            }
            if (theWord = "life")
            {
                if (lifeL = true && lifeI = true && lifeF = true && lifeE = true)
                {
                
                }
            }
            if (theWord = "cookie")
            {
                if (cookC = true && cookO = true && cookOO = true && cookI = true && cookE = true)
                {
                
                }
            }
            if (theWord = "hangman")
            {
                if (hangH = true && hangA = true && hangN = true && hangG = true && hangM = true && hangA = true && hangNN = true)
                {
                
                }
            }
            if (theWord = "semester")
            {
                if (semS = true && semE = true && semM = true && semEE = true && semSS = true && semT = true && semEEE = true && semR = true)
                {
                
                }
            }
            if (theWord = "novelo")
            {
                if (novN = true && novO = true && novV = true && novE = true && novL = true && novOO = true)
                {
                
                }
            }
            if (theWord = "technology")
            {
                if (tecT = true && tecE = true && tecC = true && tecH = true && tecN = true && tecO = true && tecL = true && tecOO = true && tecG = true && tecY = true)
                {
                
                }
            }
            if (theWord = "arizona")
            {
                if (ariA = true && ariR = true && ariI = true && ariZ = true && ariO = true && ariN = true && ariAA = true)
                {
                
                }
            }
            else
            {
            
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
            proO = false;
            proG = false;
            proR = false;
            proA = false;
            proM = false;
            proMM = false;
            proE = false;
            proR = false;
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
