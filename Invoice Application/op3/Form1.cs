using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace op3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {

            string[] array1 = new string[10];
            array1[0] = "Monke";
            array1[1] = "Noot";
            array1[2] = "Demo";
            array1[3] = "Test";
            array1[4] = "Televisie";
            array1[5] = "Laptop";
            array1[6] = "Gebouw";
            array1[7] = "School";
            array1[8] = "Student";
            array1[9] = "Progammeren";

            string[] array2 = new string[10];

            ArrayCopy(array1, array2, 2, 6);

        }
        private void ArrayCopy(string[] array1, string[] array2, int pos1, int pos2)
        {
            int teller = 0;
            for (int i = pos1; i < pos2; i++)
            {
                array2[teller] = array1[i];
                teller++;
            }
            for (int i = 0; i < array2.Length; i++)
            {
                txtOutput.Text = txtOutput.Text + Environment.NewLine + array2[i];
            }
        }
    }
}
