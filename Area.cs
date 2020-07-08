using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sake_Snake
{
    class Area : PictureBox
    {
        public Area()
        {
            InitilaizeArea();
        }

        private void InitilaizeArea()
        {
            this.BackColor = Color.DodgerBlue;
            this.Height = 400;
            this.Width = 400;
        }
    }
}
