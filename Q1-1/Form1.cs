using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1_1
{
    public partial class Form1 : Form
    {
        Random rndGen = new Random();
        int i = 0;
        double sum = 0.0;
        double sumComp = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void butCom1_Click(object sender, EventArgs e)
        {

        }

        private void butBet_Click(object sender, EventArgs e)
        {
            string[] comp = new string[4];
            string[] usr = new string[4];

            int NumGenerator()
            {
                
                int p = rndGen.Next(1, 14);
                return p;

            }

            string m;

            string CheckNumber (int j)
                        {
                         
                if (j <= 10)
                {
                    string v = j.ToString();
                    m = v;
                }

                else if (j == 11)
                {
                    m = "J";
                }
                else if (j == 12)
                {
                    m = "Q";
                }
                else if (j == 13)
                {
                    m = "K";
                }
                else  m=j.ToString();

                return m;

               

            }
                 
         
           
                int t = NumGenerator();
                int n = NumGenerator();
                usr[i] = t.ToString();
                comp[i] = n.ToString();
                comp[i] = CheckNumber(n);
                usr[i]=CheckNumber(t);
         

                if (i == 0)
                {
                
                butPlay1.Text = usr[0].ToString();
                    butCom1.Text = comp[0].ToString();
                }


                if (i == 1)
                {
                    butPlay2.Text = usr[1].ToString();
                    butCom2.Text = comp[1].ToString();
                }
                if (i == 2)
                {
                    butCom3.Text = comp[2].ToString();
                    butPlay3.Text = usr[2].ToString();
                }
                if (i == 3)

                {
                    butCom4.Text = comp[3].ToString();
                    butPlay4.Text = comp[3].ToString();
                Array.Clear(usr, 0, usr.Length);
                Array.Clear(comp, 0, comp.Length);
              

            }


          

            if (t > n && t > 10)
            {

                sum = +0.5;
            }
            else if (t > n && t <= 10)
            { sum = sum + t; }
            if (n > t && n > 10)
            {
                sumComp = +0.5;
            }
            else if (n > t && n < 10)
            {
                sumComp = n + sumComp;
            }


            if (i == 3)
            {
                CalculateSum(sum, sumComp);


            }
            i++;
            if (i == 4)
            {

                startOver();
            }
       
          

        }

       public void  CalculateSum(double sum, double sumComp)
        {
            if (sum > sumComp && sum < 10)
            {

                MessageBox.Show("Blast!");

               
            }
            else if (sum > sumComp && sum > 10)
            {

                MessageBox.Show("You Won");

              
            }
            else if (sumComp > sum && sumComp < 10)
            {
                MessageBox.Show("Blast!");

            }
            else MessageBox.Show("Computer won");

         


        }

        public int  startOver()
        {
     
        double sum = 0.0;
        double sumComp = 0.0;
            return i = 0;
        }


        private void butGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Game!");
            butCom1.Text = " ";
            butCom2.Text = "  ";
            butCom3.Text = "  ";
            butCom4.Text = " ";
            butPlay1.Text = "  ";
            butPlay2.Text = "  ";
            butPlay3.Text = "  ";
            butPlay4.Text = "";

          

          

        }
    }
    }

