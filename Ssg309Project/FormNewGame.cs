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
    public partial class FormNewGame : Form
    {
        public FormNewGame()
        {
            InitializeComponent();

            tbxBluePlayer.Hide();
            tbxGreenPlayer.Hide();
            tbxRedPlayer.Hide();
            tbxYellowPlayer.Hide();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            List<Player> l = new List<Player>();
            FormLudoGame flg = new FormLudoGame();

            if (cbxYellowPlayer.Checked)
            {
                if (tbxYellowPlayer.Text == "")
                {
                    MessageBox.Show("You must enter a name for the Yellow Player");
                    return;
                }
                l.Add(new Player() { Name = tbxYellowPlayer.Text, Color = GameColor.Yellow });
            }
            if (cbxBluePlayer.Checked)
            {
                if (tbxBluePlayer.Text=="")
                {
                    MessageBox.Show("You must enter a name for the Blue Player");
                    return;
                }
                l.Add(new Player() { Name = tbxBluePlayer.Text, Color = GameColor.Blue });

            }
            if (cbxGreenPlayer.Checked)
            {
                if (tbxGreenPlayer.Text == "")
                {
                    MessageBox.Show("You must enter a name for the Green Player");
                    return;
                }
                l.Add(new Player() { Name = tbxGreenPlayer.Text, Color = GameColor.Green });
            }
            if (cbxRedPlayer.Checked)
            {
                if (tbxRedPlayer.Text == "")
                {
                    MessageBox.Show("You must enter a name for the Red Player");
                    return;
                }
                l.Add(new Player() { Name = tbxRedPlayer.Text, Color = GameColor.Red });
            }
            if (l.Count<2)
            {
                MessageBox.Show("At least two players must be selected");
                return;
            }
            flg.SetPlayers(l.ToArray());
            flg.ShowDialog();

        }

        private void cbxBluePlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxBluePlayer.Checked)
            {
                tbxBluePlayer.Show();
            }
            else
            {
                tbxBluePlayer.Hide();
            }
        }

        private void cbxRedPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRedPlayer.Checked)
            {
                tbxRedPlayer.Show();
            }
            else
            {
                tbxRedPlayer.Hide();
            }
        }

        private void cbxGreenPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxGreenPlayer.Checked)
            {
                tbxGreenPlayer.Show();
            }
            else
            {
                tbxGreenPlayer.Hide();
            }
        }

        private void cbxYellowPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxYellowPlayer.Checked)
            {
                tbxYellowPlayer.Show();
            }
            else
            {
                tbxYellowPlayer.Hide();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tbxBluePlayer.Text = "";
            tbxGreenPlayer.Text = "";
            tbxRedPlayer.Text = "";
            tbxYellowPlayer.Text = "";
        }
    }
}
