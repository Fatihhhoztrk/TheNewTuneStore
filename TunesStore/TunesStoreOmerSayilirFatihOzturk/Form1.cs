using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TunesStoreOmerSayilirFatihOzturk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naam:\t\tÖmer Sayılır & Fatih Öztürk \n" +
                                         "Applicatie:\t© Tune Store \n" +
                                         "School:\t\tROC Ter AA, Helmond\n", "About");
        }

        private void miExitOssof_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("\n Are you sure you want to close the program?", "Tune Store", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void miAboutOssof_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developers:\t\tFatih Öztürk & Ömer Sayilir \n" +
                 "Application:\tTune Store \n" +
                 "School:\t\tROC Ter AA, Helmond\n", "About");
        }

        private void miLocationOssof_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.ExecutablePath);
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        
    }
}
