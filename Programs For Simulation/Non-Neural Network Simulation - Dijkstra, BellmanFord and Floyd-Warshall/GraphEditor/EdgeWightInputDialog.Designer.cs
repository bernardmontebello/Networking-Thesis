namespace GraphEditor
{
    partial class EdgeWightInputDialog
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
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonNumericUpDown1 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonButton2);
            this.kryptonPanel.Controls.Add(this.kryptonButton1);
            this.kryptonPanel.Controls.Add(this.kryptonNumericUpDown1);
            this.kryptonPanel.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(256, 72);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(130, 37);
            this.kryptonButton2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(68, 25);
            this.kryptonButton2.TabIndex = 3;
            this.kryptonButton2.Values.Text = "Cancel";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(58, 37);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(68, 25);
            this.kryptonButton1.TabIndex = 2;
            this.kryptonButton1.Values.Text = "OK";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonNumericUpDown1
            // 
            this.kryptonNumericUpDown1.Location = new System.Drawing.Point(142, 9);
            this.kryptonNumericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonNumericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.kryptonNumericUpDown1.Name = "kryptonNumericUpDown1";
            this.kryptonNumericUpDown1.Size = new System.Drawing.Size(105, 22);
            this.kryptonNumericUpDown1.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(10, 11);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(138, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Enter new edge weight:";
            // 
            // EdgeWightInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 72);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EdgeWightInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EdgeWightInputDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown kryptonNumericUpDown1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}

