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
    public partial class EdgeWightInputDialog : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public Int32 Value { get; private set; }
        public EdgeWightInputDialog()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Value = Convert.ToInt32(kryptonNumericUpDown1.Value);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void EdgeWightInputDialog_Load(object sender, EventArgs e)
        {

        }

    }
}