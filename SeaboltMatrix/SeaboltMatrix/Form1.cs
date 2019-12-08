//Peyton Seabolt
//HW 7 C#
// This doesn't work properly.  It will show the 2 intergers and operator, and show which operation needs to be ran.
//  the issues come from not understanding the matrix enough to properly edit rows and columns, and not knowing how to properly add the correct number of fractions to the matrix depending on the input file's specifications.
// It's hard to tell what else I screwed up a long the way.  Jesus, I tried though.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SeaboltMatrix
{
    public partial class Form1 : Form
    {
        Fraction fracAns1;
        Fraction fracAns2;
        Matrix<Fraction> a;
        Matrix<Fraction> b;
        Matrix<Fraction> c;
        Fraction frac1;
        Fraction frac2;
        Fraction frac3;
        Fraction frac4;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                System.IO.StreamReader sr = new System.IO.StreamReader(openFile.FileName);
                string text = sr.ReadLine();
                string[] bits = text.Split(' ');
                int n = int.Parse(bits[0]);//row
                int y = int.Parse(bits[1]);//column
                string z = bits[2];//operator
                MessageBox.Show(n + " " + y + " " + z); // shows the row, column, and operator
                if(z == "+")
                {
                    MessageBox.Show("This is plus."); //tests for correct input                                           
                    String temp = sr.ReadLine();
                    String[] substrings = temp.Split(' '); //doesnt take into account the space between each fraction
                    String temp0 = substrings[0];
                    String temp1 = substrings[1];
                    String[] temparr = temp0.Split('/');
                    String[] temparr1 = temp1.Split('/');

                    int intTemp1 = int.Parse(temparr[0]);
                    int intTemp2 = int.Parse(temparr[1]);
                    int intTemp3 = int.Parse(temparr1[0]);
                    int intTemp4 = int.Parse(temparr1[1]);
                    //repeat
                    temp = sr.ReadLine();
                    substrings = temp.Split(' '); //doesnt take into account the space between each fraction
                    temp0 = substrings[0];
                    temp1 = substrings[1];
                    temparr = temp0.Split('/');
                    temparr1 = temp1.Split('/');
                    int intTemp5 = int.Parse(temparr[0]);
                    int intTemp6 = int.Parse(temparr[1]);
                    int intTemp7 = int.Parse(temparr1[0]);
                    int intTemp8 = int.Parse(temparr1[1]);

                    frac1 = new Fraction(intTemp1, intTemp2);
                    frac2 = new Fraction(intTemp3, intTemp4);
                    frac3 = new Fraction(intTemp5, intTemp6);
                    frac4 = new Fraction(intTemp7, intTemp8);

                    Fraction[,] x = { { frac1, frac2 } }; // How do i load more than one?
                    Fraction[,] q = { { frac3, frac4 } };
                    Fraction[,] u = { };
                    a = new Matrix<Fraction>(x);
                    b = new Matrix<Fraction>(q);
                    c = new Matrix<Fraction>(u);
                    c = a + b;
                    MessageBox.Show(c.ToString());
                }
                else if (z == "-")
                {
                    MessageBox.Show("This is minus."); //tests for correct input 
                    String temp = sr.ReadLine();
                    String[] substrings = temp.Split(' '); //doesnt take into account the space between each fraction
                    String temp0 = substrings[0];
                    String temp1 = substrings[1];
                    String[] temparr = temp0.Split('/');
                    String[] temparr1 = temp1.Split('/');
   
                    int intTemp1 = int.Parse(temparr[0]);
                    int intTemp2 = int.Parse(temparr[1]);
                    int intTemp3 = int.Parse(temparr1[0]);
                    int intTemp4 = int.Parse(temparr1[1]);
                    //repeat
                    temp = sr.ReadLine();
                    substrings = temp.Split(' '); //doesnt take into account the space between each fraction
                    temp0 = substrings[0];
                    temp1 = substrings[1];
                    temparr = temp0.Split('/');
                    temparr1 = temp1.Split('/');
                    int intTemp5 = int.Parse(temparr[0]);
                    int intTemp6 = int.Parse(temparr[1]);
                    int intTemp7 = int.Parse(temparr1[0]);
                    int intTemp8 = int.Parse(temparr1[1]);

                    frac1 = new Fraction(intTemp1, intTemp2);
                    frac2 = new Fraction(intTemp3, intTemp4);
                    frac3 = new Fraction(intTemp5, intTemp6);
                    frac4 = new Fraction(intTemp7, intTemp8);

                    Fraction[,] x = { { frac1, frac2 } }; // How do i load more than one?
                    Fraction[,] q = { { frac3, frac4 } };
                    Fraction[,] u = { };
                    a = new Matrix<Fraction>(x);
                    b = new Matrix<Fraction>(q);
                    c = new Matrix<Fraction>(u);
                    c = a - b;
                    MessageBox.Show(c.ToString());
                }
                else if (z == "*")
                {
                    MessageBox.Show("This is multiply."); //tests for correct input 
                    String temp = sr.ReadLine();
                    String[] substrings = temp.Split(' '); //doesnt take into account the space between each fraction
                    String temp0 = substrings[0];
                    String temp1 = substrings[1];
                    String[] temparr = temp0.Split('/');
                    String[] temparr1 = temp1.Split('/');

                    int intTemp1 = int.Parse(temparr[0]);
                    int intTemp2 = int.Parse(temparr[1]);
                    int intTemp3 = int.Parse(temparr1[0]);
                    int intTemp4 = int.Parse(temparr1[1]);
                    //repeat
                    temp = sr.ReadLine();
                    substrings = temp.Split(' '); //doesnt take into account the space between each fraction
                    temp0 = substrings[0];
                    temp1 = substrings[1];
                    temparr = temp0.Split('/');
                    temparr1 = temp1.Split('/');
                    int intTemp5 = int.Parse(temparr[0]);
                    int intTemp6 = int.Parse(temparr[1]);
                    int intTemp7 = int.Parse(temparr1[0]);
                    int intTemp8 = int.Parse(temparr1[1]);

                    frac1 = new Fraction(intTemp1, intTemp2);
                    frac2 = new Fraction(intTemp3, intTemp4);
                    frac3 = new Fraction(intTemp5, intTemp6);
                    frac4 = new Fraction(intTemp7, intTemp8);

                    Fraction[,] x = { { frac1, frac2 } }; // How do i load more than one?
                    Fraction[,] q = { { frac3, frac4 } };
                    fracAns1 = frac1 * frac2;
                    fracAns2 = frac3 * frac4;
                    Fraction[,] u = {{fracAns1, fracAns2}};// I know this isn't what you asked.  Just testing...
                    a = new Matrix<Fraction>(x);
                    b = new Matrix<Fraction>(q);
                    c = new Matrix<Fraction>(u);
                    MessageBox.Show(c.ToString());
                }
              
            }//if for openfile 
        }//btn
    }//class
}
