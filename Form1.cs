using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoreBoard
{
    public partial class Form1 : Form
    {
        private Person p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10;
        private int CurrentWeek;

        public Form1()
        {
            InitializeComponent();
            p0 = new Person(0);
            p1 = new Person(1);
            p2 = new Person(2);
            p3 = new Person(3);
            p4 = new Person(4);
            p5 = new Person(5);
            p6 = new Person(6);
            p7 = new Person(7);
            p8 = new Person(8);
            p9 = new Person(9);
            p10 = new Person(10);
            CurrentWeek = 1;
            this.Size = new Size(1600, 900);
        }

        private void rotate_button_Click(object sender, EventArgs e)
        {
            int x;
            if (Int32.TryParse(Week_Textbox.Text, out x))
            {
                if (x > CurrentWeek)
                {
                    for (int i = 0; i < x - CurrentWeek; i++)
                    {
                        RotateBoard();
                    }
                }
                else
                {
                    for (int i = 0; i < CurrentWeek - x; i++)
                    {
                        ReverseBoard();
                    }
                }
                CurrentWeek = x;
                weekNum_label.Text = "Week " + CurrentWeek;
            }
            else
            {
                weekNum_label.Text = "ERROR";
                weekNum_label.ForeColor = Color.IndianRed;
            }
        }

        private void RotateBoard()
        {
            p0.Pop();
            p1.Pop();
            p2.Pop();
            p3.Pop();
            p4.Pop();
            p5.Pop();
            p6.Pop();
            p7.Pop();
            p8.Pop();
            p9.Pop();
            p10.Pop();

            label1.Text = p0.Peep();
            label2.Text = p1.Peep();
            label3.Text = p2.Peep();
            label4.Text = p3.Peep();
            label5.Text = p4.Peep();
            label7.Text = p5.Peep();
            label8.Text = p6.Peep();
            label9.Text = p7.Peep();
            label10.Text = p8.Peep();
            label11.Text = p5.Peep();
            label12.Text = p6.Peep();
            label13.Text = p9.Peep();
            label14.Text = p10.Peep();
        }

        private void ReverseBoard()
        {
            p0.Poop();
            p1.Poop();
            p2.Poop();
            p3.Poop();
            p4.Poop();
            p5.Poop();
            p6.Poop();
            p7.Poop();
            p8.Poop();
            p9.Poop();
            p10.Poop();

            label1.Text = p0.Peep();
            label2.Text = p1.Peep();
            label3.Text = p2.Peep();
            label4.Text = p3.Peep();
            label5.Text = p4.Peep();
            label7.Text = p5.Peep();
            label8.Text = p6.Peep();
            label9.Text = p7.Peep();
            label10.Text = p8.Peep();
            label11.Text = p5.Peep();
            label12.Text = p6.Peep();
            label13.Text = p9.Peep();
            label14.Text = p10.Peep();
        }
    }
}
