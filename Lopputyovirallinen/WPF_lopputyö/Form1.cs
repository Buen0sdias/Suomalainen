using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF_lopputyö
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = x; false = Y turn
        int turn_count = 0;
        static string pelaaja1, pelaaja2;
        public Form1()
        {
            InitializeComponent();
        }

        public static void setPlayerName(string n1, string n2)
        {
            pelaaja1 = n1;
            pelaaja2 = n2;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Moi henkilö", "Ristinollapeli");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "0";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            CheckForWinner();
        }

        private void CheckForWinner()
        {
            bool there_is_a_winner = false;
            // Chekit kaikille
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            //Vertical

            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;

            //Diagonal

            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_winner = true;


            if (there_is_a_winner)
            {
                disableButtons();
                string winner = "";
                if (turn)
                {

                    winner = pelaaja2;
                    ovoitot.Text = (Int32.Parse(ovoitot.Text) + 1).ToString();

                }

                else
                {
                    winner = pelaaja1;
                    xvoitot.Text = (Int32.Parse(xvoitot.Text) + 1).ToString();
                }

                MessageBox.Show(winner + " Voitti!", "Jee!!!");
            } //endin lopetus
            else
            {
                if (turn_count == 9)
                {
                    tasapeli.Text = (Int32.Parse(tasapeli.Text) + 1).ToString();
                    MessageBox.Show(" Tasapeli!", "Jee!");
                }
            }
        } //lopetus chekille

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                } //lopetus foreachille
            }// lopetus trylle
            catch { }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;



            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                } //lopetus foreachille
                catch { }
            }// lopetus trylle
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "0";
        } // endin if lause

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ovoitot.Text = "0";
            xvoitot.Text = "0";
            tasapeli.Text = "0";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        Form3 f3 = new Form3();
            f3.ShowDialog();
            label1.Text = pelaaja1;
            label3.Text = pelaaja2;

        }
    }
}
