using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaTankClashers
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        //delete
        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void LblPlay_MouseHover(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Red;
        }

        private void LblPlay_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Black;
        }

        private void LblControls_MouseHover(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Red;
        }

        private void LblControls_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Black;
        }

        //delete
        private void LblExit_MouseEnter(object sender, EventArgs e)
        {

        }

        private void LblExit_MouseHover(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Red;
        }

        private void LblExit_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Black;
        }

        private void LblPlay_Click(object sender, EventArgs e)
        {
            Form1 Game = new Form1();
            Game.ShowDialog();
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblControls_Click(object sender, EventArgs e)
        {
            frmControl Controls = new frmControl();
            Controls.ShowDialog();   
        }
    }
}
