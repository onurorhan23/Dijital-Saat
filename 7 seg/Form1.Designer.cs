namespace SevenSegTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sevenSegmentArray1 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.sevenSegmentArray2 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.sevenSegmentArray3 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sevenSegmentArray1
            // 
            this.sevenSegmentArray1.ArrayCount = 2;
            this.sevenSegmentArray1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sevenSegmentArray1.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentArray1.ColorDark = System.Drawing.Color.Black;
            this.sevenSegmentArray1.ColorLight = System.Drawing.Color.Lime;
            this.sevenSegmentArray1.DecimalShow = false;
            this.sevenSegmentArray1.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArray1.ElementWidth = 10;
            this.sevenSegmentArray1.ItalicFactor = 0F;
            resources.ApplyResources(this.sevenSegmentArray1, "sevenSegmentArray1");
            this.sevenSegmentArray1.Name = "sevenSegmentArray1";
            this.sevenSegmentArray1.TabStop = false;
            this.sevenSegmentArray1.Value = "88";
            this.sevenSegmentArray1.Load += new System.EventHandler(this.sevenSegmentArray1_Load_1);
            // 
            // sevenSegmentArray2
            // 
            this.sevenSegmentArray2.ArrayCount = 2;
            this.sevenSegmentArray2.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentArray2.ColorDark = System.Drawing.Color.Black;
            this.sevenSegmentArray2.ColorLight = System.Drawing.Color.Lime;
            this.sevenSegmentArray2.DecimalShow = false;
            this.sevenSegmentArray2.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArray2.ElementWidth = 10;
            this.sevenSegmentArray2.ItalicFactor = 0F;
            resources.ApplyResources(this.sevenSegmentArray2, "sevenSegmentArray2");
            this.sevenSegmentArray2.Name = "sevenSegmentArray2";
            this.sevenSegmentArray2.TabStop = false;
            this.sevenSegmentArray2.Value = "88";
            this.sevenSegmentArray2.Load += new System.EventHandler(this.sevenSegmentArray2_Load);
            // 
            // sevenSegmentArray3
            // 
            this.sevenSegmentArray3.ArrayCount = 2;
            this.sevenSegmentArray3.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentArray3.ColorDark = System.Drawing.Color.Black;
            this.sevenSegmentArray3.ColorLight = System.Drawing.Color.Lime;
            this.sevenSegmentArray3.DecimalShow = false;
            this.sevenSegmentArray3.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArray3.ElementWidth = 10;
            this.sevenSegmentArray3.ItalicFactor = 0F;
            resources.ApplyResources(this.sevenSegmentArray3, "sevenSegmentArray3");
            this.sevenSegmentArray3.Name = "sevenSegmentArray3";
            this.sevenSegmentArray3.TabStop = false;
            this.sevenSegmentArray3.Value = "00";
            this.sevenSegmentArray3.Load += new System.EventHandler(this.sevenSegmentArray3_Load_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sevenSegmentArray3);
            this.Controls.Add(this.sevenSegmentArray1);
            this.Controls.Add(this.sevenSegmentArray2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Timer timer1;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray1;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray2;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray3;
        private System.Windows.Forms.Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox comboBox1;
    }
}

