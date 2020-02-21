using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0; //to count the number of turns


        void restartGame()
        {
            Application.Restart();
        }

        // || this OR logic is not on my keyboard

            
       /* public Boolean checkwin(string symbol)
        {
            if (((button1.Text == symbol) && (button2.Text == symbol) && (button3.Text == symbol)) ||
                ((button4.Text == symbol) && (button5.Text == symbol) && (button6.Text == symbol)) ||
                ((button7.Text == symbol) && (button8.Text == symbol) && (button9.Text == symbol)) ||
                ((button1.Text == symbol) && (button5.Text == symbol) && (button9.Text == symbol)) ||
                ((button3.Text == symbol) && (button5.Text == symbol) && (button7.Text == symbol)) ||
                ((button2.Text == symbol) && (button5.Text == symbol) && (button8.Text == symbol)) ||
                ((button1.Text == symbol) && (button4.Text == symbol) && (button7.Text == symbol)) ||
                ((button3.Text == symbol) && (button8.Text == symbol) && (button9.Text == symbol)))
                {
                return true;
            }
            return false;

        }*/
             


        void checkwinner(string symbol)
        {
            if (button1.Text == symbol && button2.Text == symbol && button3.Text == symbol)
            {
                MessageBox.Show(symbol + " Won the Game");
                restartGame();
            }
            else
              if (button4.Text == symbol && button5.Text == symbol && button6.Text == symbol)
            {
                MessageBox.Show(symbol + " Won the Game");
                restartGame();
            }
            else
              if (button7.Text == symbol && button8.Text == symbol && button9.Text == symbol)
            {
                MessageBox.Show(symbol + " Won the Game");
                restartGame();
            }

            else
              if (button1.Text == symbol && button5.Text == symbol && button9.Text == symbol)
            {
                MessageBox.Show(symbol + " Won the Game");
                restartGame();

            }

            else
              if (button3.Text == symbol && button5.Text == symbol && button7.Text == symbol)
            {
                MessageBox.Show(symbol + " Won the Game");
                restartGame();

            }

            else
              if (button2.Text == symbol && button5.Text == symbol && button8.Text == symbol)
            {
                MessageBox.Show(symbol + " Won the Game");
                restartGame();

            }

            else
              if (button1.Text == symbol && button4.Text == symbol && button7.Text == symbol)
            {
                MessageBox.Show(symbol + " Won the Game");
                restartGame();

            }

            else
              if (button3.Text == symbol && button8.Text == symbol && button9.Text == symbol)
            {
                MessageBox.Show(symbol + " Won the Game");
                restartGame();

            }

        }

        /**public Boolean checkDraw(object senderobj)
        {
            //string buttontxt = ((Button)senderobj).Text;
            if(checkwin(" ") {
                MessageBox.Show("game Draw!");
                return true;
            }
            return false;
        }**/

        void fnsymbol(object senderobj)
        {
            string buttontxt = ((Button)senderobj).Text;
            if(buttontxt == "")
            {
                if (count % 2 == 0)
                {
                    ((Button)senderobj).Text = "O";
                    label1.BackColor= Color.White;
                    label2.BackColor = Color.Green;
                }
                else
                {
                    ((Button)senderobj).Text = "X";
                    label2.BackColor = Color.White;
                    label1.BackColor = Color.Green;

                }
                count++; //it will increament count, which turns to next player
                checkwinner("O");
                checkwinner("X");
            }
            else
            {
                MessageBox.Show("Invalid click");
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }
    }
}
