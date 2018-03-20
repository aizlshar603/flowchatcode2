using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace flowchatcode2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            Thread.Sleep(3000);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            g.DrawString("You", drawFont, drawBrush, 50, 40);
            continueButton.Visible = true;
          

        }

        private void continueButton_Click(object sender, EventArgs e)
        {

            Graphics g = this.CreateGraphics();
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            g.Clear(Color.Black);
            g.DrawString("You", drawFont, drawBrush, 50, 40);
            Thread.Sleep(1000);
            g.DrawString("should", drawFont, drawBrush, 100, 40);
            Thread.Sleep(1000);
            g.DrawString("not", drawFont, drawBrush, 180, 40);
            Thread.Sleep(1000);
            g.DrawString("have", drawFont, drawBrush, 220, 40);
            Thread.Sleep(1000);
            g.DrawString("done", drawFont, drawBrush, 280, 40);
            Thread.Sleep(1000);
            g.DrawString("that", drawFont, drawBrush, 340, 40);
            Thread.Sleep(2500);
        }
    }
}
