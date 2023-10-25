using DivarProjectWithWinForm.Business;
using DivarProjectWithWinForm.Extentions;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private async void Home_Load(object sender, EventArgs e)
        {
            var categories = await DatabaseBusiness.GetCategory();
            dataGridViewCategoryId.DataSource = categories.ConvertToCategoryModel();
            dataGridViewCategoryId.Columns[0].Width = 30;
            dataGridViewCategoryId.Columns[0].HeaderText = "شناسه";
            dataGridViewCategoryId.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCategoryId.Columns[1].HeaderText = "نام";
            dataGridViewCategoryId.SelectionChanged += dataGridView_SelectionChanged;

            var advertisments = await DatabaseBusiness.GetAdvertisement(Enums.Status.Published);
        }

        private void buttonAds_Click(object sender, EventArgs e)
        {
            var form = new Advertisement();
            form.ShowDialog();
        }



        private void buttonMyDivar_Click(object sender, EventArgs e)
        {

        }

        private void buttonAllAds_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewCategoryId.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
            }
        }
    }
}
