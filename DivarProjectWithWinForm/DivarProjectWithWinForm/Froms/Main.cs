using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivarProjectWithWinForm.Froms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonAds_Click(object sender, EventArgs e)
        {
            var form = new Home();
            form.ShowDialog();
        }

        private void buttonCheckAds_Click(object sender, EventArgs e)
        {
            var form = new CheckAdvertisements();
            form.ShowDialog();
        }
    }
}