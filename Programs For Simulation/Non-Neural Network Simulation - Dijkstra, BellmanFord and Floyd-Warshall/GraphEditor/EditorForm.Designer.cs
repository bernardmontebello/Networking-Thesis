namespace GraphEditor
{
    partial class EditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addVertexToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeVertexToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.moveVertexToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addEdgeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.vertexListBox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.edgeListBox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.removeEdgeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel = new GraphEditor.PanelDoubleBuffered();
            this.editEdgeWeightToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.AutoScroll = true;
            this.kryptonPanel.Controls.Add(this.panel);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(127, 0);
            this.kryptonPanel.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(112, 327);
            this.kryptonPanel.TabIndex = 0;
            this.kryptonPanel.Resize += new System.EventHandler(this.kryptonPanel_Resize);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVertexToolStripButton,
            this.removeVertexToolStripButton,
            this.moveVertexToolStripButton,
            this.toolStripSeparator1,
            this.addEdgeToolStripButton,
            this.removeEdgeToolStripButton,
            this.editEdgeWeightToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(127, 327);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addVertexToolStripButton
            // 
            this.addVertexToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addVertexToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addVertexToolStripButton.Image")));
            this.addVertexToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addVertexToolStripButton.Name = "addVertexToolStripButton";
            this.addVertexToolStripButton.Size = new System.Drawing.Size(124, 24);
            this.addVertexToolStripButton.Text = "Add vertex";
            this.addVertexToolStripButton.Click += new System.EventHandler(this.addVertexToolStripButton_Click);
            // 
            // removeVertexToolStripButton
            // 
            this.removeVertexToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.removeVertexToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("removeVertexToolStripButton.Image")));
            this.removeVertexToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeVertexToolStripButton.Name = "removeVertexToolStripButton";
            this.removeVertexToolStripButton.Size = new System.Drawing.Size(124, 24);
            this.removeVertexToolStripButton.Text = "Remove vertex";
            this.removeVertexToolStripButton.Click += new System.EventHandler(this.removeVertexToolStripButton_Click);
            // 
            // moveVertexToolStripButton
            // 
            this.moveVertexToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.moveVertexToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("moveVertexToolStripButton.Image")));
            this.moveVertexToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveVertexToolStripButton.Name = "moveVertexToolStripButton";
            this.moveVertexToolStripButton.Size = new System.Drawing.Size(124, 24);
            this.moveVertexToolStripButton.Text = "Move vertex";
            this.moveVertexToolStripButton.Click += new System.EventHandler(this.moveVertexToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // addEdgeToolStripButton
            // 
            this.addEdgeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addEdgeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addEdgeToolStripButton.Image")));
            this.addEdgeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addEdgeToolStripButton.Name = "addEdgeToolStripButton";
            this.addEdgeToolStripButton.Size = new System.Drawing.Size(124, 24);
            this.addEdgeToolStripButton.Text = "Add edge";
            this.addEdgeToolStripButton.Click += new System.EventHandler(this.addEdgeToolStripButton_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitContainer.Location = new System.Drawing.Point(239, 0);
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
            this.splitContainer.Size = new System.Drawing.Size(150, 327);
            this.splitContainer.SplitterDistance = 121;
            this.splitContainer.TabIndex = 1;
            // 
            // vertexListBox
            // 
            this.vertexListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vertexListBox.Location = new System.Drawing.Point(0, 26);
            this.vertexListBox.Name = "vertexListBox";
            this.vertexListBox.Size = new System.Drawing.Size(150, 95);
            this.vertexListBox.TabIndex = 0;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(150, 26);
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Vertexes";
            this.kryptonHeader1.Values.Image = null;
            // 
            // edgeListBox
            // 
            this.edgeListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edgeListBox.Location = new System.Drawing.Point(0, 26);
            this.edgeListBox.Name = "edgeListBox";
            this.edgeListBox.Size = new System.Drawing.Size(150, 176);
            this.edgeListBox.TabIndex = 1;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(150, 26);
            this.kryptonHeader2.TabIndex = 0;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Edges";
            this.kryptonHeader2.Values.Image = null;
            // 
            // removeEdgeToolStripButton
            // 
            this.removeEdgeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.removeEdgeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("removeEdgeToolStripButton.Image")));
            this.removeEdgeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeEdgeToolStripButton.Name = "removeEdgeToolStripButton";
            this.removeEdgeToolStripButton.Size = new System.Drawing.Size(124, 24);
            this.removeEdgeToolStripButton.Text = "Remove edge";
            this.removeEdgeToolStripButton.Click += new System.EventHandler(this.removeEdgeToolStripButton_Click);
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
            this.panel.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panel.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // editEdgeWeightToolStripButton
            // 
            this.editEdgeWeightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editEdgeWeightToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editEdgeWeightToolStripButton.Image")));
            this.editEdgeWeightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editEdgeWeightToolStripButton.Name = "editEdgeWeightToolStripButton";
            this.editEdgeWeightToolStripButton.Size = new System.Drawing.Size(124, 24);
            this.editEdgeWeightToolStripButton.Text = "Edit edge weight";
            this.editEdgeWeightToolStripButton.Click += new System.EventHandler(this.editEdgeWeightToolStripButton_Click);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 327);
            this.Controls.Add(this.kryptonPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditorForm";
            this.Text = "EditorForm";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox vertexListBox;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox edgeListBox;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private System.Windows.Forms.ToolStripButton addVertexToolStripButton;
        private System.Windows.Forms.ToolStripButton addEdgeToolStripButton;
        private PanelDoubleBuffered panel;
        private System.Windows.Forms.ToolStripButton moveVertexToolStripButton;
        private System.Windows.Forms.ToolStripButton removeVertexToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton removeEdgeToolStripButton;
        private System.Windows.Forms.ToolStripButton editEdgeWeightToolStripButton;
    }
}

