namespace DivarProjectWithWinForm.Froms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            groupBox1 = new GroupBox();
            buttonCheckAds = new Button();
            groupBox2 = new GroupBox();
            buttonAds = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonCheckAds);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(326, 118);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "فعالیت های ادمین";
            // 
            // buttonCheckAds
            // 
            buttonCheckAds.BackColor = Color.White;
            buttonCheckAds.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCheckAds.Location = new Point(22, 46);
            buttonCheckAds.Name = "buttonCheckAds";
            buttonCheckAds.Size = new Size(283, 49);
            buttonCheckAds.TabIndex = 4;
            buttonCheckAds.Text = "بررسی آگهی ها";
            buttonCheckAds.UseVisualStyleBackColor = false;
            buttonCheckAds.Click += buttonCheckAds_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonAds);
            groupBox2.Location = new Point(344, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(326, 117);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "فعالیت های کاربران";
            // 
            // buttonAds
            // 
            buttonAds.BackColor = Color.White;
            buttonAds.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAds.Location = new Point(26, 45);
            buttonAds.Name = "buttonAds";
            buttonAds.Size = new Size(283, 49);
            buttonAds.TabIndex = 3;
            buttonAds.Text = "آگهی ها";
            buttonAds.UseVisualStyleBackColor = false;
            buttonAds.Click += buttonAds_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 142);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(696, 181);
            MinimizeBox = false;
            MinimumSize = new Size(696, 181);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonAds;
        private Button buttonCheckAds;
    }
}