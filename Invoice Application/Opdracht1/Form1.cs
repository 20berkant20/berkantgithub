using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            // Aanmaken van de array waaring 6 hele getallen in kunnen worden opgeslagen
            int[] Dices = new int[6];

            // Vullen van de array met een random getal
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = GenerateRandomNumber();
            }

            //waardes uit de array weergeven in de textboxes op het scherm
            txtDice1.Text = Convert.ToString(Dices[0]);
            txtDice2.Text = Convert.ToString(Dices[1]);
            txtDice3.Text = Convert.ToString(Dices[2]);
            txtDice4.Text = Convert.ToString(Dices[3]);
            txtDice5.Text = Convert.ToString(Dices[4]);
            txtDice6.Text = Convert.ToString(Dices[5]);
        }

        private int GenerateRandomNumber()
        {
            return rnd.Next(1, 7);
        }
        private void txtDice1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
