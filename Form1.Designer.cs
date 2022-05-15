namespace SAAT
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timelbl = new System.Windows.Forms.Label();
            this.seclbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timelbl.Font = new System.Drawing.Font("DS-Digital", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timelbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.timelbl.Location = new System.Drawing.Point(77, 41);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(321, 118);
            this.timelbl.TabIndex = 0;
            this.timelbl.Text = "00:00";
            // 
            // seclbl
            // 
            this.seclbl.AutoSize = true;
            this.seclbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seclbl.Font = new System.Drawing.Font("DS-Digital", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.seclbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.seclbl.Location = new System.Drawing.Point(377, 109);
            this.seclbl.Name = "seclbl";
            this.seclbl.Size = new System.Drawing.Size(60, 36);
            this.seclbl.TabIndex = 1;
            this.seclbl.Text = ".00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(499, 224);
            this.Controls.Add(this.seclbl);
            this.Controls.Add(this.timelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label timelbl;
        private Label seclbl;
        private System.Windows.Forms.Timer timer1;
    }
}