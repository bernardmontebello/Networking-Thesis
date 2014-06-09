using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace GraphEditor
{
    public partial class NewGraphDialog : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public Boolean isVertical { get; private set; }
        public Boolean isAutomaticWeights { get; private set; }
        public NewGraphDialog()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            isVertical = kryptonRadioButton1.Checked;
            isAutomaticWeights = kryptonRadioButton3.Checked;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}