using DivarProjectWithWinForm.Business;
using DivarProjectWithWinForm.Enums;
using DivarProjectWithWinForm.Extentions;
using DivarProjectWithWinForm.Models.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DivarProjectWithWinForm.Froms
{
    /// <summary>
    /// https://www.c-sharpcorner.com/UploadFile/mahesh/openfiledialog-in-C-Sharp/
    /// </summary>
    public partial class Advertisement : Form
    {
        public Advertisement()
        {
            InitializeComponent();
        }

        private async void Advertisement_Load(object sender, EventArgs e)
        {
            comboBoxCategoryId.DataSource = await DatabaseBusiness.GetCategory();
            comboBoxCategoryId.ValueMember = "Id";
            comboBoxCategoryId.DisplayMember = "Title";

            comboBoxIntactStatus.DataSource = Extentions.Extentions.GetIntactStatusComboBoxData();
            comboBoxIntactStatus.ValueMember = "Value";
            comboBoxIntactStatus.DisplayMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialogImage.CheckFileExists = true;
            openFileDialogImage.CheckPathExists = true;
            openFileDialogImage.DefaultExt = "jpg";
            openFileDialogImage.Filter = "Images files (*.jpg)|*.jpg";

            var result = openFileDialogImage.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialogImage.FileName;
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFilePath.Text))
            {
                MessageBox.Show("فایل الزامی می باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var advertiment = new Models.Entites.Advertisement()
            {
                CreatedDate = DateTime.Now,
                Address = textBoxAddress.Text,
                CreatorUserId = 2,
                CategoryId = (int)comboBoxCategoryId.SelectedValue,
                Description = textBoxDescription.Text,
                IntactStatus = (IntactStatus)comboBoxIntactStatus.SelectedValue,
                ModifiedDate = DateTime.Now,
                Price = (int)numericUpDownPrice.Value,
                Status = Enums.Status.Pending,
                Title = textBoxTitle.Text,
                IsFixedPrice = (bool)checkBoxIsFixedPrice.Checked,
                LikeToExchange = (bool)checkBoxLikeToExchange.Checked
            };
            advertiment = await DatabaseBusiness.CreateAdvertisement(advertiment);
            Extentions.Extentions.SaveImage(textBoxFilePath.Text, advertiment.Id);
            MessageBox.Show("عملیات با موفقیت انجام شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void checkBoxIsFixedPrice_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
