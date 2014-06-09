namespace GraphEditor
{
    partial class NewGraphDialog
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonRadioButton3 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonRadioButton4 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonRadioButton2 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonRadioButton1 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(389, 173);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Controls.Add(this.kryptonButton2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 120);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(389, 53);
            this.kryptonPanel1.TabIndex = 4;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(101, 9);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 35);
            this.kryptonButton1.TabIndex = 2;
            this.kryptonButton1.Values.Text = "OK";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kryptonButton2.Location = new System.Drawing.Point(198, 8);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(90, 35);
            this.kryptonButton2.TabIndex = 3;
            this.kryptonButton2.Values.Text = "Cancel";
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.AutoSize = true;
            this.kryptonGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(0, 60);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonRadioButton3);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonRadioButton4);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(389, 60);
            this.kryptonGroupBox2.TabIndex = 1;
            this.kryptonGroupBox2.Text = "Edge weights";
            this.kryptonGroupBox2.Values.Heading = "Edge weights";
            // 
            // kryptonRadioButton3
            // 
            this.kryptonRadioButton3.Location = new System.Drawing.Point(90, 3);
            this.kryptonRadioButton3.Name = "kryptonRadioButton3";
            this.kryptonRadioButton3.Size = new System.Drawing.Size(81, 24);
            this.kryptonRadioButton3.TabIndex = 3;
            this.kryptonRadioButton3.Values.Text = "Random";
            // 
            // kryptonRadioButton4
            // 
            this.kryptonRadioButton4.Checked = true;
            this.kryptonRadioButton4.Location = new System.Drawing.Point(10, 3);
            this.kryptonRadioButton4.Name = "kryptonRadioButton4";
            this.kryptonRadioButton4.Size = new System.Drawing.Size(74, 24);
            this.kryptonRadioButton4.TabIndex = 2;
            this.kryptonRadioButton4.Values.Text = "Manual";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.AutoSize = true;
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonRadioButton2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonRadioButton1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(389, 60);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Text = "Page alignment";
            this.kryptonGroupBox1.Values.Heading = "Page alignment";
            // 
            // kryptonRadioButton2
            // 
            this.kryptonRadioButton2.Location = new System.Drawing.Point(90, 3);
            this.kryptonRadioButton2.Name = "kryptonRadioButton2";
            this.kryptonRadioButton2.Size = new System.Drawing.Size(94, 24);
            this.kryptonRadioButton2.TabIndex = 1;
            this.kryptonRadioButton2.Values.Text = "Horizontal";
            // 
            // kryptonRadioButton1
            // 
            this.kryptonRadioButton1.Checked = true;
            this.kryptonRadioButton1.Location = new System.Drawing.Point(10, 3);
            this.kryptonRadioButton1.Name = "kryptonRadioButton1";
            this.kryptonRadioButton1.Size = new System.Drawing.Size(74, 24);
            this.kryptonRadioButton1.TabIndex = 0;
            this.kryptonRadioButton1.Values.Text = "Vertical";
            // 
            // NewGraphDialog
            // 
            this.AcceptButton = this.kryptonButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.kryptonButton2;
            this.ClientSize = new System.Drawing.Size(389, 173);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewGraphDialog";
            this.Text = "NewGraphDialog";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonRadioButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonRadioButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonRadioButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonRadioButton4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
    }
}

