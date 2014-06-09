namespace GraphEditor
{
    partial class FloydWarshallForm
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
            this.panel = new GraphEditor.PanelDoubleBuffered();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonRichTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonRichTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.AutoScroll = true;
            this.kryptonPanel.Controls.Add(this.panel);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(440, 36);
            this.kryptonPanel.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(204, 291);
            this.kryptonPanel.TabIndex = 0;
            this.kryptonPanel.Resize += new System.EventHandler(this.kryptonPanel_Resize);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 100);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(644, 36);
            this.kryptonPanel1.TabIndex = 1;
            this.kryptonPanel1.Resize += new System.EventHandler(this.kryptonPanel1_Resize);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonButton3);
            this.kryptonPanel2.Controls.Add(this.kryptonButton1);
            this.kryptonPanel2.Controls.Add(this.kryptonButton2);
            this.kryptonPanel2.Location = new System.Drawing.Point(116, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(293, 33);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Enabled = false;
            this.kryptonButton3.Location = new System.Drawing.Point(197, 0);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(90, 33);
            this.kryptonButton3.TabIndex = 2;
            this.kryptonButton3.Values.Text = "Stop";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(5, 0);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 33);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "Start";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Enabled = false;
            this.kryptonButton2.Location = new System.Drawing.Point(101, 0);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(90, 33);
            this.kryptonButton2.TabIndex = 1;
            this.kryptonButton2.Values.Text = "Next";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonRichTextBox1);
            this.kryptonPanel3.Controls.Add(this.kryptonRichTextBox2);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 36);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(440, 291);
            this.kryptonPanel3.TabIndex = 1;
            // 
            // kryptonRichTextBox1
            // 
            this.kryptonRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonRichTextBox1.Location = new System.Drawing.Point(220, 0);
            this.kryptonRichTextBox1.Name = "kryptonRichTextBox1";
            this.kryptonRichTextBox1.ReadOnly = true;
            this.kryptonRichTextBox1.Size = new System.Drawing.Size(220, 291);
            this.kryptonRichTextBox1.TabIndex = 1;
            this.kryptonRichTextBox1.Text = "";
            this.kryptonRichTextBox1.WordWrap = false;
            // 
            // kryptonRichTextBox2
            // 
            this.kryptonRichTextBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonRichTextBox2.Location = new System.Drawing.Point(0, 0);
            this.kryptonRichTextBox2.Name = "kryptonRichTextBox2";
            this.kryptonRichTextBox2.ReadOnly = true;
            this.kryptonRichTextBox2.Size = new System.Drawing.Size(220, 291);
            this.kryptonRichTextBox2.TabIndex = 2;
            this.kryptonRichTextBox2.Text = "";
            this.kryptonRichTextBox2.WordWrap = false;
            // 
            // FloydWarshallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 327);
            this.Controls.Add(this.kryptonPanel);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FloydWarshallForm";
            this.Text = "FloydWarshall";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DijkstraForm_FormClosing);
            this.Load += new System.EventHandler(this.FloydWarshallForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private PanelDoubleBuffered panel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox2;
    }
}

