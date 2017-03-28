using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talker
{
    public partial class frmTalkToMe : Form
    {
        public frmTalkToMe()
        {
            InitializeComponent();
        }

        private void btnSpeakToMe_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDown1.Value > 0)
            {
                int len = Talker.BlahBlahBlah(txtBlah.Text, (int)numericUpDown1.Value);
                MessageBox.Show("The message length is " + len, "Talker");
            }
            else
            {
                MessageBox.Show("Choose a value greater than 0!", "Talker");
            }
        }
    }
}
