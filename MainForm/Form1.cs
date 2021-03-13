using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeX_MouseEnter(object sender, EventArgs e)
        {
            closeX.ForeColor = Color.Aquamarine;
        }

        private void closeX_MouseLeave(object sender, EventArgs e)
        {
            closeX.ForeColor = Color.DarkOrchid;
        }

        Point lastPoint;
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void mainPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
