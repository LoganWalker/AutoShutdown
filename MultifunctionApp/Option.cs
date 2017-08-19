using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultifunctionApp
{
    public partial class Option : Form
    {
        MainForm mf;
        public Option(MainForm mfin)
        {
            InitializeComponent();
            mf = mfin;
            rdoSafeY.Checked = mf.Safe;
            rdoSafeN.Checked = !mf.Safe;
        }     
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Option_FormClosing(object sender, FormClosingEventArgs e)
        {
            mf.Safe = rdoSafeY.Checked;
        }

        private void rdoSafeY_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
