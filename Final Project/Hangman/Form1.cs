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

        public hangmanGame()
        {
            InitializeComponent();
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
                hint = "A super hot state next to Cali";
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
