namespace DivarProjectWithWinForm.Froms
{
    partial class Advertisement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Advertisement));
            groupBox1 = new GroupBox();
            numericUpDownPrice = new NumericUpDown();
            label5 = new Label();
            comboBoxIntactStatus = new ComboBox();
            buttonBrowse = new Button();
            textBoxFilePath = new TextBox();
            comboBoxCategoryId = new ComboBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            checkBoxLikeToExchange = new CheckBox();
            checkBoxIsFixedPrice = new CheckBox();
            textBoxDescription = new TextBox();
            textBoxTitle = new TextBox();
            textBoxAddress = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            openFileDialogImage = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDownPrice);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBoxIntactStatus);
            groupBox1.Controls.Add(buttonBrowse);
            groupBox1.Controls.Add(textBoxFilePath);
            groupBox1.Controls.Add(comboBoxCategoryId);
            groupBox1.Controls.Add(buttonSave);
            groupBox1.Controls.Add(buttonCancel);
            groupBox1.Controls.Add(checkBoxLikeToExchange);
            groupBox1.Controls.Add(checkBoxIsFixedPrice);
            groupBox1.Controls.Add(textBoxDescription);
            groupBox1.Controls.Add(textBoxTitle);
            groupBox1.Controls.Add(textBoxAddress);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(788, 667);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ثبت آگهی";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(402, 276);
            numericUpDownPrice.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(193, 23);
            numericUpDownPrice.TabIndex = 22;
            numericUpDownPrice.TextAlign = HorizontalAlignment.Center;
            numericUpDownPrice.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(728, 284);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 21;
            label5.Text = "قیمت";
            // 
            // comboBoxIntactStatus
            // 
            comboBoxIntactStatus.FormattingEnabled = true;
            comboBoxIntactStatus.Location = new Point(402, 217);
            comboBoxIntactStatus.Name = "comboBoxIntactStatus";
            comboBoxIntactStatus.Size = new Size(193, 23);
            comboBoxIntactStatus.TabIndex = 20;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(321, 151);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(75, 23);
            buttonBrowse.TabIndex = 19;
            buttonBrowse.Text = "انتخاب فایل";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Location = new Point(402, 152);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.ReadOnly = true;
            textBoxFilePath.Size = new Size(193, 23);
            textBoxFilePath.TabIndex = 18;
            // 
            // comboBoxCategoryId
            // 
            comboBoxCategoryId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoryId.FormattingEnabled = true;
            comboBoxCategoryId.Location = new Point(402, 44);
            comboBoxCategoryId.Name = "comboBoxCategoryId";
            comboBoxCategoryId.Size = new Size(193, 23);
            comboBoxCategoryId.TabIndex = 17;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.DarkRed;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(6, 598);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(165, 42);
            buttonSave.TabIndex = 16;
            buttonSave.Text = "ارسال آگهی";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.White;
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.Location = new Point(178, 598);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(165, 42);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "انصراف";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // checkBoxLikeToExchange
            // 
            checkBoxLikeToExchange.AutoSize = true;
            checkBoxLikeToExchange.Location = new Point(648, 333);
            checkBoxLikeToExchange.Name = "checkBoxLikeToExchange";
            checkBoxLikeToExchange.Size = new Size(115, 19);
            checkBoxLikeToExchange.TabIndex = 14;
            checkBoxLikeToExchange.Text = "مایلم معاوضه کنم";
            checkBoxLikeToExchange.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsFixedPrice
            // 
            checkBoxIsFixedPrice.AutoSize = true;
            checkBoxIsFixedPrice.Location = new Point(223, 278);
            checkBoxIsFixedPrice.Name = "checkBoxIsFixedPrice";
            checkBoxIsFixedPrice.Size = new Size(120, 19);
            checkBoxIsFixedPrice.TabIndex = 13;
            checkBoxIsFixedPrice.Text = "قیمت مقطوع است";
            checkBoxIsFixedPrice.UseVisualStyleBackColor = true;
            checkBoxIsFixedPrice.CheckedChanged += checkBoxIsFixedPrice_CheckedChanged;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(50, 472);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(545, 83);
            textBoxDescription.TabIndex = 12;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(402, 402);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(193, 23);
            textBoxTitle.TabIndex = 11;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(50, 92);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(545, 30);
            textBoxAddress.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(709, 480);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 7;
            label8.Text = "توضحیات";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(700, 410);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 6;
            label7.Text = "عنوان آگهی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(716, 219);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "وضعیت";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(729, 160);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "عکس";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(729, 100);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "آدرس";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(704, 47);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "دسته بندی";
            // 
            // openFileDialogImage
            // 
            openFileDialogImage.FileName = "openFileDialogImage";
            // 
            // Advertisement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 691);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(828, 730);
            MinimizeBox = false;
            MinimumSize = new Size(828, 730);
            Name = "Advertisement";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "افزودن آگهی";
            Load += Advertisement_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBoxAddress;
        private TextBox textBox1;
        private Button buttonSave;
        private Button buttonCancel;
        private CheckBox checkBoxLikeToExchange;
        private CheckBox checkBoxIsFixedPrice;
        private TextBox textBoxDescription;
        private TextBox textBoxTitle;
        private Button buttonBrowse;
        private TextBox textBoxFilePath;
        private ComboBox comboBoxCategoryId;
        private OpenFileDialog openFileDialogImage;
        private ComboBox comboBoxIntactStatus;
        private Label label5;
        private NumericUpDown numericUpDownPrice;
    }
}