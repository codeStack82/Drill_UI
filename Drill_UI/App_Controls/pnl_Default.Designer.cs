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
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(588, 30);
            this.panel1.TabIndex = 2;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Lower;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Panel panel1;
    }
}
