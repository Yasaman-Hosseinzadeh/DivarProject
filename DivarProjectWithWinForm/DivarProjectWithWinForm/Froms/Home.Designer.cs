namespace DivarProjectWithWinForm.Froms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            buttonAds = new Button();
            buttonMyDivar = new Button();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridViewCategoryId = new DataGridView();
            groupBox1 = new GroupBox();
            buttonAllAds = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoryId).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAds
            // 
            buttonAds.BackColor = Color.DarkRed;
            buttonAds.Cursor = Cursors.Hand;
            buttonAds.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAds.ForeColor = Color.White;
            buttonAds.Location = new Point(6, 22);
            buttonAds.Name = "buttonAds";
            buttonAds.RightToLeft = RightToLeft.Yes;
            buttonAds.Size = new Size(157, 49);
            buttonAds.TabIndex = 1;
            buttonAds.Text = "ثبت آگهی";
            buttonAds.UseVisualStyleBackColor = false;
            buttonAds.Click += buttonAds_Click;
            // 
            // buttonMyDivar
            // 
            buttonMyDivar.BackColor = Color.White;
            buttonMyDivar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMyDivar.Location = new Point(169, 22);
            buttonMyDivar.Name = "buttonMyDivar";
            buttonMyDivar.Size = new Size(157, 49);
            buttonMyDivar.TabIndex = 2;
            buttonMyDivar.Text = "دیوار من";
            buttonMyDivar.UseVisualStyleBackColor = false;
            buttonMyDivar.Click += buttonMyDivar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Location = new Point(12, 101);
            groupBox3.Name = "groupBox3";
            groupBox3.RightToLeft = RightToLeft.Yes;
            groupBox3.Size = new Size(961, 541);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "    آگهی ها    ";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridViewCategoryId);
            groupBox2.Location = new Point(983, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(205, 630);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "    دسته بندی ها    ";
            // 
            // dataGridViewCategoryId
            // 
            dataGridViewCategoryId.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategoryId.Dock = DockStyle.Fill;
            dataGridViewCategoryId.Location = new Point(3, 19);
            dataGridViewCategoryId.Name = "dataGridViewCategoryId";
            dataGridViewCategoryId.ReadOnly = true;
            dataGridViewCategoryId.RightToLeft = RightToLeft.Yes;
            dataGridViewCategoryId.RowTemplate.Height = 25;
            dataGridViewCategoryId.Size = new Size(199, 608);
            dataGridViewCategoryId.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(buttonAllAds);
            groupBox1.Controls.Add(buttonAds);
            groupBox1.Controls.Add(buttonMyDivar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(961, 83);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // buttonAllAds
            // 
            buttonAllAds.BackColor = Color.White;
            buttonAllAds.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAllAds.Location = new Point(332, 22);
            buttonAllAds.Name = "buttonAllAds";
            buttonAllAds.Size = new Size(157, 49);
            buttonAllAds.TabIndex = 3;
            buttonAllAds.Text = "همه آگهی ها";
            buttonAllAds.UseVisualStyleBackColor = false;
            buttonAllAds.Click += buttonAllAds_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 654);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "صفحه اصلی";
            Load += Home_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoryId).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAds;
        private Button buttonMyDivar;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button buttonAllAds;
        private DataGridView dataGridViewCategoryId;
    }
}