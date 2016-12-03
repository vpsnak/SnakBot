namespace SnakBot
{
    partial class EditViewer
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
            this.HoursName = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.PointsName = new System.Windows.Forms.Label();
            this.PointsLabel = new System.Windows.Forms.Label();
            this.RankLabel = new System.Windows.Forms.Label();
            this.RankName = new System.Windows.Forms.Label();
            this.ViewernameLabel = new System.Windows.Forms.Label();
            this.Viewername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HoursName
            // 
            this.HoursName.AutoSize = true;
            this.HoursName.Location = new System.Drawing.Point(245, 42);
            this.HoursName.Name = "HoursName";
            this.HoursName.Size = new System.Drawing.Size(35, 13);
            this.HoursName.TabIndex = 17;
            this.HoursName.Text = "Hours";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(245, 9);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(35, 13);
            this.HoursLabel.TabIndex = 16;
            this.HoursLabel.Text = "Hours";
            // 
            // PointsName
            // 
            this.PointsName.AutoSize = true;
            this.PointsName.Location = new System.Drawing.Point(180, 42);
            this.PointsName.Name = "PointsName";
            this.PointsName.Size = new System.Drawing.Size(36, 13);
            this.PointsName.TabIndex = 15;
            this.PointsName.Text = "Points";
            // 
            // PointsLabel
            // 
            this.PointsLabel.AutoSize = true;
            this.PointsLabel.Location = new System.Drawing.Point(180, 9);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(36, 13);
            this.PointsLabel.TabIndex = 14;
            this.PointsLabel.Text = "Points";
            // 
            // RankLabel
            // 
            this.RankLabel.AutoSize = true;
            this.RankLabel.Location = new System.Drawing.Point(95, 9);
            this.RankLabel.Name = "RankLabel";
            this.RankLabel.Size = new System.Drawing.Size(59, 13);
            this.RankLabel.TabIndex = 13;
            this.RankLabel.Text = "RankLabel";
            // 
            // RankName
            // 
            this.RankName.AutoSize = true;
            this.RankName.Location = new System.Drawing.Point(95, 42);
            this.RankName.Name = "RankName";
            this.RankName.Size = new System.Drawing.Size(33, 13);
            this.RankName.TabIndex = 12;
            this.RankName.Text = "Rank";
            // 
            // ViewernameLabel
            // 
            this.ViewernameLabel.AutoSize = true;
            this.ViewernameLabel.Location = new System.Drawing.Point(12, 9);
            this.ViewernameLabel.Name = "ViewernameLabel";
            this.ViewernameLabel.Size = new System.Drawing.Size(55, 13);
            this.ViewernameLabel.TabIndex = 11;
            this.ViewernameLabel.Text = "Username";
            // 
            // Viewername
            // 
            this.Viewername.AutoSize = true;
            this.Viewername.Location = new System.Drawing.Point(12, 42);
            this.Viewername.Name = "Viewername";
            this.Viewername.Size = new System.Drawing.Size(65, 13);
            this.Viewername.TabIndex = 10;
            this.Viewername.Text = "Viewername";
            // 
            // EditViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 261);
            this.Controls.Add(this.HoursName);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.PointsName);
            this.Controls.Add(this.PointsLabel);
            this.Controls.Add(this.RankLabel);
            this.Controls.Add(this.RankName);
            this.Controls.Add(this.ViewernameLabel);
            this.Controls.Add(this.Viewername);
            this.Name = "EditViewer";
            this.Text = "EditViewer";
            this.Load += new System.EventHandler(this.EditViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HoursName;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label PointsName;
        private System.Windows.Forms.Label PointsLabel;
        private System.Windows.Forms.Label RankLabel;
        private System.Windows.Forms.Label RankName;
        private System.Windows.Forms.Label ViewernameLabel;
        private System.Windows.Forms.Label Viewername;
    }
}