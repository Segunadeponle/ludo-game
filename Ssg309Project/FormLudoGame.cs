using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Ssg309Project
{
    public partial class FormLudoGame : Form
    {
        ulong turn = 0;
        Path p;
        PictureBox[] yellowPiece;
        PictureBox[] redPiece;
        PictureBox[] greenPiece;
        PictureBox[] bluePiece;
        public FormLudoGame()
        {
            InitializeComponent();
            LoadMoveableSection();
            p = new Path(panelsBlue, panelsGreen, panelsRed, panelsYellow);
            yellowPiece = new[] { yellowPiece1, yellowPiece2, yellowPiece3, yellowPiece4 };
            redPiece = new[] { redPiece1, redPiece2, redPiece3, redPiece4 };
            greenPiece = new[] { greenPiece1, greenPiece2, greenPiece3, greenPiece4 };
            bluePiece = new[] { bluePiece1, bluePiece2, bluePiece3, bluePiece4 };
            
        }

        private void LoadPlayerNames()
        {
            lblBlueName.Text ="";
            lblGreenName.Text = "";
            lblRedName.Text = "";
            lblYellowName.Text = "";
            foreach (var item in players)
            {
                switch (item.Color)
                {
                    case GameColor.Red:
                        lblRedName.Text = item.Name;
                        break;
                    case GameColor.Green:
                        lblGreenName.Text = item.Name;
                        break;
                    case GameColor.Blue:
                        lblBlueName.Text = item.Name;
                        break;
                    case GameColor.Yellow:
                        lblYellowName.Text = item.Name;
                        break;
                    default:
                        break;
                }
            }


        }
        BoxPanel[,] panelsYellow = new BoxPanel[6, 3];
        BoxPanel[,] panelsBlue = new BoxPanel[3, 6];
        BoxPanel[,] panelsRed = new BoxPanel[6, 3];
        BoxPanel[,] panelsGreen = new BoxPanel[3, 6];
        
        private void LoadMoveableSection()
        {

            for (int i = 0; i < panelsYellow.GetLength(0); i++)
            {
                for (int j = 0; j < panelsYellow.GetLength(1); j++)
                {
                    int width = 36, height = 36;
                    BoxPanel p = new BoxPanel();
                    p.BackColor = System.Drawing.Color.Transparent;
                    p.Location = new System.Drawing.Point(221 + (j * width), 326 + (i * height));
                    p.Name = "panel2";
                    p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                    p.Size = new System.Drawing.Size(width, height);
                    p.TabIndex = 1;
                    p.Click += p_Click;
                    p.ColorOfPiece = GameColor.Yellow;
                    panelsYellow[i, j] = p;
                }
            }
            for (int i = 0; i < panelsYellow.GetLength(0); i++)
            {
                for (int j = 0; j < panelsYellow.GetLength(1); j++)
                {
                    Controls.Add(panelsYellow[i, j]);
                }
            }

            for (int i = 0; i < panelsRed.GetLength(0); i++)
            {
                for (int j = 0; j < panelsRed.GetLength(1); j++)
                {
                    int width = 36, height = 36;
                    BoxPanel p = new BoxPanel();
                    p.BackColor = System.Drawing.Color.Transparent;
                    p.Location = new System.Drawing.Point(223 + (j * width), 9 + (i * height));
                    p.Name = "panel2";
                    p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                    p.Size = new System.Drawing.Size(width, height);
                    p.TabIndex = 1;
                    p.Click += p_Click;
                    p.ColorOfPiece = GameColor.Red;
                    panelsRed[i, j] = p;
                }
            }
            for (int i = 0; i < panelsRed.GetLength(0); i++)
            {
                for (int j = 0; j < panelsRed.GetLength(1); j++)
                {
                    Controls.Add(panelsRed[i, j]);
                }
            }
            for (int i = 0; i < panelsBlue.GetLength(0); i++)
            {
                for (int j = 0; j < panelsBlue.GetLength(1); j++)
                {
                    int width = 36, height = 36;
                    BoxPanel p = new BoxPanel();
                    p.BackColor = System.Drawing.Color.Transparent;
                    p.Location = new System.Drawing.Point(11 + (j * width), 220 + (i * height));
                    p.Name = "panel2";
                    p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                    p.Size = new System.Drawing.Size(width, height);
                    p.TabIndex = 1;
                    p.Click += p_Click;
                    p.ColorOfPiece = GameColor.Blue;
                    panelsBlue[i, j] = p;
                }
            }
            for (int i = 0; i < panelsBlue.GetLength(0); i++)
            {
                for (int j = 0; j < panelsBlue.GetLength(1); j++)
                {
                    Controls.Add(panelsBlue[i, j]);
                }
            }

            for (int i = 0; i < panelsGreen.GetLength(0); i++)
            {
                for (int j = 0; j < panelsGreen.GetLength(1); j++)
                {
                    int width = 36, height = 36;
                    BoxPanel p = new BoxPanel();
                    p.BackColor = System.Drawing.Color.Transparent;
                    p.Location = new System.Drawing.Point(328 + (j * width), 221 + (i * height));
                    p.Name = "panel2";
                    p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                    p.Size = new System.Drawing.Size(width, height);
                    p.TabIndex = 1;
                    p.Click += p_Click;
                    p.ColorOfPiece = GameColor.Green;
                    panelsGreen[i, j] = p;
                }
            }
            for (int i = 0; i < panelsGreen.GetLength(0); i++)
            {
                for (int j = 0; j < panelsGreen.GetLength(1); j++)
                {
                    Controls.Add(panelsGreen[i, j]);
                }
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        Image[] arrayOfDice = { global::Ssg309Project.Properties.Resources.Dice1,
                                  global::Ssg309Project.Properties.Resources.Dice2,
                                  global::Ssg309Project.Properties.Resources.Dice3,
                                  global::Ssg309Project.Properties.Resources.Dice4,
                                  global::Ssg309Project.Properties.Resources.Dice5,
                                  global::Ssg309Project.Properties.Resources.Dice6 };

        bool rolled = false;
        private void btnRollDice_Click(object sender, EventArgs e)
        {
            if (!rolled)
            {
                justStarted = false;
                timer1.Enabled = true;
                count = 0;
                rolled = true;
            }
        }
        int count = 0;
        int dice1 = 0, dice2 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 5)
            {
                Random rand = new Random();
                dice1 = rand.Next(1, 7);
                dice2 = rand.Next(1, 7);
                this.pbxDice1.Image = arrayOfDice[dice1-1];
                this.pbxDice2.Image = arrayOfDice[dice2-1];
                count++;
            }
        }

        private void yellowPiece1_Click(object sender, EventArgs e)
        {
            BringYellowOut(sender);
        }

        private void yellowPiece2_Click(object sender, EventArgs e)
        {

            BringYellowOut(sender);
        }

        private void yellowPiece3_Click(object sender, EventArgs e)
        {

            BringYellowOut(sender);
        }

        private void yellowPiece4_Click(object sender, EventArgs e)
        {
            BringYellowOut(sender);
            
        }
        bool justStarted = true;
        bool oneWasChecked = false;
        bool twoWasChecked = false;
        void BringPieceOut(object s,int x1,int x2,BoxPanel[,] panels,GameColor g)
        {
            PictureBox p1 = s as PictureBox;
            if (p1.BackgroundImage==null)
            {
                foreach (var item in players)
                {
                    if (item.Turn)
                    {

                        item.NumberOfPiecePlayed--;
                    }
                }
                MessageBox.Show("No pieces to move.");
                return;
            }
            if (justStarted)
            {
                foreach (var item in players)
                {
                    if (item.Turn)
                    {

                        item.NumberOfPiecePlayed--;
                    }
                }
                MessageBox.Show("You must roll the dice first");
                return;
            }
            DiceChoice dc = new DiceChoice();
            
            dc.SetLabels("First dice = " + dice1, "Second dice = " + dice2);
            foreach (var item in players)
            {
                if (item.Turn)
                {
                    if (item.NumberOfPiecePlayed==2)
                    {
                        if (oneWasChecked)
                        {
                            dc.SetChoice(Choice.Disable1);
                        }
                        else if (twoWasChecked)
                        {
                            dc.SetChoice(Choice.Disable2);
                        }
                    }
                    else if (item.NumberOfPiecePlayed==0)
                    {
                        oneWasChecked = false;
                        twoWasChecked = false;
                    }
                }
            }
            if (dc.ShowDialog() == DialogResult.OK)
            {
                if (dc.IsOneChecked() && dice1 != 6)
                {
                    MessageBox.Show("You need a 6 to bring this player out");
                    foreach (var item in players)
                    {
                        if (item.Turn)
                        {

                            item.NumberOfPiecePlayed--;
                        }
                    }
                }
                else if (!dc.IsOneChecked() && dice2 != 6)
                {
                    MessageBox.Show("You need a 6 to bring this player out");
                    foreach (var item in players)
                    {
                        if (item.Turn)
                        {

                            item.NumberOfPiecePlayed--;
                        }
                    }
                }
                else
                {

                    if (dc.IsOneChecked())
                    {
                        oneWasChecked = true;
                    }
                    else
                    {
                        twoWasChecked = true;
                    }
                    
                    if (panels[x1, x2].BackgroundImage==null)
                    {
                        PictureBox p = s as PictureBox;
                        panels[x1, x2].BackgroundImage = p.BackgroundImage;
                        panels[x1, x2].ColorOfPiece = g;
                        p.BackgroundImage = null;
                        panels[x1, x2].NumberOfPiece++;
                    }
                    else
                    {
                        if (panels[x1, x2].ColorOfPiece==g)
                        {
                            PictureBox p = s as PictureBox;
                            panels[x1, x2].BackgroundImage = p.BackgroundImage;
                            panels[x1, x2].ColorOfPiece = g;
                            p.BackgroundImage = null;
                            panels[x1, x2].NumberOfPiece++;
                        }
                        else
                        {
                            switch (panels[x1, x2].ColorOfPiece)
                            {
                                case GameColor.Red:
                                    while (panels[x1, x2].NumberOfPiece >= 1)
                                    {
                                        for (int i = 0; i < redPiece.Length; i++)
                                        {
                                            if (redPiece[i].BackgroundImage == null)
                                            {
                                                redPiece[i].BackgroundImage = panels[x1, x2].BackgroundImage;
                                                PictureBox p = s as PictureBox;
                                                panels[x1, x2].BackgroundImage = p.BackgroundImage;

                                                p.BackgroundImage = null;
                                                if (panels[x1, x2].NumberOfPiece > 0)
                                                {

                                                    panels[x1, x2].NumberOfPiece--;
                                                }
                                                break;
                                            }
                                        }
                                    }
                                    break;
                                case GameColor.Green:
                                    while (panels[x1, x2].NumberOfPiece >= 1)
                                    {
                                        for (int i = 0; i < greenPiece.Length; i++)
                                        {
                                            if (greenPiece[i].BackgroundImage == null)
                                            {
                                                greenPiece[i].BackgroundImage = panels[x1, x2].BackgroundImage;
                                                PictureBox p = s as PictureBox;
                                                panels[x1, x2].BackgroundImage = p.BackgroundImage;

                                                p.BackgroundImage = null;
                                                if (panels[x1, x2].NumberOfPiece > 0)
                                                {

                                                    panels[x1, x2].NumberOfPiece--;
                                                }
                                                break;
                                            }
                                        }
                                    }
                                    break;
                                case GameColor.Blue:
                                    while (panels[x1, x2].NumberOfPiece >= 1)
                                    {
                                        for (int i = 0; i < bluePiece.Length; i++)
                                        {
                                            if (bluePiece[i].BackgroundImage == null)
                                            {
                                                bluePiece[i].BackgroundImage = panels[x1, x2].BackgroundImage;
                                                PictureBox p = s as PictureBox;
                                                panels[x1, x2].BackgroundImage = p.BackgroundImage;

                                                p.BackgroundImage = null;
                                                if (panels[x1, x2].NumberOfPiece>0)
                                                {

                                                    panels[x1, x2].NumberOfPiece--;
                                                }
                                                break;
                                            }
                                        }
                                    }
                                    break;
                                case GameColor.Yellow:
                                    while (panels[x1, x2].NumberOfPiece >= 1)
                                    {
                                        for (int i = 0; i < yellowPiece.Length; i++)
                                        {
                                            if (yellowPiece[i].BackgroundImage == null)
                                            {
                                                yellowPiece[i].BackgroundImage = panels[x1, x2].BackgroundImage;
                                                PictureBox p = s as PictureBox;
                                                panels[x1, x2].BackgroundImage = p.BackgroundImage;

                                                p.BackgroundImage = null;
                                                if (panels[x1, x2].NumberOfPiece > 0)
                                                {

                                                    panels[x1, x2].NumberOfPiece--;
                                                }
                                                break;
                                            }
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }
                            panels[x1, x2].NumberOfPiece++;
                        }
                        
                    }
                    foreach (var item in players)
                    {
                        if (item.Turn)
                        {

                            if (item.NumberOfPiecePlayed == 2)
                            {
                                if (dice1 == 6 && dice2 == 6)
                                {
                                    players[turn % (ulong)players.Length].NumberOfPiecePlayed = 0;
                                    rolled = false;
                                    justStarted = true;
                                    lbxScoreBoard.Items.Add(string.Format("It's Player {0}'s turn to play again", players[turn % (ulong)players.Length].Name, players[turn % (ulong)players.Length].Color));
                                    lbxScoreBoard.SelectedIndex = lbxScoreBoard.Items.Count - 1;
                                    oneWasChecked = false;
                                    twoWasChecked = false;
                                }
                                else
                                {
                                    item.Turn = false;
                                    turn++;
                                    players[turn % (ulong)players.Length].Turn = true;
                                    players[turn % (ulong)players.Length].NumberOfPiecePlayed = 0;
                                    rolled = false;
                                    justStarted = true;
                                    lbxScoreBoard.Items.Add(string.Format("It's Player {0}'s turn to play", players[turn % (ulong)players.Length].Name, players[turn % (ulong)players.Length].Color));
                                    lbxScoreBoard.SelectedIndex = lbxScoreBoard.Items.Count - 1;
                                    oneWasChecked = false;
                                    twoWasChecked = false;
                                }
                            }
                        }
                    }
                }
            }


        }
        void BringYellowOut(object s)
        {
            bool found = false;
            foreach (var item in players)
            {
                if (item.Color == GameColor.Yellow && item.Turn)
                {

                    found = true;
                    item.NumberOfPiecePlayed++;
                }
            }
            if (!found)
            {
                MessageBox.Show("It's not your turn to play.");
                return;
            }
            BringPieceOut(s,4,0,panelsYellow,GameColor.Yellow);
        }

        Player[] players;
        internal void SetPlayers(Player[] players)
        {
            this.players = players;
            List<GameColor> l = new List<GameColor>(new[] { GameColor.Blue,GameColor.Green,
                GameColor.Red,GameColor.Yellow});
            foreach (var item in players)
            {
                if (l.Contains(item.Color))
                {
                    l.Remove(item.Color);
                }
            }
            foreach (var item in l)
            {
                
                switch (item)
                {
                    case GameColor.Red:
                        redPiece1.BackgroundImage = null;
                        redPiece1.Enabled = false;
                        redPiece2.BackgroundImage = null;
                        redPiece2.Enabled = false;
                        redPiece3.BackgroundImage = null;
                        redPiece3.Enabled = false;
                        redPiece4.BackgroundImage = null;
                        redPiece4.Enabled = false;
                        break;
                    case GameColor.Green:
                        
                        greenPiece1.BackgroundImage = null;
                        greenPiece1.Enabled = false;
                        greenPiece2.BackgroundImage = null;
                        greenPiece2.Enabled = false;
                        greenPiece3.BackgroundImage = null;
                        greenPiece3.Enabled = false;
                        greenPiece4.BackgroundImage = null;
                        greenPiece4.Enabled = false;
                        break;
                    case GameColor.Blue:
                        bluePiece1.BackgroundImage = null;
                        bluePiece1.Enabled = false;
                        bluePiece2.BackgroundImage = null;
                        bluePiece2.Enabled = false;
                        bluePiece3.BackgroundImage = null;
                        bluePiece3.Enabled = false;
                        bluePiece4.BackgroundImage = null;
                        bluePiece4.Enabled = false;
                        break;
                    case GameColor.Yellow:
                        yellowPiece1.BackgroundImage = null;
                        yellowPiece1.Enabled = false;
                        yellowPiece2.BackgroundImage = null;
                        yellowPiece2.Enabled = false;
                        yellowPiece3.BackgroundImage = null;
                        yellowPiece3.Enabled = false;
                        yellowPiece4.BackgroundImage = null;
                        yellowPiece4.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
            foreach (var item in players)
            {
                lbxScoreBoard.Items.Add(string.Format("Player {0} created with color {1}", item.Name, item.Color));
            }
            lbxScoreBoard.Items.Add(string.Format("It's Player {0}'s turn to play", players[0].Name, players[0].Color));
            players[0].Turn = true;
            LoadPlayerNames();
        }
        void BringGreenOut(object s)
        {
            bool found = false;
            foreach (var item in players)
            {
                if (item.Color == GameColor.Green && item.Turn)
                {

                    found = true;
                    item.NumberOfPiecePlayed++;
                }
            }
            if (!found)
            {
                MessageBox.Show("It's not your turn to play.");
                return;
            }
            BringPieceOut(s, 2, 4, panelsGreen,GameColor.Green);
        }
        private void greenPiece1_Click(object sender, EventArgs e)
        {
            BringGreenOut(sender);
        }

        

        private void greenPiece2_Click(object sender, EventArgs e)
        {
            BringGreenOut(sender);
        }

        private void greenPiece3_Click(object sender, EventArgs e)
        {
            BringGreenOut(sender);
        }

        private void greenPiece4_Click(object sender, EventArgs e)
        {
            BringGreenOut(sender);
        }

        void BringRedOut(object s)
        {
            bool found = false;
            foreach (var item in players)
            {
                if (item.Color == GameColor.Red && item.Turn)
                {

                    found = true;
                    item.NumberOfPiecePlayed++;
                }
            }
            if (!found)
            {
                MessageBox.Show("It's not your turn to play.");
                return;
            }
            BringPieceOut(s, 1,2, panelsRed,GameColor.Red);
        }

        private void redPiece1_Click(object sender, EventArgs e)
        {
            BringRedOut(sender);
        }

        private void redPiece2_Click(object sender, EventArgs e)
        {
            BringRedOut(sender);
        }

        private void redPiece3_Click(object sender, EventArgs e)
        {
            BringRedOut(sender);
        }

        private void redPiece4_Click(object sender, EventArgs e)
        {
            BringRedOut(sender);
        }
        void BringBlueOut(object s)
        {
            bool found = false;
            foreach (var item in players)
            {
                if (item.Color == GameColor.Blue && item.Turn)
                {

                    found = true;
                    item.NumberOfPiecePlayed++;
                }
            }
            if (!found)
            {
                MessageBox.Show("It's not your turn to play.");
                return;
            }
            BringPieceOut(s, 0, 1, panelsBlue,GameColor.Blue);
        }

        private void bluePiece1_Click(object sender, EventArgs e)
        {
            BringBlueOut(sender);
        }

        private void bluePiece2_Click(object sender, EventArgs e)
        {
            BringBlueOut(sender);
        }

        private void bluePiece3_Click(object sender, EventArgs e)
        {
            BringBlueOut(sender);
        }

        private void bluePiece4_Click(object sender, EventArgs e)
        {
            BringBlueOut(sender);
        }

        void p_Click(object sender, EventArgs e)
        {
            BoxPanel bp = sender as BoxPanel;
            foreach (var item in players)
            {
                if ((item.Turn && bp.ColorOfPiece != item.Color))
                {
                    MessageBox.Show("It's not your turn to play.");
                    return; 
                }
            }
           /* 

            bool found = false;
            foreach (var item in players)
            {
                if (item.Color == GameColor.Blue && item.Turn)
                {

                    found = true;
                    item.NumberOfPiecePlayed++;
                }
            }
            if (!found)
            {
                MessageBox.Show("It's not your turn to play.");
                return;
            }

            */
            if (bp.BackgroundImage==null)
            {
                MessageBox.Show("No piece to move.");
                return;

            }
            if (justStarted)
            {
                MessageBox.Show("You must roll the dice first");
                return;
            }
            DiceChoice dc = new DiceChoice();

            dc.SetLabels("First dice = " + dice1, "Second dice = " + dice2);
            foreach (var item in players)
            {
                if (item.Turn)
                {
                    if (item.NumberOfPiecePlayed == 1)
                    {
                        if (oneWasChecked)
                        {
                            dc.SetChoice(Choice.Disable1);
                        }
                        else if (twoWasChecked)
                        {
                            dc.SetChoice(Choice.Disable2);
                        }
                    }
                    else if (item.NumberOfPiecePlayed == 0)
                    {
                        oneWasChecked = false;
                        twoWasChecked = false;
                    }
                }
            }
            if (dc.ShowDialog() == DialogResult.OK)
            {
                if (dc.IsOneChecked())
                {
                    oneWasChecked = true;
                }
                else
                {
                    twoWasChecked = true;
                }
                //PictureBox p = s as PictureBox;
                //panels[x1, x2].BackgroundImage = p.BackgroundImage;
                //panels[x1, x2].ColorOfPiece = g;
                //p.BackgroundImage = null;
                //panels[x1, x2].NumberOfPiece++;


                foreach (var item in players)
                {
                    if (item.Turn)
                    {
                        item.NumberOfPiecePlayed++;
                        if (item.NumberOfPiecePlayed == 2)
                        {
                            if (dice1 == 6 && dice2 == 6)
                            {
                                players[turn % (ulong)players.Length].NumberOfPiecePlayed = 0;
                                rolled = false;
                                justStarted = true;
                                lbxScoreBoard.Items.Add(string.Format("It's Player {0}'s turn to play again", players[turn % (ulong)players.Length].Name, players[turn % (ulong)players.Length].Color));
                                lbxScoreBoard.SelectedIndex = lbxScoreBoard.Items.Count - 1;
                                oneWasChecked = false;
                                twoWasChecked = false;
                            }
                            else
                            {
                                item.Turn = false;
                                turn++;
                                players[turn % (ulong)players.Length].Turn = true;
                                players[turn % (ulong)players.Length].NumberOfPiecePlayed = 0;
                                rolled = false;
                                justStarted = true;
                                lbxScoreBoard.Items.Add(string.Format("It's Player {0}'s turn to play", players[turn % (ulong)players.Length].Name, players[turn % (ulong)players.Length].Color));
                                lbxScoreBoard.SelectedIndex = lbxScoreBoard.Items.Count - 1;
                                oneWasChecked = false;
                                twoWasChecked = false;
                            }
                            break;
                        }
                    }
                }
            }
            int num = 0;
            if (dc.IsOneChecked())
            {
                num = dice1;
            }
            else
            {
                num = dice2;
            }
            switch (bp.ColorOfPiece)
            {
                case GameColor.Red:
                    {
                        var loc = p.redPath.IndexOf(bp);
                        try
                        {


                            CheckBoardBox(loc,num,p.redPath,GameColor.Red);
                        }
                        catch (Exception)
                        {
                            int x = int.Parse(lblRed.Text);
                            x++;
                            lblRed.Text = x.ToString();
                            p.redPath[loc].BackgroundImage = null;
                        }
                    }
                    
                    break;
                case GameColor.Green:
                    {
                        var loc = p.greenPath.IndexOf(bp);
                        try
                        {
                            CheckBoardBox(loc, num, p.greenPath, GameColor.Green);
                        }
                        catch (Exception)
                        {
                            int x = int.Parse(lblGreen.Text);
                            x++;
                            lblGreen.Text = x.ToString();
                            p.greenPath[loc].BackgroundImage = null;
                        }
                    }
                    
                    break;
                case GameColor.Blue:
                    {
                        var loc = p.bluePath.IndexOf(bp);
                        try
                        {
                            CheckBoardBox(loc, num, p.bluePath, GameColor.Blue);
                        }
                        catch (Exception)
                        {
                            int x = int.Parse(lblBlue.Text);
                            x++;
                            lblBlue.Text = x.ToString();
                            p.bluePath[loc].BackgroundImage = null;
                        }
                    }
                    
                    break;
                case GameColor.Yellow:
                    {
                        var loc = p.yellowPath.IndexOf(bp);
                        try
                        {
                            CheckBoardBox(loc, num, p.yellowPath, GameColor.Yellow);
                        }
                        catch (Exception)
                        {
                            int x = int.Parse(lblYellow.Text);
                            x++;
                            lblYellow.Text = x.ToString();
                            p.yellowPath[loc].BackgroundImage = null;
                        }
                    }
                    
                    break;
                default:
                    break;
            }
            


        }

        private void CheckBoardBox(int loc,int num,List<BoxPanel> box,GameColor g)
        {


            if (box[loc + num].BackgroundImage == null)
            {
                BoxPanel p = box[loc];
                box[loc + num].BackgroundImage = p.BackgroundImage;
                box[loc + num].ColorOfPiece = g;
                p.BackgroundImage = null;
                box[loc + num].NumberOfPiece++;
            }
            else
            {
                if (box[loc + num].ColorOfPiece == g)
                {
                    BoxPanel p = box[loc];
                    box[loc + num].BackgroundImage = p.BackgroundImage;
                    box[loc + num].ColorOfPiece = g;
                    p.BackgroundImage = null;
                    box[loc + num].NumberOfPiece++;
                }
                else
                {
                    switch (box[loc + num].ColorOfPiece)
                    {
                        case GameColor.Red:
                            //while (box[loc + num].NumberOfPiece >= 1)
                            {
                                for (int i = 0; i < redPiece.Length; i++)
                                {
                                    if (redPiece[i].BackgroundImage == null)
                                    {
                                        redPiece[i].BackgroundImage = box[loc + num].BackgroundImage;
                                        BoxPanel p = box[loc];
                                        box[loc + num].BackgroundImage = p.BackgroundImage;

                                        p.BackgroundImage = null;
                                        if (box[loc + num].NumberOfPiece > 0)
                                        {

                                            box[loc + num].NumberOfPiece--;
                                        }
                                        break;
                                    }
                                }
                            }
                            break;
                        case GameColor.Green:
                            //while (box[loc + num].NumberOfPiece >= 1)
                            {
                                for (int i = 0; i < greenPiece.Length; i++)
                                {
                                    if (greenPiece[i].BackgroundImage == null)
                                    {
                                        greenPiece[i].BackgroundImage = box[loc + num].BackgroundImage;
                                        BoxPanel p = box[loc];
                                        box[loc + num].BackgroundImage = p.BackgroundImage;

                                        p.BackgroundImage = null;
                                        if (box[loc + num].NumberOfPiece > 0)
                                        {

                                            box[loc + num].NumberOfPiece--;
                                        }
                                        break;
                                    }
                                }
                            }
                            break;
                        case GameColor.Blue:
                            //while (box[loc + num].NumberOfPiece >= 1)
                            {
                                for (int i = 0; i < bluePiece.Length; i++)
                                {
                                    if (bluePiece[i].BackgroundImage == null)
                                    {
                                        bluePiece[i].BackgroundImage = box[loc + num].BackgroundImage;
                                        BoxPanel p = box[loc];
                                        box[loc + num].BackgroundImage = p.BackgroundImage;

                                        p.BackgroundImage = null;
                                        if (box[loc + num].NumberOfPiece > 0)
                                        {

                                            box[loc + num].NumberOfPiece--;
                                        }
                                        break;
                                    }
                                }
                            }
                            break;
                        case GameColor.Yellow:
                            //while (box[loc + num].NumberOfPiece >= 1)
                            {
                                for (int i = 0; i < yellowPiece.Length; i++)
                                {
                                    if (yellowPiece[i].BackgroundImage == null)
                                    {
                                        yellowPiece[i].BackgroundImage = box[loc + num].BackgroundImage;
                                        BoxPanel p = box[loc];
                                        box[loc + num].BackgroundImage = p.BackgroundImage;

                                        p.BackgroundImage = null;
                                        if (box[loc + num].NumberOfPiece > 0)
                                        {

                                            box[loc + num].NumberOfPiece--;
                                        }
                                        break;
                                    }
                                }
                            }
                            break;
                        default:
                            break;
                    }
                    box[loc + num].NumberOfPiece++;
                }

            }
        }

        private void btnMissATurn_Click(object sender, EventArgs e)
        {
            foreach (var item in players)
            {
                if (item.Turn)
                {
                        item.Turn = false;
                        turn++;
                        players[turn % (ulong)players.Length].Turn = true;
                        players[turn % (ulong)players.Length].NumberOfPiecePlayed = 0;
                        rolled = false;
                        justStarted = true;
                        lbxScoreBoard.Items.Add(string.Format("It's Player {0}'s turn to play", players[turn % (ulong)players.Length].Name, players[turn % (ulong)players.Length].Color));
                        lbxScoreBoard.SelectedIndex = lbxScoreBoard.Items.Count - 1;
                        break;
                }
            }
        }

        private void FormLudoGame_Load(object sender, EventArgs e)
        {

        }


    

    }
}
