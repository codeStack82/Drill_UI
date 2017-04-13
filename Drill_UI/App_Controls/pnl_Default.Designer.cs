namespace Drill_UI
{
    partial class pnl_Default
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
            this.pnl_Lower = new System.Windows.Forms.Panel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Well = new System.Windows.Forms.Panel();
            this.lbl_WellName = new System.Windows.Forms.Label();
            this.pnl_District = new System.Windows.Forms.Panel();
            this.lbl_District = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_Well.SuspendLayout();
            this.pnl_District.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Lower
            // 
            this.pnl_Lower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Lower.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_Lower.Location = new System.Drawing.Point(6, 239);
            this.pnl_Lower.Name = "pnl_Lower";
            this.pnl_Lower.Padding = new System.Windows.Forms.Padding(3);
            this.pnl_Lower.Size = new System.Drawing.Size(588, 55);
            this.pnl_Lower.TabIndex = 0;
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_Top.Location = new System.Drawing.Point(6, 42);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(588, 191);
            this.pnl_Top.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pnl_Well);
            this.panel1.Controls.Add(this.pnl_District);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(588, 30);
            this.panel1.TabIndex = 2;
            // 
            // pnl_Well
            // 
            this.pnl_Well.Controls.Add(this.lbl_WellName);
            this.pnl_Well.Location = new System.Drawing.Point(300, 3);
            this.pnl_Well.Name = "pnl_Well";
            this.pnl_Well.Size = new System.Drawing.Size(285, 24);
            this.pnl_Well.TabIndex = 0;
            // 
            // lbl_WellName
            // 
            this.lbl_WellName.AutoSize = true;
            this.lbl_WellName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WellName.Location = new System.Drawing.Point(3, 5);
            this.lbl_WellName.Name = "lbl_WellName";
            this.lbl_WellName.Size = new System.Drawing.Size(75, 16);
            this.lbl_WellName.TabIndex = 1;
            this.lbl_WellName.Text = "Well Name";
            this.lbl_WellName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_District
            // 
            this.pnl_District.Controls.Add(this.lbl_District);
            this.pnl_District.Location = new System.Drawing.Point(3, 3);
            this.pnl_District.Name = "pnl_District";
            this.pnl_District.Size = new System.Drawing.Size(285, 24);
            this.pnl_District.TabIndex = 0;
            // 
            // lbl_District
            // 
            this.lbl_District.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_District.AutoSize = true;
            this.lbl_District.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_District.Location = new System.Drawing.Point(194, 5);
            this.lbl_District.Name = "lbl_District";
            this.lbl_District.Size = new System.Drawing.Size(88, 16);
            this.lbl_District.TabIndex = 0;
            this.lbl_District.Text = "District Name";
            this.lbl_District.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.pnl_Lower);
            this.Name = "pnl_Default";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(600, 300);
            this.Load += new System.EventHandler(this.pnl_Default_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_Well.ResumeLayout(false);
            this.pnl_Well.PerformLayout();
            this.pnl_District.ResumeLayout(false);
            this.pnl_District.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Lower;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Well;
        private System.Windows.Forms.Panel pnl_District;
        private System.Windows.Forms.Label lbl_WellName;
        private System.Windows.Forms.Label lbl_District;
    }
}
