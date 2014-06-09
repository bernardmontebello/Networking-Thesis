namespace GraphEditor
{
    partial class BellmanFordForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.vertexListBox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.edgeListBox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonRichTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
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
            this.kryptonPanel.Location = new System.Drawing.Point(197, 29);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(174, 237);
            this.kryptonPanel.TabIndex = 0;
            this.kryptonPanel.Resize += new System.EventHandler(this.kryptonPanel_Resize);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(150, 81);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitContainer.Location = new System.Drawing.Point(371, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.vertexListBox);
            this.splitContainer.Panel1.Controls.Add(this.kryptonHeader1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.edgeListBox);
            this.splitContainer.Panel2.Controls.Add(this.kryptonHeader2);
            this.splitContainer.Size = new System.Drawing.Size(112, 266);
            this.splitContainer.SplitterDistance = 98;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 2;
            // 
            // vertexListBox
            // 
            this.vertexListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vertexListBox.Location = new System.Drawing.Point(0, 22);
            this.vertexListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vertexListBox.Name = "vertexListBox";
            this.vertexListBox.Size = new System.Drawing.Size(112, 76);
            this.vertexListBox.TabIndex = 0;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(112, 22);
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Vertexes";
            this.kryptonHeader1.Values.Image = null;
            // 
            // edgeListBox
            // 
            this.edgeListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edgeListBox.Location = new System.Drawing.Point(0, 22);
            this.edgeListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edgeListBox.Name = "edgeListBox";
            this.edgeListBox.Size = new System.Drawing.Size(112, 143);
            this.edgeListBox.TabIndex = 1;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(112, 22);
            this.kryptonHeader2.TabIndex = 0;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Edges";
            this.kryptonHeader2.Values.Image = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(371, 29);
            this.kryptonPanel1.TabIndex = 1;
            this.kryptonPanel1.Resize += new System.EventHandler(this.kryptonPanel1_Resize);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonButton3);
            this.kryptonPanel2.Controls.Add(this.kryptonButton1);
            this.kryptonPanel2.Controls.Add(this.kryptonButton2);
            this.kryptonPanel2.Location = new System.Drawing.Point(87, 0);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(220, 27);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Enabled = false;
            this.kryptonButton3.Location = new System.Drawing.Point(148, 0);
            this.kryptonButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(68, 27);
            this.kryptonButton3.TabIndex = 2;
            this.kryptonButton3.Values.Text = "Stop";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(4, 0);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(68, 27);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "Start";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Enabled = false;
            this.kryptonButton2.Location = new System.Drawing.Point(76, 0);
            this.kryptonButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(68, 27);
            this.kryptonButton2.TabIndex = 1;
            this.kryptonButton2.Values.Text = "Next";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonRichTextBox1);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 29);
            this.kryptonPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(197, 237);
            this.kryptonPanel3.TabIndex = 1;
            // 
            // kryptonRichTextBox1
            // 
            this.kryptonRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonRichTextBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonRichTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonRichTextBox1.Name = "kryptonRichTextBox1";
            this.kryptonRichTextBox1.ReadOnly = true;
            this.kryptonRichTextBox1.Size = new System.Drawing.Size(197, 237);
            this.kryptonRichTextBox1.TabIndex = 1;
            this.kryptonRichTextBox1.Text = "";
            this.kryptonRichTextBox1.WordWrap = false;
            // 
            // BellmanFordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 266);
            this.Controls.Add(this.kryptonPanel);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.splitContainer);
            this.Name = "BellmanFordForm";
            this.Text = "Bellman-Ford";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BellmanFordForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox vertexListBox;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox edgeListBox;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private PanelDoubleBuffered panel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox1;
    }
}

