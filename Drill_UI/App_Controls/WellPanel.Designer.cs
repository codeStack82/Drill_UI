namespace Drill_UI.App_Controls
{
    partial class WellPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopPnl = new System.Windows.Forms.Panel();
            this.DistrictLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.TopPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPnl
            // 
            this.TopPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(175)))));
            this.TopPnl.Controls.Add(this.label1);
            this.TopPnl.Controls.Add(this.DistrictLabel);
            this.TopPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPnl.Location = new System.Drawing.Point(5, 5);
            this.TopPnl.Name = "TopPnl";
            this.TopPnl.Size = new System.Drawing.Size(390, 35);
            this.TopPnl.TabIndex = 0;
            // 
            // DistrictLabel
            // 
            this.DistrictLabel.AutoSize = true;
            this.DistrictLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistrictLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DistrictLabel.Location = new System.Drawing.Point(3, 11);
            this.DistrictLabel.Name = "DistrictLabel";
            this.DistrictLabel.Size = new System.Drawing.Size(56, 16);
            this.DistrictLabel.TabIndex = 0;
            this.DistrictLabel.Text = "District";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(303, 11);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Well Name";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(5, 40);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(390, 355);
            this.webBrowser1.TabIndex = 1;
            // 
            // WellPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.TopPnl);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "WellPanel";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(400, 400);
            this.TopPnl.ResumeLayout(false);
            this.TopPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DistrictLabel;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}
