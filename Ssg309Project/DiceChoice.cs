using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ssg309Project
{
    public partial class DiceChoice : Form
    {
        public DiceChoice()
        {
            InitializeComponent();
            
        }
        bool close = false;
        private Choice c;
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            close = true;

        }
        public void SetLabels(string x1,string x2)
        {
            radioButton1.Text = x1;
            radioButton2.Text = x2;
        }
        public bool IsOneChecked()
        {
            return radioButton1.Checked;
        }

        private void DiceChoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!close)
            {
                var window = MessageBox.Show("If you close this for a selection would be made for you automatically", "Warning", buttons: MessageBoxButtons.YesNo);
                if (window == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                    DialogResult = DialogResult.OK;
                }
            }
        }

        internal void SetChoice(Choice c)
        {
            this.c = c;
            switch (c)
            {
                case Choice.None:
                    break;
                case Choice.Disable1:
                    radioButton1.Enabled = false;
                    radioButton2.Checked = true;
                    break;
                case Choice.Disable2:
                    radioButton2.Enabled = false;
                    radioButton1.Checked = true;
                    break;
                default:
                    break;
            }
        }
    }
    enum Choice
    {
        None, Disable1, Disable2
    }
}
