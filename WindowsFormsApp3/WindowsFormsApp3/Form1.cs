using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var pos = 10;
            for (int i = 0; i < 10; i++)
            {
                pos = pos + 102;
                var btn = new Button();
                btn.Width = 100;
                btn.Height = 50;
                btn.Text = i.ToString();
                btn.Top = 400;
                btn.Left = pos;
                Controls.Add(btn);


            }

            MessageBox.Show(Controls[2].ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
