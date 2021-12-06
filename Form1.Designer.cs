
namespace Activity14
{
    partial class cityViewer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.cityList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.GroupBox();
            this.nightRadio = new System.Windows.Forms.RadioButton();
            this.dayRadio = new System.Windows.Forms.RadioButton();
            this.details = new System.Windows.Forms.GroupBox();
            this.highwayCheck = new System.Windows.Forms.CheckBox();
            this.attractionCheck = new System.Windows.Forms.CheckBox();
            this.detailsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.timeBox.SuspendLayout();
            this.details.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(188, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(17, 318);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(106, 43);
            this.viewButton.TabIndex = 1;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // cityList
            // 
            this.cityList.FormattingEnabled = true;
            this.cityList.Items.AddRange(new object[] {
            "San Antonio",
            "Austin",
            "Houston",
            "Dallas"});
            this.cityList.Location = new System.Drawing.Point(13, 30);
            this.cityList.Name = "cityList";
            this.cityList.Size = new System.Drawing.Size(120, 69);
            this.cityList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a City";
            // 
            // timeBox
            // 
            this.timeBox.Controls.Add(this.nightRadio);
            this.timeBox.Controls.Add(this.dayRadio);
            this.timeBox.Location = new System.Drawing.Point(16, 108);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(117, 71);
            this.timeBox.TabIndex = 5;
            this.timeBox.TabStop = false;
            this.timeBox.Text = "Time of Day";
            // 
            // nightRadio
            // 
            this.nightRadio.AutoSize = true;
            this.nightRadio.Location = new System.Drawing.Point(57, 29);
            this.nightRadio.Name = "nightRadio";
            this.nightRadio.Size = new System.Drawing.Size(50, 17);
            this.nightRadio.TabIndex = 1;
            this.nightRadio.Text = "Night";
            this.nightRadio.UseVisualStyleBackColor = true;
            // 
            // dayRadio
            // 
            this.dayRadio.AutoSize = true;
            this.dayRadio.Checked = true;
            this.dayRadio.Location = new System.Drawing.Point(7, 29);
            this.dayRadio.Name = "dayRadio";
            this.dayRadio.Size = new System.Drawing.Size(44, 17);
            this.dayRadio.TabIndex = 0;
            this.dayRadio.TabStop = true;
            this.dayRadio.Text = "Day";
            this.dayRadio.UseVisualStyleBackColor = true;
            // 
            // details
            // 
            this.details.Controls.Add(this.highwayCheck);
            this.details.Controls.Add(this.attractionCheck);
            this.details.Location = new System.Drawing.Point(16, 193);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(123, 77);
            this.details.TabIndex = 6;
            this.details.TabStop = false;
            this.details.Text = "Select Details";
            // 
            // highwayCheck
            // 
            this.highwayCheck.AutoSize = true;
            this.highwayCheck.Location = new System.Drawing.Point(7, 43);
            this.highwayCheck.Name = "highwayCheck";
            this.highwayCheck.Size = new System.Drawing.Size(104, 17);
            this.highwayCheck.TabIndex = 1;
            this.highwayCheck.Text = "Closest Highway";
            this.highwayCheck.UseVisualStyleBackColor = true;
            // 
            // attractionCheck
            // 
            this.attractionCheck.AutoSize = true;
            this.attractionCheck.Location = new System.Drawing.Point(7, 20);
            this.attractionCheck.Name = "attractionCheck";
            this.attractionCheck.Size = new System.Drawing.Size(102, 17);
            this.attractionCheck.TabIndex = 0;
            this.attractionCheck.Text = "Attraction Name";
            this.attractionCheck.UseVisualStyleBackColor = true;
            // 
            // detailsLabel
            // 
            this.detailsLabel.Location = new System.Drawing.Point(188, 286);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(286, 43);
            this.detailsLabel.TabIndex = 7;
            // 
            // cityViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 403);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.details);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityList);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "cityViewer";
            this.Text = "City Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.timeBox.ResumeLayout(false);
            this.timeBox.PerformLayout();
            this.details.ResumeLayout(false);
            this.details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.ListBox cityList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox timeBox;
        private System.Windows.Forms.RadioButton nightRadio;
        private System.Windows.Forms.RadioButton dayRadio;
        private System.Windows.Forms.GroupBox details;
        private System.Windows.Forms.CheckBox highwayCheck;
        private System.Windows.Forms.CheckBox attractionCheck;
        private System.Windows.Forms.Label detailsLabel;
    }
}

