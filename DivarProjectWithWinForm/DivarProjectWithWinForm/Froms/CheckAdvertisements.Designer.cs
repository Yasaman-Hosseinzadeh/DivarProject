namespace DivarProjectWithWinForm.Froms
{
    partial class CheckAdvertisements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckAdvertisements));
            groupBox1 = new GroupBox();
            dataGridViewCheckAds = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCheckAds).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataGridViewCheckAds);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "بررسی آگهی ها";
            // 
            // dataGridViewCheckAds
            // 
            dataGridViewCheckAds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCheckAds.Dock = DockStyle.Fill;
            dataGridViewCheckAds.Location = new Point(3, 19);
            dataGridViewCheckAds.Name = "dataGridViewCheckAds";
            dataGridViewCheckAds.ReadOnly = true;
            dataGridViewCheckAds.RowTemplate.Height = 25;
            dataGridViewCheckAds.Size = new Size(770, 404);
            dataGridViewCheckAds.TabIndex = 0;
            // 
            // CheckAdvertisements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CheckAdvertisements";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "بررسی آگهی ها";
            Load += CheckAdvertisements_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCheckAds).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private DataGridView dataGridViewCheckAds;
    }
}