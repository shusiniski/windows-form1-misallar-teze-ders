using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var left1 = 0;
            var top1 = 0;
            int a = 0;
           for(int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {

                    var btn = new Button();
                    btn.Width = 50;
                    btn.Height = 50;
                    btn.Text = (i + 1).ToString();
                    btn.Left = left1;
                    left1 = left1 + 50;
                    btn.Top = 10 + top1;
                    btn.BackColor = Color.Green;
                    Controls.Add(btn);
                    a++;
                    if (a % 2 == 0)
                    {
                        btn.BackColor = Color.Blue;
                    }

                }
                a++;
                left1 = 0;
                top1 = top1 + 50;

            }
        }
    }
}
