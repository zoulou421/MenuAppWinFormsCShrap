using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace MenuApp
{
    public partial class frmLayout : Form
    {
        public frmLayout()
        {
            InitializeComponent();
        }
        //private function
        private void CloseChild()
        {
            Form[] charr = this.MdiChildren;
            //for each child form set the window state to Maximized
            foreach(Form chForm in charr)
            {
                // chForm.WindowState = FormWindowState.Maximized;
                chForm.Close();
            }
        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChild();
            frmGreen f = new frmGreen();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void bleuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChild();
            frmBlue f = new frmBlue();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Occupied the whole screen
        private void frmLayout_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
        }

        private void noireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChild();
            frmBlack f = new frmBlack();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void blancheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChild();
            frmWhite f = new frmWhite();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }
    }
}
