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
    public partial class CheckAdvertisements : Form
    {
        public CheckAdvertisements()
        {
            InitializeComponent();
        }

        private async void CheckAdvertisements_Load(object sender, EventArgs e)
        {
            dataGridViewCheckAds.DataSource = await DatabaseBusiness.GetAdvertisement(Enums.Status.Pending);
            var ads = await DatabaseBusiness.GetAdvertisement();
            dataGridViewCheckAds.Columns[0].Width = 50;
            dataGridViewCheckAds.Columns[0].HeaderText = "شناسه";

            dataGridViewCheckAds.Columns[1].Width = 100;
            dataGridViewCheckAds.Columns[1].HeaderText = "تاریخ تغییر";

            dataGridViewCheckAds.Columns[2].Width = 100;
            dataGridViewCheckAds.Columns[2].HeaderText = "تاریخ ایجاد";

            dataGridViewCheckAds.Columns[3].Width = 100;
            dataGridViewCheckAds.Columns[3].HeaderText = "شناسه گروه";

            dataGridViewCheckAds.Columns[4].Width = 100;
            dataGridViewCheckAds.Columns[4].HeaderText = "شناسه کاربر";

            dataGridViewCheckAds.Columns[5].Width = 100;
            dataGridViewCheckAds.Columns[5].HeaderText = "وضعیت محصول";


            dataGridViewCheckAds.Columns[6].Width = 100;
            dataGridViewCheckAds.Columns[6].HeaderText = "وضعیت آگهی";

            dataGridViewCheckAds.Columns[7].Width = 100;
            dataGridViewCheckAds.Columns[7].HeaderText = "قیمت";

            dataGridViewCheckAds.Columns[8].Width = 150;
            dataGridViewCheckAds.Columns[8].HeaderText = "عنوان آگهی";

            dataGridViewCheckAds.Columns[9].Width = 200;
            dataGridViewCheckAds.Columns[9].HeaderText = "آدرس";


            dataGridViewCheckAds.Columns[10].Width = 200;
            dataGridViewCheckAds.Columns[10].HeaderText = "توضیحات";

            dataGridViewCheckAds.Columns[11].Width = 100;
            dataGridViewCheckAds.Columns[11].HeaderText = "قیمت مقطوع";

            dataGridViewCheckAds.Columns[12].Width = 100;
            dataGridViewCheckAds.Columns[12].HeaderText = "قابل معاوضه";





        }
    }
}
