using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sake_Snake
{
    class Snake
    {
        List<PictureBox> snakePixels = new List<PictureBox>();

        public Snake()
        {
            InitializeSnake();
        }

        private void InitializeSnake()
        {
            AddSnakePixel(300, 300);
            AddSnakePixel(300, 321);
            AddSnakePixel(300, 342);
        }

        private void AddSnakePixel(int left, int top)
        {
            PictureBox snakePixel;
            snakePixel = new PictureBox();
            snakePixel.Height = 20;
            snakePixel.Width = 20;
            snakePixel.BackColor = Color.Tomato;
            snakePixel.Left = left;
            snakePixel.Top = top;
            snakePixels.Add(snakePixel);
        }

        public void Render(Form form)
        {
            foreach(var sp in snakePixels)
            {
                form.Controls.Add(sp);
                sp.BringToFront();
            }
        }
    }
}
