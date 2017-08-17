using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ssg309Project
{
    class Path
    {
        private BoxPanel[,] panelsBlue;
        private BoxPanel[,] panelsGreen;
        private BoxPanel[,] panelsRed;
        private BoxPanel[,] panelsYellow;
        public List<BoxPanel> bluePath;
        public List<BoxPanel> yellowPath;
        public List<BoxPanel> redPath;
        public List<BoxPanel> greenPath;
        public Path(BoxPanel[,] panelsBlue, BoxPanel[,] panelsGreen, BoxPanel[,] panelsRed, BoxPanel[,] panelsYellow)
        {
            // TODO: Complete member initialization
            this.panelsBlue = panelsBlue;
            this.panelsGreen = panelsGreen;
            this.panelsRed = panelsRed;
            this.panelsYellow = panelsYellow;
            bluePath = new List<BoxPanel>();
            yellowPath = new List<BoxPanel>();
            redPath = new List<BoxPanel>();
            greenPath = new List<BoxPanel>();
            LoadYellowPath();
            LoadBluePath();
            LoadRedPath();
            LoadGreenPath();
        }
        public void LoadYellowPath()
        {
            for (int i = 4; i >= 0; i--)
            {
                yellowPath.Add(panelsYellow[i, 0]);
            }
            for (int i = 5; i >= 1; i--)
            {
                yellowPath.Add(panelsBlue[2, i]);
            }
            for (int i = 2; i >= 1; i--)
            {
                yellowPath.Add(panelsBlue[i, 0]);
            }
            for (int i = 0; i <= 5; i++)
            {
                yellowPath.Add(panelsBlue[0,i]);
            }
            for (int i = 5; i >= 1; i--)
            {
                yellowPath.Add(panelsRed[i, 0]);
            }
            for (int i = 0; i <= 1; i++)
            {
                yellowPath.Add(panelsRed[0,i]);
            }
            for (int i = 0; i <= 5; i++)
            {
                yellowPath.Add(panelsRed[i,2]);
            }
            for (int i = 0; i <= 4; i++)
            {
                yellowPath.Add(panelsGreen[0,i]);
            }
            for (int i = 0; i <= 1; i++)
            {
                yellowPath.Add(panelsGreen[i,5]);
            }
            for (int i = 5; i >= 0; i--)
            {
                yellowPath.Add(panelsGreen[2, i]);
            }
            for (int i = 0; i <= 5; i++)
            {
                yellowPath.Add(panelsYellow[i,2]);
            }
            for (int i = 5; i >= 0; i--)
            {
                yellowPath.Add(panelsYellow[i,1]);
            }

        }

        public void LoadBluePath()
        {
            for (int i = 1; i <= 5; i++)
            {
                bluePath.Add(panelsBlue[0, i]);
            }
            for (int i = 5; i >= 1; i--)
            {
                bluePath.Add(panelsRed[i, 0]);
            }
            for (int i = 0; i <= 1; i++)
            {
                bluePath.Add(panelsRed[0, i]);
            }
            for (int i = 0; i <= 5; i++)
            {
                bluePath.Add(panelsRed[i, 2]);
            }
            for (int i = 0; i <= 4; i++)
            {
                bluePath.Add(panelsGreen[0, i]);
            }
            for (int i = 0; i <= 1; i++)
            {
                bluePath.Add(panelsGreen[i, 5]);
            }
            for (int i = 5; i >= 0; i--)
            {
                bluePath.Add(panelsGreen[2, i]);
            }
            for (int i = 0; i <= 4; i++)
            {
                bluePath.Add(panelsYellow[i, 2]);
            }
            for (int i = 2; i >= 1; i--)
            {
                bluePath.Add(panelsYellow[5, i]);
            }
            for (int i = 5; i >= 0; i--)
            {
                bluePath.Add(panelsYellow[i,0]);
            }
            for (int i = 5; i >= 0; i--)
            {
                bluePath.Add(panelsBlue[2,i]);
            }
            for (int i = 0; i <= 5; i++)
            {
                bluePath.Add(panelsBlue[1,i]);
            }




        }


        public void LoadRedPath()
        {
            for (int i = 1; i <= 5; i++)
            {
                redPath.Add(panelsRed[i, 2]);
            }
            for (int i = 0; i <= 4; i++)
            {
                redPath.Add(panelsGreen[0, i]);
            }
            for (int i = 0; i <= 1; i++)
            {
                redPath.Add(panelsGreen[i, 5]);
            }
            for (int i = 5; i >= 0; i--)
            {
                redPath.Add(panelsGreen[2, i]);
            }
            for (int i = 0; i <= 4; i++)
            {
                redPath.Add(panelsYellow[i, 2]);
            }
            for (int i = 2; i >= 1; i--)
            {
                redPath.Add(panelsYellow[5, i]);
            }
            for (int i = 5; i >= 0; i--)
            {
                redPath.Add(panelsYellow[i, 0]);
            }
            for (int i = 5; i >= 1; i--)
            {
                redPath.Add(panelsBlue[2, i]);
            }
            for (int i = 2; i >= 1; i--)
            {
                redPath.Add(panelsBlue[i,0]);
            }
            for (int i = 0; i <= 5; i++)
            {
                redPath.Add(panelsBlue[0, i]);
            }
            for (int i = 5; i >= 0; i--)
            {
                redPath.Add(panelsRed[i, 0]);
            }
            for (int i = 0; i <= 5; i++)
            {
                redPath.Add(panelsRed[i,1]);
            }
        }


        internal void LoadGreenPath()
        {
            for (int i = 4; i >= 0; i--)
            {
                greenPath.Add(panelsGreen[2, i]);
            }
            for (int i = 0; i <= 4; i++)
            {
                greenPath.Add(panelsYellow[i, 2]);
            }
            for (int i = 2; i >= 1; i--)
            {
                greenPath.Add(panelsYellow[5, i]);
            }
            for (int i = 5; i >= 0; i--)
            {
                greenPath.Add(panelsYellow[i, 0]);
            }
            for (int i = 5; i >= 1; i--)
            {
                greenPath.Add(panelsBlue[2, i]);
            }
            for (int i = 2; i >= 1; i--)
            {
                greenPath.Add(panelsBlue[i, 0]);
            }
            for (int i = 0; i <= 5; i++)
            {
                greenPath.Add(panelsBlue[0, i]);
            }
            for (int i = 5; i >= 1; i--)
            {
                greenPath.Add(panelsRed[i, 0]);
            }
            for (int i = 0; i <= 1; i++)
            {
                greenPath.Add(panelsRed[0,i]);
            }
            for (int i = 0; i <= 5; i++)
            {
                greenPath.Add(panelsRed[i,2]);
            }
            for (int i = 0; i <= 5; i++)
            {
                greenPath.Add(panelsGreen[0, i]);
            }
            for (int i = 5; i >= 0; i--)
            {
                greenPath.Add(panelsGreen[1,i]);
            }
        }
    }
}
