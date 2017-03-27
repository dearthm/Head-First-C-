using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmElephant : Form
    {

        Elephant lLoyd;
        Elephant lucinda;

        public frmElephant()
        {
            InitializeComponent();

            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lLoyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

        }

        private void btnLloyd_Click(object sender, EventArgs e)
        {
            lLoyd.WhoAmI();
        }

        private void btnLucinda_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = lLoyd;
            lLoyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Objects swapped!...", "Elephant");
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            lLoyd = lucinda;
            lLoyd.EarSize = 500;
            lLoyd.WhoAmI();
        }
    }

    public class Elephant
    {

        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + EarSize + " inches long.","My name is " + Name + " ...");
        }

    }
}
